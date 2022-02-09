using System;
using System.Collections.Generic;
using System.Text;

namespace theater_database
{
    internal class Movie
    {

        private string title;
        public genres movieGenre;
        public enum genres
        {
            Action,
            Horror
        }

        public Movie(string aTitle, genres genre)
        {
            title = aTitle;
            movieGenre = genre;
         }

        public string GetTitle()
        {
            return title;
        }

        
    }
}
