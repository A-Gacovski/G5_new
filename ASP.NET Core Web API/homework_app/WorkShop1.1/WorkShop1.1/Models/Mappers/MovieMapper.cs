using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Dto;

namespace WorkShop1._0.Models.Mappers
{
    public class MovieMapper
    {
        public static MovieDto ModelToDto(Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                NewDate = movie.NewDate,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
        }
        public static Movie DtoToModel(MovieDto movie)
        {
            return new Movie
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                NewDate = movie.NewDate,
                Genre = movie.Genre,
                UserId = movie.UserId
            };
        }
    }
}
