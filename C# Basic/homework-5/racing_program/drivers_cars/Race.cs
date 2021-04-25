using System;
using System.Collections.Generic;
using System.Text;
using racing_program;

namespace racing_program.drivers_cars
{
    public class Race
    {
        public string DriverRacing { get; set; }
        public string CarRacing { get; set; }

        public Race(string driverRacing, string carRacing)
        {
            DriverRacing = driverRacing;
            CarRacing = carRacing;
        }
        
        public string RaceCars(Race race1, Race race2)
        {
            
            if (race1.QualityDrive > race2.QualityDrive)
            {
                string announcement = "Driver no.1 was faster";
                return announcement;
            }

            if (race1.QualityDrive < race2.QualityDrive)
            {
                string announcement = "Driver no.2 was faster";
                return announcement;
            }
            else
            {
                string announcement = "Drivers have Draw";
                return announcement;
            }
        }
    }
}
