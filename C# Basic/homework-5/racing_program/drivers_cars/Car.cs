using System;
using System.Collections.Generic;
using System.Text;
using racing_program;


namespace racing_program.drivers_cars


{
    public class Car
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
            int QualityDrive = Speed * GetSkill();
            return QualityDrive;
        }

        private static int GetSkill()
        {
            return Driver.Skill;
        }
    }
}
