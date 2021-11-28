using System;

namespace theater_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Theater theTheater = new Theater();

            Movie firstMovie = new Movie("Pulp Fiction");
            Movie secondMovie = new Movie("Snatch");

            theTheater.AddMovie(firstMovie);
            theTheater.AddMovie(secondMovie);

            foreach(Movie a in theTheater.GetTitles())
            {
                Console.WriteLine(a.GetTitle());
            }
        }
    }
}
