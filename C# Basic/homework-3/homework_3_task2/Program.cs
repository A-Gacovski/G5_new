using System;

namespace homework_3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arrStudents1 = new string[] {"Zdravko", "Petar", "Stojan", "Branka", "Trajce"};
            string [] arrStudents2 = new string[] { "Ivan", "Anja", "Robert", "Slavko", "Nikola" };

            Console.Write("Enter students group ");
            string numString = Console.ReadLine();
            bool numOfGroup = int.TryParse(numString, out int number);
            if(number == 1 && numOfGroup == true)
            {
                Console.WriteLine("The students in Array 1 are:");
                foreach (var arr in arrStudents1)
                {
                    Console.WriteLine(arr);
                }
            }
            else if(number == 2 && numOfGroup == true)
            {
                Console.WriteLine("The Students in Array 2 are:");
                foreach (var arr in arrStudents2)
                {
                    Console.WriteLine(arr);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
            
        }
    }
}
