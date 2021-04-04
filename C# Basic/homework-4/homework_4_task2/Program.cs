using System;

namespace homework_4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert minutes");
            string stringMin = Console.ReadLine();
            int min = int.Parse(stringMin);

            int convertToSeconds = ConvertToSec(min);

            Console.WriteLine($"We calculated {convertToSeconds} sec.");
        }
        public static int ConvertToSec(int min)
        {
            int secInMin = 60;
            int calculateSeconds = min * secInMin;
            return calculateSeconds;
        }
    }
}
