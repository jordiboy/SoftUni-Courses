using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System.ComponentModel.DataAnnotations;

namespace ProductShop
{
    

    public class StartUp
    {
        public static void Main()
        {
            using var db = new ProductShopContext();
            db.Database.Migrate();

            //Console.WriteLine("Migration Compleated");

            string jsonString = File.ReadAllText("../../../Datasets/categories.json");
            string result = ImportCategories(db, jsonString);

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

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

          
            return isValid;
        }
    }
}