using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationEx
{
    class Program
    {
        static void Main()
        {
            // Create a one-dimensional Array of strings. Get text input from user. Create a loop that goes through each string in the Array, adding the user's text to the string. Then create a loop that prints off each string in the Array on a separate line.

            string[] lettersMissing = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "", "", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };

            for (int i = 0; i < lettersMissing.Length; i++)
            {
                Console.WriteLine(lettersMissing[i]);
            }

            Console.WriteLine("\nPlease look at the letters on the sceen and enter the missing letters. ");
            string userInput = Console.ReadLine();

            if (userInput.Equals("JK"))
            {
                Console.WriteLine("Those are the missing letters!");
            }

            //string lettersFilled = lettersMissing[" "] + userInput[];
            Console.WriteLine(lettersFilled);


            // Create an infinite loop

            /*
            string theLoop = "loop";

            do
            {
                Console.WriteLine(theLoop);
            } while (true);
            */


            // Fix the infinite loop so it will execute.

            string theLoopFix = "loop";

            do
            {
                Console.WriteLine(theLoopFix);
            } while (!true);



            // Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.

            // Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.

            // Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.

            // Add code to that above loop that tells a user if they put in text that isn't in the List.

            // Add code to that above loop that stops it from executing once a match has been found.

            // Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

            // Add code to that above loop that tells a user if they put in text that isn't in the List.

            // Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the List, and displays a message showing the string and whether or not it has already appeared in the list.


            Console.Read();

        }
    }
}
