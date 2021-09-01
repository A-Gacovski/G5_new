using homework_5.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework_5.Models
{
    public class NewOrderViewModel
    {

        [Display (Name = "First Name:   ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:   ")]
        public string LastName { get; set; }

        [Display(Name = "Pizza:   ")]
        public string Pizza { get; set; }

        [Display(Name = "Size:   ")]
        public Size Size { get; set; }


    }
}
