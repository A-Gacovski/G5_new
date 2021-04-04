using System;

namespace homework_4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert your age ");
            string stringYears = Console.ReadLine();
            int age = int.Parse(stringYears);

            int ageInDays = CalculateAge(age);

            Console.WriteLine($"Your age in days is {ageInDays}");
        }

        public static int CalculateAge(int age)
        {
            int daysInYear = 365;
            int calculateDays = age * daysInYear;
            return calculateDays;
        }
    }
}
