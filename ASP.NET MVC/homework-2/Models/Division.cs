using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Models
{
    public class Division
    {
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public Employee HeadOfDivision { get; set; }

        public Division()
        {
            DivisionId = 21;
            Name = "Ohrid";
        }
    }
}
