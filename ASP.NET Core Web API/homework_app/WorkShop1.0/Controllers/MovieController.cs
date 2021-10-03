using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Dto;
using WorkShop1._0.Services;

namespace WorkShop1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Route("getallmovies/{userId}")]
        public ActionResult <List<MovieDto>> GetAllMovies([FromRoute] int userId)
        {
            try
            {
                var response = _movieService.GetUserMovies(userId);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getmoviedetails/{movieId}/{userId}")]
        public ActionResult MovieDto ([FromRoute]int movieId, [FromRoute]int userId)
        {
            try
            {
                var response = _movieService.GetMovieDetails(movieId, userId);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addmovie")]
        public ActionResult<string> AddMovie([FromBody] MovieDto movie)
        {
            try
            {
                var response = _movieService.AddMovie(movie);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("deletemovie/{movieId}/{userId}")]
        public ActionResult<string> DeleteMovie([FromRoute]int movieId, [FromRoute]int userId)
        {
            try
            {
                var response = _movieService.DeleteMovie(movieId, userId);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("updatemovie")]
        public ActionResult<string> UpdateMovie([FromBody] MovieDto movie)
        {
            try
            {
                var response = _movieService.UpdateMovie(movie);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
