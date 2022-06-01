using System;

namespace P06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double water = 20;
            double internet = 15;
            double electricity = 0;
            double others = 0;


            for (int i = 1; i <= months; i++)
            {
                double electricityForMonth = double.Parse(Console.ReadLine());

                electricity += electricityForMonth;
                double all = electricityForMonth + water + internet;
                double othersPercent = all * 0.2;
                others += all + othersPercent;
            }

            water *= months;
            internet *= months;

            double avg = (water + internet + electricity + others) / months;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {avg:f2} lv");
        }
    }
}
