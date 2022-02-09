using System;
using System.Collections.Generic;
using System.Text;

namespace theater_database
{
    internal class Movie
    {
        private string title;
        private int movieGenre;


        public enum genre
        {
            Action,
            Horror, 
            Comedy
        }

        public Movie(string aTitle, int aGenre)
        {
            title = aTitle;
            movieGenre = aGenre;
        }

        public string GetTitle()
        {
            return title;
        }

        
    }
}
