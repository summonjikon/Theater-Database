using System;

namespace theater_database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Theater rooster = new Theater();

            Movie PulpFiction = new Movie("Pulp Fiction", Movie.genres.Action);
            Movie Snatch = new Movie("The Grudge", Movie.genres.Horror);

            rooster.addMovie(PulpFiction);
            rooster.addMovie(Snatch);


            foreach (Movie a in rooster.GetTitles())
            {
                Console.WriteLine(a.GetTitle());
            }

        }
    }
}
