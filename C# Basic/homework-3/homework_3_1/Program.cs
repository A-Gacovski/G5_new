using System;

namespace homework_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[6];
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Enter integer no." + (i + 1));
                string num = Console.ReadLine();
                numArray[i] = int.Parse(num);
                if (numArray[i] % 2 == 0)
                {
                    sum += numArray[i];

                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The result is: " + sum);
        }
    }
}
