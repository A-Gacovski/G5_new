using System;
using System.Collections.Generic;
using System.Text;
using racing_program;

namespace racing_program.drivers_cars
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
       

        
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        
    }
}
