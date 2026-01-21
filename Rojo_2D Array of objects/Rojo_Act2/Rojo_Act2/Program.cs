using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojo_Act2
{
    internal class Program
    {
        //Rojo Kazzy Rhys Z.
        //IT401A
        //Single Dimensional Array of Objects in OOP
        static void Main(string[] args) //Main program
        {
            TitleofMovies[,] movies = new TitleofMovies[2, 3]; // 2 rows, 3 columns (protagonists and directors)

            //Protagonist objects
            movies[0, 0] = new Protagonist("Harry Potter", "Fantasy", "Harry Potter");
            movies[0, 1] = new Protagonist("Marrowbone", "Horror/Mystery", "Jack Marrowbone");
            movies[0, 2] = new Protagonist("The Spiderwick Chronicles", "Family/Adventure", "Jared Grace");

            //Director objects
            movies[1, 0] = new Director("Enola Holmes", "Mystery/Adventure", "Harry Bradbeer");
            movies[1, 1] = new Director("Ready Player One", "Sci-fi/Action", "Steven Spielberg");
            movies[1, 2] = new Director("Interstellar", "Sci-fi/Adventure", "Christopher Nolan");

            //Loop through each row and column to display movie details
            for (int r = 0; r < movies.GetLength(0); r++) // Loop through rows
            {
                
                for (int c = 0; c < movies.GetLength(1); c++) // Loop through columns
                {
                    movies[r, c].Info(); // Call Info() method for each movie object
  
                }
            }
            Console.ReadLine();

            ////Create an array of TitleofMovies objects with a size of 6
            //TitleofMovies[] movies = new TitleofMovies[6];

            ////Add Protagonist objects to the array
            //movies[0] = new Protagonist("Harry Potter", "Fantasy", "Harry Potter");
            //movies[1] = new Protagonist("Marrowbone", "Horror/Mystery", "Jack Marrowbone");
            //movies[2] = new Protagonist("The Spiderwick Chronicles", "Family/Adventure", "Jared Grace");
            ////Add Director objects to the array
            //movies[3] = new Director("Enola Holmes", "Mystery/Adventure", "Harry Bradbeer");
            //movies[4] = new Director("Ready Player One", "Sci-fi/Action", "Steven Spielberg");
            //movies[5] = new Director("Interstellar", "Sci-fi/Adventure", "Christopher Nolan");

            ////Loop through each movie object in the array
            //foreach (TitleofMovies titleofMovies in movies)
            //{
            //    titleofMovies.Info();
            //}
            //Console.ReadLine();

        }

    }
}
