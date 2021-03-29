using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // homework-2_exercise_1
            Console.WriteLine("please enter first number");
            string newInput1 = Console.ReadLine();
            double newNumber1 = double.Parse(newInput1);

            Console.WriteLine("please enter second number");
            string newInput2 = Console.ReadLine();
            double newNumber2 = double.Parse(newInput2);

            Console.WriteLine("please enter operation to calculate");
            string operInput = Console.ReadLine();


            switch (operInput)
            {
                case "+":
                    Console.WriteLine($"The result is {newNumber1 + newNumber2}");
                    break;
                case "-":
                    Console.WriteLine($"The result is {newNumber1 - newNumber2}");
                    break;
                case "*":
                    Console.WriteLine($"The result is {newNumber1 * newNumber2}");
                    break;
                case "/":
                    Console.WriteLine($"The result is {newNumber1 / newNumber2}");
                    break;
                default:
                    Console.WriteLine("sorry there is no such operation");
                    break;
            }

            // homework-2_exercise_2
            Console.WriteLine("please enter No.1");
            string addInput1 = Console.ReadLine();
            double addNumber1 = int.Parse(addInput1);

            Console.WriteLine("please enter No.2");
            string addInput2 = Console.ReadLine();
            double addNumber2 = int.Parse(addInput2);

            Console.WriteLine("please enter No.3");
            string addInput3 = Console.ReadLine();
            double addNumber3 = int.Parse(addInput3);

            Console.WriteLine("please enter No.4");
            string addInput4 = Console.ReadLine();
            double addNumber4 = int.Parse(addInput4);

            double addResult = (addNumber1 + addNumber2 + addNumber3 + addNumber4) / 4;
            Console.WriteLine($"The average of {addNumber1}, {addNumber2}, {addNumber3} and {addNumber4} is: {addResult}");

            // homework-2_exercise_3
            Console.WriteLine("please input the first number");
            string lateInput1 = Console.ReadLine();
            int lateNumber1 = int.Parse(lateInput1);

            Console.WriteLine("please input the second number");
            string lateInput2 = Console.ReadLine();
            int lateNumber2 = int.Parse(lateInput2);

            int firstVarToSec = lateNumber2;
            int secondVarToFirst = lateNumber1;

            lateNumber1 = firstVarToSec;
            lateNumber2 = secondVarToFirst;

            Console.WriteLine("first number: " + lateNumber1);
            Console.WriteLine("second number: " + lateNumber2);



        }
    }
}
