using System;

namespace P05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length -1; i > -1; i--)
            {
                password += username[i];
            }

            int counter = 0;
            string pass = Console.ReadLine();

            while (true)
            {
                counter++;

                if (password != pass)
                {
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }                    
                }
                else if (password == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }                

                pass = Console.ReadLine();
            }
            
        }
    }
}
