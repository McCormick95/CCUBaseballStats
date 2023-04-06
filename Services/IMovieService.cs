using System.Collections.Generic;
using MovieApi.Models;

namespace MovieApi.Services{
    public interface IMovieService{
        public IEnumerable<Movie> GetMovies();

        public Movie getMovieByName(string name);

        public Movie GetMovieByYear(int year);

        public void CreateMovie(Movie m);

        public void UpdateMovie(string name, Movie m);

        public void DeleteMovie(string name);

    }
}