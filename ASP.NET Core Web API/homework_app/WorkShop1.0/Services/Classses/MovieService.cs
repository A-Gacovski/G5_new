using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Dto;
using WorkShop1._0.Models.Enums;
using WorkShop1._0.Models.Mappers;
using WorkShop1._0.Repositories.IRepository;

namespace WorkShop1._0.Services.Classses
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public string AddMovie(MovieDto movie)
        {
            if (string.IsNullOrEmpty(movie.Title))
            {
                throw new Exception("Movie title is empty");
            }
            if (string.IsNullOrEmpty(movie.Description))
            {
                throw new Exception("No movie description");
            }
            var newMovie = MovieMapper.DtoToModel(movie);
            _movieRepository.Add(newMovie);

            return "a new movie is succsessfully added";
        }

        public MovieDto GetMovieDetails(int movieId, int userId)
        {
            var movieDetails = _movieRepository.GetAll().FirstOrDefault(m => m.Id == movieId && m.UserId == userId);
            if (movieDetails == null)
            {
                throw new Exception("Movie can not be found");
            }
            return MovieMapper.ModelToDto(movieDetails);
        }

        public List<MovieDto> GetUserMovies(int userId)
        {
            if (userId < 1)
            {
                throw new Exception("userId is not valid");
            }
            return _movieRepository.GetAll().Where(m => m.UserId == userId)
                                            .Select(movie => MovieMapper.ModelToDto(movie)).ToList();
        }

        public string DeleteMovie(int movieId, int userId)
        {
            var deletingMovie = _movieRepository.GetAll().FirstOrDefault(m => m.Id == movieId && m.UserId == userId);
            if (deletingMovie == null)
            {
                throw new Exception("Movie can not be found");
            }
            _movieRepository.Delete(deletingMovie);
            return "The movie has been deleted";
        }

        public string UpdateMovie(MovieDto movie)
        {
            if (movie == null)
            {
                throw new Exception("Movie can not be found");
            }
            var updateMovie = _movieRepository.GetAll().FirstOrDefault(x => x.Id == movie.Id && x.UserId == movie.UserId);

            if (!string.IsNullOrEmpty(movie.Title))
            {
                updateMovie.Title = movie.Title;
            }
            if (!string.IsNullOrEmpty(movie.Description))
            {
                updateMovie.Description = movie.Description;
            }
            if (movie.Genre != null)
            {
                updateMovie.Genre = movie.Genre;
            }
            _movieRepository.Update(updateMovie);

            return "Movie data has been changed";
        }
    }
}
