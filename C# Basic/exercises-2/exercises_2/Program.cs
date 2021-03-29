using System;

namespace exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercise#1
            double doubleVar1;
            double doubleVar2;
            doubleVar1 = 12.285;
            doubleVar2 = 3.085;
            double doubleDivision = doubleVar1 / doubleVar2;

            int intNum1 = 66;
            int intNum2 = 33;
            int intDivision = intNum1 / intNum2;

            Console.WriteLine("first divided number is " + doubleDivision);
            Console.WriteLine($"second divided number is {intDivision}");

            // exercise#2
            string name = "Aleksandar";
            string secondName = "Gacovski";
            string fullName = name + " " + secondName;

            string firstNumber = "9";
            string secondNumber = "3";
            string concatinate = firstNumber + secondNumber;

            Console.WriteLine(fullName);
            Console.WriteLine(concatinate);

            // exercise#3
            int newNumber = 323;
            string newString = "232";
            string newConcatination = newNumber + newString;
            Console.WriteLine("the new string is:" + newConcatination);

            // exercise#4
            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine(result + " messages can be sent");

            // exercise#5
            int branches = 12;
            int apples = 8;
            int baskets = 5;
            Console.WriteLine("please enter number of trees");
            string trees = Console.ReadLine();
            int outVar;
            int addResult;
            bool checkTrees = int.TryParse(trees, out outVar);
            if ((outVar % baskets == 0) && (checkTrees = true))
            {
                addResult = outVar * branches * apples / baskets;
            }
            else
            {
                addResult = outVar * branches * apples / baskets + 1;
            }

            Console.WriteLine(addResult + " baskets needed to collect the apples");

            // exercise#6
            Console.WriteLine("please enter first number");
            string lateVar1 = Console.ReadLine();
            int lateNumber1 = int.Parse(lateVar1);

            Console.WriteLine("please enter second number");
            string lateVar2 = Console.ReadLine();
            int lateNumber2 = int.Parse(lateVar2);

            if (lateNumber1 > lateNumber2)
            {
                Console.WriteLine("larger number of two is " + lateNumber1);
            }
            else if (lateNumber1 < lateNumber2)
            {
                Console.WriteLine("larger number of two is " + lateNumber2);
            }
            else
            {
                Console.WriteLine("the two numbers are equal");
            }

            if (lateNumber1 % 2 == 0)
            {
                Console.WriteLine("the number " + lateNumber1 + " is even");
            }
            else
            {
                Console.WriteLine("the number " + lateNumber1 + " is odd");
            }

            if (lateNumber2 % 2 == 0)
            {
                Console.WriteLine("the number " + lateNumber2 + " is even");
            }
            else
            {
                Console.WriteLine("the number " + lateNumber2 + " is odd");
            }

            // exercise#7
            Console.WriteLine("please enter number from 1 to 3");
            string addNumber = Console.ReadLine();

            switch (addNumber)
            {
                case "1":
                    Console.WriteLine("you've got a new car");
                    break;
                case "2":
                    Console.WriteLine("you've got a new plane");
                    break;
                case "3":
                    Console.WriteLine("you've got a new bike");
                    break;
                default:
                    Console.WriteLine("you haven't got any machine");
                    break;
            }


        }
    }
}
