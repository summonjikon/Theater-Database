using System;

namespace theater_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int genre;
            string filmKeuze;

            Theater actieFilm = new Theater();
            Theater horrorFilm = new Theater();
            Theater scifiFilm = new Theater();


            Movie A1 = new Movie("Pulp Fiction");
            Movie A2 = new Movie("Snatch");

            Movie H1 = new Movie("The Grudge");
            Movie H2 = new Movie("The Ring");

            Movie C1 = new Movie("2001: A Space Odyssey");
            Movie C2 = new Movie("Interstellar");

            horrorFilm.AddMovie(H1);
            horrorFilm.AddMovie(H2);

            actieFilm.AddMovie(A1);
            actieFilm.AddMovie(A2);

            scifiFilm.AddMovie(C1);
            scifiFilm.AddMovie(C2);




            Console.WriteLine("Welkom,\nKies uit een film categorie door een cijfer in te vullen\n \n1. Actie \n2. Horror \n3. Sci-Fi ");
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
            Console.WriteLine(filmKeuze + " Is helaas uitverkocht!");

            


        }
    }
}
