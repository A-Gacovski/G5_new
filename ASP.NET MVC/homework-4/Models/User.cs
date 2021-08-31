using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_3.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public long Phone { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
