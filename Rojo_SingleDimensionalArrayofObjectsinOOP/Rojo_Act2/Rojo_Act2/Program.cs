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
            //Create an array of TitleofMovies objects with a size of 6
            TitleofMovies[] movies = new TitleofMovies[6];

            //Add Protagonist objects to the array
            movies[0] = new Protagonist("Harry Potter", "Fantasy", "Harry Potter");
            movies[1] = new Protagonist("Marrowbone", "Horror/Mystery", "Jack Marrowbone");
            movies[2] = new Protagonist("The Spiderwick Chronicles", "Family/Adventure", "Jared Grace");
            //Add Director objects to the array
            movies[3] = new Director("Enola Holmes", "Mystery/Adventure", "Harry Bradbeer");
            movies[4] = new Director("Ready Player One", "Sci-fi/Action", "Steven Spielberg");
            movies[5] = new Director("Interstellar", "Sci-fi/Adventure", "Christopher Nolan");

            //Loop through each movie object in the array
            foreach (TitleofMovies titleofMovies in movies)
            {
                titleofMovies.Info();
            }
            Console.ReadLine();

        }

    }
}
