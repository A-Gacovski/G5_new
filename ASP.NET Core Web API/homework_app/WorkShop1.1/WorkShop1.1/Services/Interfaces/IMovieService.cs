using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Dto;
using WorkShop1._0.Models.Enums;

namespace WorkShop1._0.Services
{
    public interface IMovieService
    {
        string AddMovie(MovieDto movie);
        List<MovieDto> GetUserMovies(int userId);
        MovieDto GetMovieDetails(int movieId, int userId);
        string DeleteMovie(int movieId, int userId);
        string UpdateMovie(MovieDto movie);


        
    }
}
