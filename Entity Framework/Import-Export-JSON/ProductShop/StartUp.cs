using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProductShop
{
    

    public class StartUp
    {
        public static void Main()
        {
            using var db = new ProductShopContext();
            db.Database.Migrate();

            //Console.WriteLine("Migration Compleated");

            //string jsonString = File.ReadAllText("../../../Datasets/categories-products.json");
            //string result = ImportCategoryProducts(db, jsonString);

            string result = GetCategoriesByProductsCount(db);
            Console.WriteLine(result);
        }

        //Problem 1

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {

            string result = string.Empty;

            ImportUsersDto[]? userDtos = JsonConvert.DeserializeObject<ImportUsersDto[]>(inputJson);
            if (userDtos != null)
            {                
                ICollection<User> usersToAdd = new List<User>();

                foreach (var userDto in userDtos)
                {
                    if (!IsValid(userDto))
                    {
                        continue;
                    }

                    int? userAge = null;
                    if (userDto.Age != null)
                    {
                        int parsedAge = 0;

                        bool isAgeValid = int.TryParse(userDto.Age, out parsedAge);

                        if (!isAgeValid)
                        {
                            continue;
                        }

                        userAge = parsedAge;
                    }

                    User user = new User()
                    {
                        FirstName = userDto.FirstName,
                        LastName = userDto.LastName,
                        Age = userAge,
                    };

                    usersToAdd.Add(user);
                }

                context.Users.AddRange(usersToAdd);
                context.SaveChanges();

                result = $"Successfully imported {usersToAdd.Count}";               
            }

            return result;
        }

        //Problem 2

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            string result = string.Empty;

            ImportProductDto[]? productDtos = JsonConvert.DeserializeObject<ImportProductDto[]>(inputJson);
            if (productDtos != null)
            {
                ICollection<Product> validProducts = new List<Product>();
                foreach (var productDto in productDtos)
                {
                    if (!IsValid(productDto))
                    {
                        continue;
                    }

                    bool isPriseValid = decimal.TryParse(productDto.Price, out decimal productPrice);
                    bool isSellerValid = int.TryParse(productDto.SellerId, out int sellerId);

                    if (!isPriseValid || !isSellerValid)
                    {
                        continue;
                    }

                    int? buyerId = null;
                    if (productDto.BuyerId != null)
                    {
                        bool isBuyerIdValid = int.TryParse(productDto.BuyerId, out int parsedBuyerId);
                        if (!isBuyerIdValid)
                        {
                            continue;
                        }

                        buyerId = parsedBuyerId;
                    }

                    Product product = new Product()
                    {
                        Name = productDto.Name,
                        Price = productPrice,
                        SellerId = sellerId,
                        BuyerId = buyerId
                    };

                    validProducts.Add(product);
                }

                context.Products.AddRange(validProducts);
                context.SaveChanges();

                result = $"Successfully imported {validProducts.Count}";
            }

            return result;
        }

        // Problem 3

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            string result = string.Empty;

            ImportCategoryDto[]? categoryDtos = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);
            if (categoryDtos != null)
            {
                ICollection<Category> validCategories = new List<Category>();

                foreach (var categoryDto in categoryDtos)
                {
                    if (!IsValid(categoryDto))
                    {
                        continue;
                    }

                    Category category = new Category()
                    {
                        Name = categoryDto.Name!
                    };

                    validCategories.Add(category);
                }
                context.Categories.AddRange(validCategories);
                context.SaveChanges();

                result = $"Successfully imported {validCategories.Count}";
            }

            return result;
        }

        // Problem 4

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            string result = string.Empty;            

            ImportCategorytProductDto[]? categorieProductDtos = JsonConvert
                .DeserializeObject<ImportCategorytProductDto[]>(inputJson);
            if (categorieProductDtos != null)
            {
                ICollection<CategoryProduct> validCategoriesProducts = new List<CategoryProduct>();

                ICollection<int> existingProducts = context.Products
                    .AsNoTracking()
                    .Select(p => p.Id)
                    .ToArray();

                foreach (var dto in categorieProductDtos)
                {
                    if (!IsValid(dto))
                    {
                        continue;
                    }
                    
                    bool isCategoryIdValid = int.TryParse(dto.CategoryId, out int validCategoryId);
                    bool isProductIdValid = int.TryParse(dto.ProductId, out int validProductId);                    
                    
                    if (!isCategoryIdValid || !isProductIdValid || !existingProducts.Contains(validProductId))
                    {
                        continue;
                    }

                    CategoryProduct categoryProduct = new CategoryProduct()
                    {
                        CategoryId = validCategoryId,
                        ProductId = validProductId
                    };

                    validCategoriesProducts.Add(categoryProduct);
                }

                context.AddRange(validCategoriesProducts);
                context.SaveChanges();

                result = $"Successfully imported {validCategoriesProducts.Count}";
            }

            return result;
        }

        // Problem 5 

        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsInRange = context.Products
                .Where(p => p.Price >= 500 &&  p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .ToArray();

            string jsonResult = JsonConvert.SerializeObject(productsInRange, Formatting.Indented);

            return jsonResult;
        }

        // Problem 6

        public static string GetSoldProducts(ProductShopContext context)
        {

            var soldProducts = context.Users
                .Where(u => u.ProductsSold.Count > 0)                
                .OrderBy (u => u.LastName)
                .ThenBy (u => u.FirstName)                
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                        .Select(p => new 
                        { 
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName
                        })
                        .ToArray()
                })                
                .ToArray().Distinct();

            string jsonResult = JsonConvert.SerializeObject (soldProducts, Formatting.Indented);

            return jsonResult;
        }

        // Problem 7

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Where(c => c.CategoriesProducts.Count > 0)
                .OrderByDescending(c => c.CategoriesProducts.Count())
                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCountcategories = c.CategoriesProducts.Count,
                    AveragePrice = c.CategoriesProducts
                        .Sum(cp => cp.Product.Price) / c.CategoriesProducts.Count,
                    TotalRevenue = c.CategoriesProducts
                        .Sum(cp => cp.Product.Price)
                })
                .ToArray();

            var categoriesDto = categories
                .Select(c => new 
                {
                    category = c.Category,
                    productsCount = c.ProductsCountcategories,
                    averagePrice = c.AveragePrice.ToString("f2"),
                    totalRevenue = c.TotalRevenue.ToString("f2"),
                })
                .ToArray();

            string jsonResult = JsonConvert.SerializeObject(categoriesDto, Formatting.Indented);

            return jsonResult;
        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

          
            return isValid;
        }

        
    }
}