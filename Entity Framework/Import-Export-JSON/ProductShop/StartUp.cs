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

            string jsonString = File.ReadAllText("../../../Datasets/users.json");
            string result = ImportUsers(db, jsonString);

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

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

          
            return isValid;
        }
    }
}