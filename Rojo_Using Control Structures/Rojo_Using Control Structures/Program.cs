using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojo_Using_Control_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n1;
            string choice;

            while (true)
            {
                Console.WriteLine("This program will determine what type of number and display its range.");
                Console.Write("\nPlease enter a number: ");
                string enter = Console.ReadLine();

                int i = 0;
                bool num = true;

                while (i < enter.Length) // check each character
                {
                    if (enter[i] < '0' || enter[i] > '9')
                    {
                        num = false;
                    }
                    i++;
                }
                if (string.IsNullOrEmpty(enter)) // check if input is empty
                {
                    num = false;
                }
                if (!num)
                {
                    Console.WriteLine("Please re-try to enter a numeric value.");
                    Console.Write("\n\nDo you want to try again (y/n)? ");
                    choice = Console.ReadLine();
                    if (choice == "y") // for retry
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (choice == "n") // for exit
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for using this program.");
                        Console.ReadKey();
                        return;
                    }
                    continue;
                }

                n = Convert.ToInt32(enter);
                n1 = n % 2;

                if (n1 == 0)
                {
                    Console.Write(n + "is an even number.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("This is the range of numbers based from the number entered.");
                    while (n > 0)
                    {
                        Console.Write(n + " ");
                        n = n - 2;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Do you want to try again (y/n)? ");
                    enter = Console.ReadLine();
                    if (enter == "y")
                    {
                        Console.Clear();
                    }
                    else if (enter == "n") // for exit
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for using this program");
                        Console.ReadKey();
                        return;
                    }
                }
                else if (n1 == 1) // for odd number
                {
                    Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number you entered.");
                    Console.Write("\n\nDo you want to try again (y/n)? ");
                    enter = Console.ReadLine();
                    if (enter == "y") // for retry
                    {
                        Console.Clear();
                    }
                    else if (enter == "n") // for exit
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for using this program");
                        Console.ReadKey();
                        return;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
