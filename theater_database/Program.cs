using System;

namespace theater_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int genre;
            string filmKeuze;

            Theater rooster = new Theater();

            Movie PulpFiction = new Movie("Pulp Fiction", Movie.genres.Action);
            Movie Snatch = new Movie("The Grudge", Movie.genres.Horror);

            rooster.addMovie(PulpFiction);
            rooster.addMovie(Snatch);

            Console.WriteLine("Welkom,\nKies uit een film categorie door een cijfer in te vullen\n \n1. Actie \n2. Horror \n3. Sci-Fi ");
            genre = Convert.ToInt32(Console.ReadLine());


            if (genre == 1)
            {
                Console.Clear();
                foreach (Movie a in rooster.GetTitles())
                {
                    Console.WriteLine(a.GetTitle());
                }
            }
            else if (genre == 2)
            {
                Console.Clear();
                foreach (Movie a in rooster.GetTitles())
                {
                    Console.WriteLine(a.GetTitle());
                }
            }
            else if (genre == 3)
            {
                Console.Clear();
                foreach (Movie a in rooster.GetTitles())
                {
                    Console.WriteLine(a.GetTitle());
                }
            }
            else
            {
                Console.WriteLine("\nGeen geldig antwoord");
            }


            Console.WriteLine("\nSelecteer een film door een title in te typen");
            filmKeuze = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(filmKeuze + " is helaas uitverkocht!");




        }
    }
}
