using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Models
{
    public class EmployeeDetailsViewModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullEmployeeName { get; set; }
        public Position Position { get; set; }
        public string ToBePositioned { get; set; }
        public DateTime DateOfHire { get; set; }
        public double Salary { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
    }
}
