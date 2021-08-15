using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public Position Position { get; set; }
        public double Salary { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Employee()
        {
            EmployeeId = 11;
            FirstName = "Aleksanar";
            LastName = "Gacovski";
            DateOfHire = new DateTime(2009, 05, 18);
            Salary = 2000.00;
        }
    }
}
