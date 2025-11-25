using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using ProductShop.Utilities;
using System.ComponentModel.DataAnnotations;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            using ProductShopContext dbContext = new ProductShopContext();

            //ResetAndSeedDatabase(dbContext);
            string result = GetCategoriesByProductsCount(dbContext);
            //WriteSerializationResult("users-and-products.xml", result);
            Console.WriteLine(result);
        }

        // Problem 1

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            ICollection<User> usersToImport = new List<User>();

            ImportUserDto[]? importUserDtos = XmlSerializerWrapper
                .Deserialize<ImportUserDto[]>(inputXml, "Users");

            if (importUserDtos != null)
            {
                foreach (var userDto in importUserDtos)
                {
                    if (!IsValid(userDto))
                    {
                        continue;
                    }

                    int? age = null!;

                    if (userDto.Age != null)
                    {
                        bool isAgeParsible = int.TryParse(userDto.Age, out int parsedAge);

                        age = parsedAge;
                    }

                    User newUser = new User()
                    {
                        FirstName = userDto.FirstName,
                        LastName = userDto.LastName,
                        Age = age
                    };
                    usersToImport.Add(newUser);
                }

                context.AddRange(usersToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {usersToImport.Count}";
        }

        // Problem 2

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            ICollection<Product> productsToImport = new List<Product>();

            ImportProductDto[]? importProductDtos = XmlSerializerWrapper
                .Deserialize<ImportProductDto[]>(inputXml, "Products");

            if (importProductDtos != null)
            {
                foreach (var product in importProductDtos)
                {
                    if (!IsValid(product))
                    {
                        continue;
                    }
                    
                    decimal price = decimal.Parse(product.Price);                        

                    int? buyerId = null!;
                    if (product.BuyerId != null)
                    {
                        bool isBuyerIdParsible = int.TryParse(product.BuyerId, out int buyerIdParsible);
                        buyerId = buyerIdParsible;
                    }
                    
                    int SellerId = int.Parse(product.SellerId);

                    productsToImport.Add(new Product()
                    {
                        Name = product.Name,
                        Price = price,
                        SellerId = SellerId,
                        BuyerId = buyerId
                    });                   
                    
                }

                context.AddRange(productsToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {productsToImport.Count}";
        }

        // Problem 3

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            ICollection<Category> categoriesToImport = new List<Category>();

            ImportCategoryDto[]? importCategoryDtos = XmlSerializerWrapper
                .Deserialize<ImportCategoryDto[]>(inputXml, "Categories");

            if (importCategoryDtos != null)
            {
                foreach (var categoryDto in importCategoryDtos)
                {
                    if (!IsValid(categoryDto))
                    {
                        continue;
                    }

                    Category newCategory = new Category()
                    {
                        Name = categoryDto.Name
                    };
                    categoriesToImport.Add(newCategory);

                }
                context.AddRange(categoriesToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {categoriesToImport.Count}";
        }

        // Problem 4

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            ICollection<CategoryProduct> categoryProductsToImport = new List<CategoryProduct>();

            ImportCategoryProductDto[]? importCategoryProductsDtos = XmlSerializerWrapper
                .Deserialize<ImportCategoryProductDto[]>(inputXml, "CategoryProducts");

            if (importCategoryProductsDtos != null)
            {
                foreach (var categoryProductsDto in importCategoryProductsDtos)
                {
                    if (!IsValid(categoryProductsDto))
                    {
                        continue;
                    }

                    int categoryId = int.Parse(categoryProductsDto.CategoryId);
                    int productId = int.Parse(categoryProductsDto.ProductId);

                    CategoryProduct newCategoryProduct = new CategoryProduct()
                    {
                        CategoryId = categoryId,
                        ProductId = productId
                    };

                    categoryProductsToImport.Add(newCategoryProduct);
                }

                context.AddRange(categoryProductsToImport);
                context.SaveChanges();
            }

            return $"Successfully imported {categoryProductsToImport.Count}";
        }

        // Problem 5

        public static string GetProductsInRange(ProductShopContext context)
        {
            ExportProductDto[] product = context.Products                
                .AsNoTracking()
                .Where(p => p.Price >= 500 &&  p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ExportProductDto
                {
                    ProductName = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                })                
                .Take(10)
                .ToArray();

            string result = XmlSerializerWrapper
                .Serialize(product, "Products");
            return result;

        }

        // Problem 6

        public static string GetSoldProducts(ProductShopContext context)
        {
            var soldProducts = context.Users
                .Include(u => u.ProductsSold)
                .AsNoTracking()
                .Where(u => u.ProductsSold.Any())
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new ExportSellersDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                        .Select(ps => new ExportSellerProductDto()
                        {
                            ProductName = ps.Name,
                            Price = ps.Price,
                        })
                        .ToArray()
                    
                })
                .Take (5)
                .ToArray();

            string result = XmlSerializerWrapper
               .Serialize(soldProducts, "Users");
            return result;
        }

        // Problem 7

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            ExportCategoryDto[] categories = context.Categories
                .Select(c => new ExportCategoryDto()
                {
                    CategoryName = c.Name,
                    ProductsCount = c.CategoryProducts.Count(),
                    AveragePrice = c.CategoryProducts
                        .Select(cp => cp.Product.Price).Sum() / c.CategoryProducts.Count,
                    TotalPrice = c.CategoryProducts
                        .Select(cp => cp.Product.Price).Sum()
                })
                .OrderByDescending(c => c.ProductsCount)
                .ThenBy(c => c.TotalPrice)                        
                .ToArray();

            string result = XmlSerializerWrapper
               .Serialize(categories, "Categories");
            return result;
        }

        // Problem 8

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            ExportUsersCountDto rootDto = new ExportUsersCountDto()
            {
                TotalUsersCount = context.Users
                    .Include(u => u.ProductsSold)
                    .AsNoTracking()
                    .Count(u => u.ProductsSold.Any()),

                Users = context.Users
                    .Include(u => u.ProductsSold)
                    .AsNoTracking()
                    .Where(u => u.ProductsSold.Any())
                    .Select(u => new ExportUserWithSoldProductsDto()
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Age = u.Age,
                        SoldProducts = new ExportUserSoldProductDto()
                        {
                            Count = u.ProductsSold.Count,
                            Products = u.ProductsSold
                            .OrderByDescending(p => p.Price)
                            .Select(p => new ExportSoldProductDto()
                            {
                                Name = p.Name,
                                Price = p.Price.ToString("f2")
                            })
                            .ToArray()
                        }
                    })
                    .OrderByDescending(u => u.SoldProducts.Count)
                    .Take(10)
                    .ToArray()
            };

            string result = XmlSerializerWrapper
                .Serialize(rootDto, "Users");
            return result;
        }

        private static void ResetAndSeedDatabase(ProductShopContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            string xmlFileText = ReadXmlDatasetFileContents("users.xml");
            string result = ImportUsers(dbContext, xmlFileText);

            xmlFileText = ReadXmlDatasetFileContents("products.xml");
            result = ImportProducts(dbContext, xmlFileText);

            xmlFileText = ReadXmlDatasetFileContents("categories.xml");
            result = ImportCategories(dbContext, xmlFileText);

            xmlFileText = ReadXmlDatasetFileContents("categories-products.xml");
            result = ImportCategoryProducts(dbContext, xmlFileText);

            Console.WriteLine(result);
        }

        private static string ReadXmlDatasetFileContents(string fileName)
        {
            string xmlFileDirPath = Path
                .Combine(Directory.GetCurrentDirectory(), "../../../Datasets/");
            string xmlFileText = File
                .ReadAllText(xmlFileDirPath + fileName);

            return xmlFileText;
        }

        private static bool IsValid(object obj)
        {
            ValidationContext validationContext = new ValidationContext(obj);
            ICollection<ValidationResult> validationResults
                = new List<ValidationResult>();

            return Validator
                .TryValidateObject(obj, validationContext, validationResults);
        }
    }
}