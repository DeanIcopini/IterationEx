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
            //Console.WriteLine("Please enter a place you would like to go! ");
            //string[] addLib = { "I ", "want ", "to ", "go ", "to ", "the", "" };
            //string userInput = Console.ReadLine();
            //addLib[6] = userInput;

            //for (int i = 0; i < addLib.Length; i++)
            //{
            //    Console.WriteLine(addLib[i]);
            //}
            //Console.ReadLine();



            //Console.WriteLine("\n\nHere is the english alphabet, but there are some missing letters. " + "\nA B C D E F G H I  L M N O P Q R S T U V W X Y Z. ");

            //Console.WriteLine("\nPlease enter the first missing letter that you notice. ");
            //string userInputFirstLetter = Console.ReadLine(); //element[9]

            //Console.WriteLine("Great! " + "Now enter the second letter you notice that is missing. ");
            //string userInputSecondLetter = Console.ReadLine(); //element[10]

            //string[] lettersMissing = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "", "", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };

            //for (int i = 0; i < lettersMissing.Length; i++)
            //{
            //    Console.WriteLine(lettersMissing[i]);
            //}

            //lettersMissing[9] = userInputFirstLetter;
            //lettersMissing[10] = userInputSecondLetter;

            //for (int i = 0; i < lettersMissing.Length; i++)
            //{
            //    Console.WriteLine(lettersMissing[i]);
            //}

            //if (userInputFirstLetter == "J" || userInputFirstLetter == "j" && userInputSecondLetter == "K" || userInputSecondLetter == "k")
            //{
            //    Console.WriteLine("You got it! Those are the two missing letters. ");
            //}
            //else
            //{
            //    Console.WriteLine("\nThose dont seem to be the right letters. ");
            //}

            //Console.Read();


            //// Create an infinite loop

            ///*
            //string theLoop = "loop";

            //do
            //{
            //    Console.WriteLine(theLoop);
            //} while (true);
            //*/


            ////Fix the infinite loop so it will execute.

            //string theLoopFix = "loop";

            //do
            //{
            //    Console.WriteLine(theLoopFix);
            //} while (!true);



            // Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.

            
            Console.WriteLine("Please enter your age: ");
            int userInputAge = Convert.ToInt32(Console.ReadLine());
            int drinkingAge = userInputAge;

            for (int i = 0; i < userInputAge; i++)
            {
                if (drinkingAge < 21)
                {
                    Console.WriteLine("You are not old enough to have an adult beverage! ");
                }
                else
                {
                    Console.WriteLine("You are old enough to have an adult beverage! ");
                }
            }

            Console.ReadLine();

            // Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.

            int drinkingAge1 = 0;

            for (int i = 0; i < drinkingAge1; i++)
            {
                if (drinkingAge1 <= 20)
                {
                    Console.WriteLine("You are not old enough to have an adult beverage! ");
                }
                else
                {
                    Console.WriteLine("You are old enough to have an adult beverage! ");
                }
            }

            Console.ReadLine();



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
