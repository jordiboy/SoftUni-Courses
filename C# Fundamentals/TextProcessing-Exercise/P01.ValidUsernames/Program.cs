using System;
using System.Linq;

namespace P01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in usernames)
            {
                bool isValid = true;

                if (item.Length >= 3 && item.Length <= 16)
                {
                    foreach (var character in item)
                    {
                        if (!char.IsLetterOrDigit(character))
                        {
                            isValid = false;                            
                        }
                        if (character == '-') isValid = true;
                        if (character == '_') isValid = true;
                    }
                    
                    if (isValid)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
