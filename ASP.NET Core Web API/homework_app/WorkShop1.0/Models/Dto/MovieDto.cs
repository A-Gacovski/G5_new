using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Enums;

namespace WorkShop1._0.Models.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime NewDate { get; set; }
        public Genre? Genre { get; set; }
        public int UserId { get; set; }

    }
}
