using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojo_Two_Dimensional_Array
{
    internal class Program
    {  //Rojo, Kazzy Rhys Z.
        //IT401A
        //Two-Dimensional Array
        static void Main(string[] args)
        {
            Console.WriteLine("        Column1     Column2");
            // Declare and initialize a two-dimensional string array with 3 rows and 2 columns
            string[,] input = new string[3, 2]
            {
                {"Name", "Course"},
                {"Kazzy", "BSIT"},
                {"Rassed", "BSIT" }
            };
            // Loop through each row of the array
            for (int r = 0; r < 3; r++)
            {
                Console.Write("Row " + r + "\t");
                // Loop through each column of the current row
                for (int c = 0; c < 2; c++)
                {
                    // Print the current element
                    Console.Write(input[r, c] + "        ");
                }
                // Move to the next line after printing one row
                Console.WriteLine();
            }
            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
        
    }
}
