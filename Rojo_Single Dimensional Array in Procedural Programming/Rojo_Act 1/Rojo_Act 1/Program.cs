using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojo_Act_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] titleOfmovies = new string[5];
            
            //To guide the user
            Console.WriteLine("ENTER THE TITLE OF MOVIES HERE:");
            Console.WriteLine("Input: ");


            //Loop method to store titles into the array
            for (int i = 0; i < titleOfmovies.Length; i++)
            {
                titleOfmovies[i] = Console.ReadLine();

                if (string.IsNullOrEmpty(titleOfmovies[i]))
                {
                    Console.WriteLine("Please enter a movie title");
                }
            }
            //To reverse the inputted titles
            Array.Reverse(titleOfmovies);
            //Display message
            Console.WriteLine("");
            Console.WriteLine("--HERE ARE THE TITLES YOU INPUTTED--");

            //Loop method to display the output
            foreach (string Movies in titleOfmovies)
            {
                if (!string.IsNullOrEmpty(Movies))
                {
                    Console.WriteLine(Movies);
                }
                else
                {
                    Console.WriteLine("Please enter a movie title");
                }
            }
            Console.ReadKey();
        }
    }
}
