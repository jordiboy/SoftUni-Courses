using System;

namespace P08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int ariveHour = int.Parse(Console.ReadLine());
            int ariveMinute = int.Parse(Console.ReadLine());

            int examInMinutes = (examHour * 60) + examMinute;
            int ariveInMinutes = (ariveHour * 60) + ariveMinute;
            int minuteDifference = examInMinutes - ariveInMinutes;

            if (minuteDifference >= 0 && minuteDifference <= 30)
            {
                
                if (minuteDifference > 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minuteDifference} minutes before the start");
                }
                else
                {
                    Console.WriteLine("On time");
                }
            }
            else if (minuteDifference > 30)
            {                
                if (minuteDifference > 59)
                {
                    int hours = minuteDifference / 60;
                    int minutes = minuteDifference % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minuteDifference} minutes before the start");
                }
            }
            else if (minuteDifference < 0)
            {
                minuteDifference = Math.Abs(minuteDifference);
                if (minuteDifference > 59)
                {
                    int hours = minuteDifference / 60;
                    int minutes = minuteDifference % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minuteDifference} minutes after the start");
                }
            }
        }
    }
}
