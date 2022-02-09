using System;
using System.Collections.Generic;
using System.Text;

namespace theater_database
{
    internal class Movie
    {
        private string title;

        public Movie(string aTitle)
        {
            title = aTitle;
        }

        public string GetTitle()
        {
            return title;
        }

        
    }
}
