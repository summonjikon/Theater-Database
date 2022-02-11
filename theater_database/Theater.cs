using System;
using System.Collections.Generic;
using System.Text;

namespace theater_database
{
    internal class Theater
    {
        List<Movie> movie;

        public Movie[] GetMoviesByType(Movie.genres genre)

        {

            List<Movie> filteredMovies = new List<Movie>()



            ???



            return filteredMovies.ToArray()

}
        public Theater()
        {
            movie = new List<Movie>();
        }

        public void addMovie(Movie aMovie)
        {
            movie.Add(aMovie);
        }

        public List<Movie> GetTitles()
        {
            return movie;
        }
    }
}
