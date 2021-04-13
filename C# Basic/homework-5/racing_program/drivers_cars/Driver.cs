using System;
using System.Collections.Generic;
using System.Text;

namespace racing_program.drivers_cars
{
    class Driver
    {
        public string Racer { get; set; }
        public int Skill { get; set; }

        public Driver(string racer, int skill)
        {
            Racer = racer;
            Skill = skill;
        }


    }
}
