using System;
using System.Collections.Generic;
using Ex_3.Models.Data;

namespace Ex_3.Services
{
    public class MovieService
    {
        // public  MovieService()
        // {
        //     public IEnumerable<Movie> GetMovies();
        // }
        private readonly List<Movie> myMovies = new List<Movie>()
        {
            new Movie()
            {
                Id = 0,
                Name = "Bad Boys",
                Date = new DateTime(2020, 1, 13),
                Owner = "Someone"
            },
            new Movie()
            {
                Id = 1,
                Name = "Avengers",
                Date = new DateTime(2019, 5, 5),
                Owner = "Someone"
            },
            new Movie()
            {
                Id = 2,
                Name = "Joker",
                Date = new DateTime(2020, 10, 3),
                Owner = "Guillermo del Toro"
            }
        };


        public IEnumerable<Movie> GetMovies()
        {
            
            return myMovies;
        }
    }
}