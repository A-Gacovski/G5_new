using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User()
        {
            FirstName = "Aleksandar";
            LastName = "Gacovski";
            Age = 43;
        }
    }
}
