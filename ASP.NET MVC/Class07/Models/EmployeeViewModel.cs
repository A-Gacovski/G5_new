using Class07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class07.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public Position Position { get; set; }
    }
}
