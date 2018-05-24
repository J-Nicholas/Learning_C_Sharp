using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9_Tic_Tac_Toe
{
    class GameBoard
    {
        private string[] layout;
        private string[] helpLayout;
        private bool one, two , three, four, five, six, seven, eight, nine;

        public GameBoard ()
        {
            layout = new string[5];
            helpLayout = new string[5];
            one = two = three = four = five = six = seven = eight = nine = false;

        int countHelper = 7;
            for (int row = 0; row < layout.Length; row++)
            {
                if (row % 2 == 0)
                {
                    layout[row] = "\t\t\t   |   |   ";
                    helpLayout[row] = $"\t\t\t {countHelper} | {countHelper +1} | {countHelper + 2} ";
                    countHelper -= 3;
                }
                else
                {
                    layout[row] = "\t\t\t---+---+---";
                    helpLayout[row] = "\t\t\t---+---+---";
                }
            }
        }
        public void PrintGameBoard()                            // default empty gameboard
        {
            for (int i = 0; i < layout.Length; i++)
            {
                Console.WriteLine(layout[i]);
            }
        }
        public void PrintHelpBoard()                            // displays gameboard with numbers in slots.
        {
            for (int i = 0; i < layout.Length; i++)
            {
                Console.WriteLine(helpLayout[i]);
            }
        }
        public bool UpdateBoard(char token, string index )
        {
            // Bottom row
            if (index == "1" && !one)
            {
                StringBuilder replacement = new StringBuilder(layout[4]);
                replacement[4] = token;
                layout[4] = replacement.ToString();
                one = true;
                return true;
            }
            else if (index == "2" && two == false)
            {
                StringBuilder replacement = new StringBuilder(layout[4]);
                replacement[4 + 4] = token;
                layout[4] = replacement.ToString();
                two = true;
                return true;
            }
            else if (index == "3" && !three)
            {
                StringBuilder replacement = new StringBuilder(layout[4]);
                replacement[4 + 8] = token;
                layout[4] = replacement.ToString();
                three = true;
                return true;
            }
            //middle row
            else if (index == "4" && !four)
            {
                StringBuilder replacement = new StringBuilder(layout[2]);
                replacement[4] = token;
                layout[2] = replacement.ToString();
                four = true;
                return true;
            }
            else if (index == "5" && !five)
            {
                StringBuilder replacement = new StringBuilder(layout[2]);
                replacement[4 + 4] = token;
                layout[2] = replacement.ToString();
                five = true;
                return true;
            }
            else if (index == "6" && !six)
            {
                StringBuilder replacement = new StringBuilder(layout[2]);
                replacement[4 + 8] = token;
                layout[2] = replacement.ToString();
                six = true;
                return true;
            }
            // top row
            else if  (index == "7" && ! seven)
            {
                StringBuilder replacement = new StringBuilder(layout[0]);
                replacement[4] = token;
                layout[0] = replacement.ToString();
                seven = true;
                return true;
            }
            else if (index == "8" && !eight)
            {
                StringBuilder replacement = new StringBuilder(layout[0]);
                replacement[4+4] = token;
                layout[0] = replacement.ToString();
                eight = true;
                return true;
            }
            else if (index == "9" && !nine)
            {
                StringBuilder replacement = new StringBuilder(layout[0]);
                replacement[4 + 8] = token;
                layout[0] = replacement.ToString();
                nine = true;
                return true;
            }
            else return false;
        }
        public bool CheckIfGameOver (int currentPlayer)
        {
            // ----------------------DIAGONAL RULES ---------------------------------
            // Right leaning diagonal
            if (layout[0][12] == 'X' && layout[2][8] == 'X' && layout[4][4] == 'X' )
            {
                Console.WriteLine($"Player {currentPlayer+1} won on the diagonal with X\'s.");
                return true;
            }
            if (layout[0][12] == 'O' && layout[2][8] == 'O' && layout[4][4] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the diagonal with O\'s.");
                return true;
            }
            // Left leaning diagonal
            if (layout[0][4] == 'X' && layout[2][8] == 'X' && layout[4][12] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the diagonal with X\'s.");
                return true;
            }
            if (layout[0][4] == 'O' && layout[2][8] == 'O' && layout[4][12] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the diagonal with O\'s.");
                return true;
            }

            // ----------------------HORIZONTAL RULES --------------------------------
            // top row
            if (layout[0][4] == 'X' && layout[0][8] == 'X' && layout[0][12] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the top row with X\'s.");
                return true;
            }
            if (layout[0][4] == 'O' && layout[0][8] == 'O' && layout[0][12] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the top row with O\'s.");
                return true;
            }
            // middle row
            if (layout[2][4] == 'X' && layout[2][8] == 'X' && layout[2][12] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the middle row with X\'s.");
                return true;
            }
            if (layout[2][4] == 'O' && layout[2][8] == 'O' && layout[2][12] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the middle row with O\'s.");
                return true;
            }
            // bottom row
            if (layout[4][4] == 'X' && layout[4][8] == 'X' && layout[4][12] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the bottom row with X\'s.");
                return true;
            }
            if (layout[4][4] == 'O' && layout[4][8] == 'O' && layout[4][12] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the bottom row with O\'s.");
                return true;
            }

            // ----------------------VERTICAL RULES ----------------------------------
            // left collumn
            if (layout[0][4] == 'X' && layout[2][4] == 'X' && layout[4][4] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the left collumn with X\'s.");
                return true;
            }
            if (layout[0][4] == 'O' && layout[2][4] == 'O' && layout[4][4] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the left collumn with O\'s.");
                return true;
            }
            // middle collumn
            if (layout[0][8] == 'X' && layout[2][8] == 'X' && layout[4][8] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the middle collumn with X\'s.");
                return true;
            }
            if (layout[0][8] == 'O' && layout[2][8] == 'O' && layout[4][8] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the middle collumn with O\'s.");
                return true;
            }
            // bottom row
            if (layout[0][12] == 'X' && layout[2][12] == 'X' && layout[4][12] == 'X')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the right collumn with X\'s.");
                return true;
            }
            if (layout[0][12] == 'O' && layout[2][12] == 'O' && layout[4][12] == 'O')
            {
                Console.WriteLine($"Player {currentPlayer + 1} won on the right collumn with O\'s.");
                return true;
            }

            // ----------------------STALEMATE RULES -----------------------------------

            return false;
        }
    }
}
