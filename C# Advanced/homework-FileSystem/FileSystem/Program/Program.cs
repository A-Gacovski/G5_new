using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string exerPath = @"..\..\..\";
            string folderPath = exerPath + @"Exercise\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Directory Exercise is created");
            }
            string filePath = folderPath + "Calculation.txt";
            static string Calculate(int num1, int num2)
            {
                int sum = num1 + num2;
                string result = $"{num1} + {num2} = {sum}";
                return result;
            }
            Console.WriteLine("Enter Number of times you want to write to txt file:");
            string n1 = Console.ReadLine();
            int n = int.Parse(n1);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Please enter first number");
                string num1str = Console.ReadLine();
                int num1 = int.Parse(num1str);

                Console.WriteLine("Please enter second number");
                
                string num2str = Console.ReadLine();
                int num2 = int.Parse(num2str);

                var result = Calculate(num1, num2);
                Console.WriteLine(result);

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{Calculate(num1, num2)} {DateTime.Now}");
                }
            }
        }
    }
}
