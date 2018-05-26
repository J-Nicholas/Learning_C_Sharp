using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9_Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard display = new GameBoard();
            Console.WriteLine("Welcome to the Tic Tac Toe Game.\n");
            string userInput = null;
            string[] currentPlayer = { "One", "Two" };
            char playerOneToken = ' ';                                  // these get assigned later depending on user choice
            char playerTwoToken = ' ';                                  // these get assigned later depending on user choice
            int playerOneWins = 0;
            int playerTwoWins = 0;
            int drawnMatches = 0;
            int turnCount = 0;

            int playerTurn = 0;                                          // determines whose turn it is, playerOne = 0, PlayerTwo = 1;
            bool isGameOver = false;
            bool firstPlayerDetermined = false;
            bool chosenTokenDetermined = false;
            bool validPlayAgain = false;
            bool firstGame = true;
            bool gameWasDraw = false;
            bool isRematch = false;

            while (userInput != "exit")
            {
                PrintMenu();
                if (firstGame == false)
                {
                    Console.Clear();
                    //PrintMenu();
                }
                if (isRematch == false)
                {
                    userInput = Console.ReadLine();
                }


                if (userInput == "exit")                                // Exit functionality
                {
                    Console.WriteLine("Exiting.");
                    continue;
                }
                else if (userInput == "help")                           // display help menu
                {
                    PrintHelp();
                }
                else if (userInput == "start")
                {
                    while (isGameOver == false)
                    {
                        if (firstPlayerDetermined == false)
                        {
                            while (firstPlayerDetermined == false)
                            {
                                Console.Write("Who should go first? Player One or Player Two?\nEnter \"1\" or \"2\":");
                                userInput = Console.ReadLine();
                                if (userInput == "2" || userInput == "two" || userInput == "Two")
                                {
                                    playerTurn++;
                                    firstPlayerDetermined = true;
                                }
                                else if (userInput == "1" || userInput == "one" || userInput == "Two")
                                {
                                    firstPlayerDetermined = true;
                                }
                                else
                                    Console.WriteLine("Invalid input, try again.");
                            }
                        }
                        if (chosenTokenDetermined == false)
                        {
                            Console.Write("Which token would you like? X\'s or O\'s?\nType \"X\" or \"0\"");
                            userInput = Console.ReadLine();
                            if (userInput == "x" || userInput == "X")
                            {
                                if (playerTurn == 0)
                                {
                                    playerOneToken = 'X';
                                    playerTwoToken = 'O';
                                }
                                else
                                {
                                    playerTwoToken = 'X';
                                    playerOneToken = 'O';
                                }
                            }
                            else if (userInput == "o" || userInput == "O")
                            {
                                if (playerTurn == 0)
                                {
                                    playerOneToken = 'O';
                                    playerTwoToken = 'X';
                                }
                                else
                                {
                                    playerOneToken = 'X';
                                    playerTwoToken = 'O';
                                }
                            }
                            else continue;
                            Console.Clear();
                            Console.WriteLine($"Player One has {playerOneToken}\'s.\nPlayer Two has {playerTwoToken}\'s.");
                            chosenTokenDetermined = true;
                        }               // logic for setting player's chosen tokens
                        

                        display.PrintGameBoard();


                        Console.WriteLine($"Player {currentPlayer[playerTurn]}\'s turn:\n");
                        if (playerTurn == 0 % 2)
                        {
                            Console.WriteLine($"Enter a number to place an {playerOneToken}");
                            bool validInput = false;
                            while (validInput == false)
                            {
                                userInput = Console.ReadLine();
                                if (display.UpdateBoard(playerOneToken, userInput))
                                    validInput = true;                          //repeat until valid input is received 
                                if (display.CheckIfGameOver(playerTurn) == true)
                                {
                                    isGameOver = true;
                                    validInput = true;
                                    continue;
                                }
                            }
                        }                           // logic for validating token placement and checking for winner
                        if (playerTurn == 1 % 2)
                        {
                            Console.WriteLine($"Enter a number to place an {playerTwoToken}");
                            bool validInput = false;
                            while (validInput == false)
                            {

                                userInput = Console.ReadLine();
                                if (display.UpdateBoard(playerTwoToken, userInput))
                                    validInput = true;                          //repeat until valid input is received 
                                if (display.CheckIfGameOver(playerTurn) == true)
                                {
                                    isGameOver = true;
                                    validInput = true;
                                    break;
                                }
                            }
                        }                           // logic for validating token placement and checking for winner

                        Console.Clear();
                        //stalemate rules
                        if (turnCount == 8 && display.CheckIfGameOver(playerTurn) == false)
                        {
                            display.PrintGameBoard();
                            Console.WriteLine("Match ended in stalemate.\nEnter any key to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            drawnMatches++;
                            gameWasDraw = true;
                            isGameOver = true;
                        }
                        if (isGameOver == false)
                        {
                            turnCount++;
                            playerTurn++;                                             //
                            playerTurn %= 2;                                          // manages current player   
                        }
                    }

                    // After game logic
                    Console.Clear();
                    display.PrintGameBoard();
                    Console.WriteLine();
                    display.CheckIfGameOver(playerTurn);
                    turnCount = 0;
                    firstGame = false;

                    if (playerTurn == 0 && gameWasDraw == false)
                    {
                        playerOneWins++;
                    }
                    else if (playerTurn == 1 && gameWasDraw == false)
                    {
                        playerTwoWins++;
                    }
                    gameWasDraw = false; // resetting for next match

                    Console.WriteLine($"Player One has {playerOneWins} wins.\nPlayer Two has {playerTwoWins} wins.\n");
                    Console.WriteLine($"There have been {drawnMatches} draws.");

                    Console.WriteLine("Play again? y/n");
                    while(validPlayAgain == false)
                    {
                        userInput = Console.ReadLine();
                        if (userInput == "y")
                        {
                            userInput = "start";
                            validPlayAgain = true;
                            isGameOver = false;
                            display = new GameBoard();
                            isRematch = true;
                            continue;
                        }
                        else if (userInput == "n")
                        {
                            userInput = "exit";
                            validPlayAgain = true;
                            continue;
                        }
                        else Console.WriteLine("Invalid input, try again.\n");
                    }
                    validPlayAgain = false;                                             // resetting for next match
                    playerTurn++;                                                       // alternating who goes first
                    playerTurn %= 2;
                    //continue;
                }
            }
        }
        static void PrintHelp()
        {
            GameBoard helpBoard = new GameBoard();
            string helpMenuInput = null;

            while (helpMenuInput != "Okay")
            {
                Console.Clear();
                Console.WriteLine("Use the numpad to select which square to place a cross or circle in.\n");
                helpBoard.PrintHelpBoard();
                Console.WriteLine("\nType \"Okay\" to continue.");
                helpMenuInput = Console.ReadLine();
            }
            Console.Clear();
            
        }
        static void PrintMenu()
        {
            Console.WriteLine("Type \"help\" to view the controls \nor type \"start\" to begin");
        }
    }

}
