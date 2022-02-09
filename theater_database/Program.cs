using System;

namespace theater_database
{
    internal class Program
    {
        int actionMovies = 1;
        static void Main(string[] args)
        {

            Theater rooster = new Theater();

            Movie PulpFiction = new Movie("Pulp Fiction");
            Movie Snatch = new Movie("Snatch");

            rooster.addMovie(PulpFiction);
            rooster.addMovie(Snatch);


            foreach (Movie a in rooster.GetTitles())
            {
                Console.WriteLine(a.GetTitle());
            }



            foreach (string genres in Enum.GetNames(typeof(Movie.genre)))
            {
                Console.WriteLine(genres);

            }




            /* Console.WriteLine("Welkom,\nKies uit een film categorie door een cijfer in te vullen\n \n1. Actie \n2. Horror \n3. Sci-Fi ");
                 genre = Convert.ToInt32(Console.ReadLine());


                 if(genre == 1)
                 {
                     Console.Clear();
                     foreach (Movie a in actieFilm.GetTitles())
                     {
                         Console.WriteLine(a.GetTitle());
                     }
                 }
                 else if (genre == 2)
                 {
                     Console.Clear();
                     foreach (Movie a in horrorFilm.GetTitles())
                     {
                         Console.WriteLine(a.GetTitle());
                     }
                 }
                 else if (genre == 3)
                 {
                     Console.Clear();
                     foreach (Movie a in scifiFilm.GetTitles())
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
                 Console.WriteLine(filmKeuze + " Is helaas uitverkocht!");*/




        }
    }
}
