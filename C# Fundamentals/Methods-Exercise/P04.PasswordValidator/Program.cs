using System;

namespace P04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (PasswordLength(password) == "true" && DigitsCount(password) == "true" &&
                LettersAndDigits(password) == "true")
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (PasswordLength(password) != "true")
                    Console.WriteLine(PasswordLength(password));

                if (LettersAndDigits(password) != "true")
                    Console.WriteLine(LettersAndDigits(password));

                if (DigitsCount(password) != "true")
                    Console.WriteLine(DigitsCount(password));                
            }
            
        }
        private static string PasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return "true";
            }
            else
            {
                return "Password must be between 6 and 10 characters";
            }
        }
        private static string DigitsCount(string password)
        {
            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digits++;
                }                
            }

            if (digits >= 2)
            {
                return "true";
            }
            else
            {
                return "Password must have at least 2 digits";
            }            
        }
        private static string LettersAndDigits(string password)
        {
            int lettersAndDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' &&
                    password[i] <= 'Z' || password[i] >= '0' && password[i] <= '9')
                {
                    lettersAndDigits++;
                }
            }

            if (password.Length == lettersAndDigits)
            {
                return "true";
            }
            else
            {
                return "Password must consist only of letters and digits";
            }
        }
    }
}
