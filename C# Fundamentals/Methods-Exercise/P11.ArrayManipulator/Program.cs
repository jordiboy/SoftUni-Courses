using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.ArrayManipulator
{
    class Program
    {                        
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (true)
            {
                string[] tokens = new string[3];

                if (command != "end")
                {
                    tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
                else
                {
                    break;
                }

                if (tokens[0] == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index < myArray.Length && index > -1)
                    {
                        Exchange(myArray, index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");                        
                    }
                }
                else if (tokens[0] == "max")
                {
                    string maxOddOrEven = tokens[1];
                    Console.WriteLine(MaxOddEven(myArray, maxOddOrEven));
                }
                else if (tokens[0] == "min")
                {
                    string minOddOrEven = tokens[1];
                    Console.WriteLine(MinOddEven(myArray, minOddOrEven));
                }
                else if (tokens[0] == "first")
                {
                    int count = int.Parse(tokens[1]);

                    if (count <= myArray.Length)
                    {
                        string evenOrOdd = tokens[2];
                        Console.WriteLine($"[{FirstEvenOdd(myArray, count, evenOrOdd)}]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }                    
                }
                else if (tokens[0] == "last")
                {
                    int countLast = int.Parse(tokens[1]);

                    if (countLast <= myArray.Length)
                    {
                        string evenOrOdd = tokens[2];
                        Console.WriteLine($"[{LastEvenOdd(myArray, countLast, evenOrOdd)}]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", myArray)}]");

        }
        public static void Exchange(int[] myArray, int index)
        {
            int[] array1 = new int[index + 1];
            int[] array2 = new int[myArray.Length - index - 1];
            for (int i = 0; i <= index; i++)
            {
                array1[i] += myArray[i];
            }
            for (int i = index + 1; i < myArray.Length; i++)
            {
                array2[i - index - 1] += myArray[i];
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i < array2.Length)
                {
                    myArray[i] = array2[i];
                }
                else
                {
                    myArray[i] = array1[i - array2.Length];
                }
            }
        }
        public static string MaxOddEven(int[] myArray, string maxOdOrEven)
        {
            int maxEven = int.MinValue;
            int maxOdd = int.MinValue;
            int lastMaxEven = int.MinValue;
            int lastMaxOdd = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    if (myArray[i] >= lastMaxEven)
                    {
                        lastMaxEven = myArray[i];
                        maxEven = i;
                    }
                }
                else
                {
                    if (myArray[i] >= lastMaxOdd)
                    {
                        lastMaxOdd = myArray[i];
                        maxOdd = i;
                    }
                }
            }
            if (maxOdOrEven == "even" && maxEven != int.MinValue)
            {
                return maxEven.ToString();                

            }
            else if (maxOdOrEven == "odd" && maxOdd != int.MinValue)
            {
                return maxOdd.ToString();                
            }
            else
            {
                return "No matches";                
            }
        }
        public static string MinOddEven(int[] myArray, string minOddOrEven)
        {
            int minEven = int.MaxValue;
            int minOdd = int.MaxValue;
            int lastMinEven = int.MaxValue;
            int lastMinOdd = int.MaxValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    if (myArray[i] <= lastMinEven)
                    {
                        lastMinEven = myArray[i];
                        minEven = i;
                    }
                }
                else
                {
                    if (myArray[i] <= lastMinOdd)
                    {
                        lastMinOdd = myArray[i];
                        minOdd = i;
                    }
                }
            }
            if (minOddOrEven == "even" && minEven != int.MaxValue)
            {
                return minEven.ToString();                
            }
            else if (minOddOrEven == "odd" && minOdd != int.MaxValue)
            {
                return minOdd.ToString();                
            }
            else
            {
                return "No matches";                
            }
        }
        public static string FirstEvenOdd(int[] myArray, int count, string evenOrOdd)
        {            
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int counterEven = 0;
            int counterOdd = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0 && counterEven < count)
                {
                    even.Add(myArray[i]);
                    counterEven++;
                }
                else if (myArray[i] % 2 != 0 && counterOdd < count)
                {
                    odd.Add(myArray[i]);
                    counterOdd++;
                }
            }
            if (evenOrOdd == "even" && counterEven != 0)
            {                
                return string.Join(", ", even);                
            }
            else if (evenOrOdd == "odd" && counterOdd != 0)
            {
                return string.Join(", ", odd);                
            }
            else
            {
                return string.Empty;
            }
        }
        public static string LastEvenOdd(int[] myArray, int countLast, string evenOrOdd)
        {            
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int counterEven = 0;
            int counterOdd = 0;

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                if (myArray[i] % 2 == 0 && counterEven < countLast)
                {
                    even.Add(myArray[i]);
                    counterEven++;
                }
                else if (myArray[i] % 2 != 0 && counterOdd < countLast)
                {
                    odd.Add(myArray[i]);
                    counterOdd++;
                }
            }
            if (evenOrOdd == "even" && counterEven != 0)
            {
                even.Reverse();
                return string.Join(", ", even);                
            }
            else if (evenOrOdd == "odd" && counterOdd != 0)
            {
                odd.Reverse();
                return string.Join(", ", odd);                
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
