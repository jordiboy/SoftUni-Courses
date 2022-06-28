using System;

namespace P10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;
            int counter = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headset++;
                }
                if (i % 3 == 0)
                {
                    mouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboard++;
                    counter++;
                }
                if (counter % 2 == 0 && counter > 0)
                {
                    display++;
                    counter = 0;
                }
            }

            double total = (headset * headsetPrice) + (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
