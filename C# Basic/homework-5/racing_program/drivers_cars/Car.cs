using System;
using System.Collections.Generic;
using System.Text;


namespace racing_program.drivers_cars


{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public int QualityDrive { get; set; }
       

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            QualityDrive = CalculateSpeed();
            
        }
        public Car()
        {
            QualityDrive = CalculateSpeed();
        }

        public int CalculateSpeed()
        {
            int QualityDrive = carListing[i].Speed * driverListing[i].Skill;
            return QualityDrive;
        }
    }
}
