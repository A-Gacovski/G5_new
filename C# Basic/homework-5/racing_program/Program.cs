using racing_program.drivers_cars;
using System;

namespace racing_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver hamilton = new Driver("Hamilton", 5);
            Driver verstappen = new Driver("Verstappen", 4);
            Driver norris = new Driver("Norris", 3);
            Driver leclerc = new Driver("Lecrerc", 4);

            Car mercedes = new Car("Mercedes", 250);
            Car redbull = new Car("RedbullRacing", 225);
            Car mclaren = new Car("Mclaren", 230);
            Car ferrari = new Car("Ferrari", 245);

            Driver[] driversListing = new Driver[4];
            driversListing[0] = hamilton;
            driversListing[1] = verstappen;
            driversListing[2] = norris;
            driversListing[3] = leclerc;

            Car[] carsListing = new Car[4];
            carsListing[0] = mercedes;
            carsListing[1] = redbull;
            carsListing[2] = mclaren;
            carsListing[3] = ferrari;

            string [] driverRacing = new string[2];
            string[] carRacing = new string[2];

            for (int i = 0; i < driverRacing.Length; i++)
            {
                Console.WriteLine($"Please choose Car no.{i + 1}:");
                foreach (var car in carsListing)
                {
                    Console.WriteLine(car);
                }
                Console.Write("enter: ");
                carRacing[i] = Console.ReadLine();
                

                Console.WriteLine($"Please choose Driver for Car no.{i + 1}:");
                foreach (var driver in driversListing)
                {
                    Console.WriteLine(driver);
                }
                Console.Write("enter: ");
                driverRacing[i] = Console.ReadLine();
            }

            Race race1 = new Race(driverRacing[0], carRacing[0]);
            Race race2 = new Race(driverRacing[1], carRacing[1]);
            GetSkill();
            Console.WriteLine(RaceCars(race1, race2));

        }
    } 
}
