using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Models
{
    public class EmployeeDetailsModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Position Position { get; set; }
        public DateTime DateOfHire { get; set; }
        public double Salary { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }

        public string PositionFunc()
        {
            Enum positionEnum = Position.Senior;
            string position = positionEnum.ToString();
            return position;
        }

    }
}
