using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            Random rnd = new Random();
            int number;
            string playerInput = "";
            int playerNumber = 0;
            int attempts = 0;
            string playAgain = "";

            Console.WriteLine("Welcome to guess the number!");
            Console.WriteLine("The computer will generate a random number between 1 and 100");
            Console.WriteLine("Your job is the guess what that number is");
            Console.WriteLine("Do you want to play (Y/N): ");
            playAgain = Console.ReadLine();

            do
            {
                attempts = 0;
                // Welcome user to game, explain rules and generate random number
                
                number = rnd.Next(1, 101);

                // Loop until user guesses correct number
                do
                {

                    // Gets users guess
                    Console.WriteLine("Please enter a number between 1 and 100: ");
                    playerInput = Console.ReadLine();
                    playerNumber = Convert.ToInt32(playerInput);
                    attempts++;

                    // Finds whether user is higher or lower than the correct number and tells them
                    if (playerNumber > 100 || playerNumber < 1)
                    {
                        Console.WriteLine("That is not a number between 1 and 100 try again");
                    }
                    else if (playerNumber < number)
                    {
                        Console.WriteLine("Your guess was too low try again");
                    }
                    else if (playerNumber > number)
                    {
                        Console.WriteLine("Your guess was too high try again");
                    }

                } while (playerNumber != number);

                Console.WriteLine("Congratulations you guessed the correct number");
                Console.WriteLine("It took you " + attempts + " attempts to guess the correct number");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Do you want to play again (Y/N) ");
                playAgain = Console.ReadLine();
                

            } while (playAgain == "Y");

            Console.ReadKey();

        }
    }
}
