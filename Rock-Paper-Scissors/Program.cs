/*******************************************
* Rock-Paper-Scissors
* By Jamie Youngjae Yoo
* ******************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock-Paper-Scissors";

            // string variables for user and computer's choice
            string sUsersChoice, sComputersChoice;
            // string array for random option of computer's choice
            string[] sOptions = new string[] { "rock", "paper", "scissors" };
            // instance of random class
            Random rand = new Random();
            // char variable for replaying the game
            char chReplay;
            // boolean for error checking
            bool bError;

            // using do-while loop to replay the game
            do
            {
                // clear current console screen
                Console.Clear(); 

                Console.WriteLine("Please select your play from the following choices...\n");
                Console.WriteLine(" Rock\n Paper\n Scissors");
                Console.Write("\nYour selection: ");
                // read and save the user's input
                sUsersChoice = Console.ReadLine().ToLower();

                // repeat until user input the valid selection
                while (sUsersChoice != "rock" && sUsersChoice != "paper" && sUsersChoice != "scissors")
                {
                    Console.Clear();

                    Console.WriteLine("Invalid choice was selected. Please try again!\n");

                    Console.WriteLine("Please select your play from the following choices...\n");
                    Console.WriteLine(" Rock\n Paper\n Scissors");
                    Console.Write("\nYour selection: ");
                    sUsersChoice = Console.ReadLine().ToLower();
                }

                // initialize random options for the computer's choice for the game
                sComputersChoice = sOptions[rand.Next(3)];

                Console.WriteLine($"\nComputer played {sComputersChoice} and you played {sUsersChoice}.\n");

                // determine if user win, lose or draw depending on the computer or user's choice
                // and show result of the game
                switch (sComputersChoice)
                {
                    case "rock":
                        switch (sUsersChoice)
                        {
                            case "rock":
                                Console.WriteLine("Draw.");
                                break;
                            case "paper":
                                Console.WriteLine("Paper covers rock, you win.");
                                break;
                            case "scissors":
                                Console.WriteLine("Rock crushes scissors, you lose.");
                                break;
                        }
                        break;
                    case "paper":
                        switch (sUsersChoice)
                        {
                            case "rock":
                                Console.WriteLine("Paper covers rock, you lose.");
                                break;
                            case "paper":
                                Console.WriteLine("Draw.");
                                break;
                            case "scissors":
                                Console.WriteLine("Scissors cuts paper, you win.");
                                break;
                        }
                        break;
                    case "scissors":
                        switch (sUsersChoice)
                        {
                            case "rock":
                                Console.WriteLine("Rock crushes scissors, you win.");
                                break;
                            case "paper":
                                Console.WriteLine("Scissors cuts paper, you lose.");
                                break;
                            case "scissors":
                                Console.WriteLine("Draw.");
                                break;
                        }
                        break;
                }

                Console.Write("\nPress 'y' to play again or 'x' to exit: ");

                bError = char.TryParse(Console.ReadLine(), out chReplay);

                while (!bError)
                {
                    Console.WriteLine("\nPlease press 'y' to play again or 'x' to exit\n");
                    bError = char.TryParse(Console.ReadLine(), out chReplay);
                }

            // repeat the game if user entered "y"
            } while (chReplay.ToString().ToLower() == "y");
        }
    }
}
