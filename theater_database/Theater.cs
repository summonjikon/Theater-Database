using System;
using System.Collections.Generic;
using System.Text;

namespace theater_database
{
    internal class Theater
    {
        List<Movie> movieTitles;
        public Theater()
        {
            movieTitles = new List<Movie>();
        }

        public void AddMovie(Movie aMovieTitle)
        {
            movieTitles.Add(aMovieTitle);
        }

        public List<Movie> GetTitles()
        {
            return movieTitles;
        }
    }
}
