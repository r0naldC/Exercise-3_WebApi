using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ex_3.Models.Data;

using Ex_3.Services;

namespace Ex_3.Controllers
{
    public class MoviesController : ApiController
    {
        private readonly MovieService _movie = new MovieService();

        
        [HttpGet]
        [Route("api/movies")]
        public IEnumerable<Movie> Get()
        {
            var movies = _movie.GetMovies();

            return movies;
        }
    }
}
