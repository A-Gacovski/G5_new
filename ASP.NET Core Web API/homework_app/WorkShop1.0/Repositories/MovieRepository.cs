using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Data;
using WorkShop1._0.Models.Enums;

namespace WorkShop1._0.Repositories.IRepository
{
    public class MovieRepository : IRepository<Movie>
    {
        
        public void Add(Movie entity)
        {
            CashDb.MovieIdCounter++;
            entity.Id = CashDb.MovieIdCounter;
            CashDb.Movies.Add(entity);
        }

        public void Delete(Movie entity)
        {
            var movie = CashDb.Movies.FirstOrDefault(m => m.Id == entity.Id);
            if (movie != null)
            {
                CashDb.Movies.Remove(movie);
            }
        }

        public List<Movie> GetAll()
        {
            return CashDb.Movies;
        }

        public void Update(Movie entity)
        {
            var movieUpdate = CashDb.Movies.FirstOrDefault(m => m.Id == entity.Id);
            if (movieUpdate != null)
            {
                var movieIndex = CashDb.Movies.IndexOf(movieUpdate);
                CashDb.Movies[movieIndex] = entity;
            }
        }
    }
}
