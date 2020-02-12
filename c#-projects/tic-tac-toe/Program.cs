using System;

namespace tic_tac_toe
{
    internal class Program
    {
        private static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static int player = 1;
        private static int choice;

        private static int Flag = 0;

        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("player1:X and and player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("player 2 chance");
                }
                else
                {
                    Console.WriteLine("Player 1 chance");
                }
                Console.WriteLine("\n");
                buildBoard();
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("sorry the row (0) is already marked with (1)", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("please wait 2 seconds, board is loading again...");
                   
                }
                Flag = checkWin();
            } while (Flag != 1 && Flag != -1);

            Console.Clear();

            if (Flag == 1)
            {
                Console.WriteLine("player {0} has won");
            }
            else
                Console.WriteLine("draw");
        }

        public static void buildBoard()
        {
            Console.WriteLine("  |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("____|____|____");
            Console.WriteLine("  |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("____|____|____");
            Console.WriteLine("  |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);

        }

        public static int checkWin()
        {
            #region Horzontal Winning Condtion

            if (arr[1] == arr[2] && arr[2] == arr[3])

            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {
                return 1;
            }

            #endregion Horzontal Winning Condtion

            #region vertical Winning Condtion

            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {
                return 1;
            }

            #endregion vertical Winning Condtion

            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {
                return 1;
            }

            #endregion Diagonal Winning Condition

            #region Checking For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            {
                return -1;
            }
            #endregion

            return 0;

        }
    }
}