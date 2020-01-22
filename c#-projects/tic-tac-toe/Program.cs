using System;

namespace tic_tac_toe
{
    class Program
    {
        static char[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static int player = 1;
        static int choice;

        static FlagsAttribute = 0;

        static void Main(string[] args)
        {
            do
                (
                Console.clean();
            Console.WriteLine("player1:X and and player2:O");
            Console.WriteLine("\n");
            if (player % 2 == 0)
            {
                Console.WriteLine("player 2 chance");
            }
            else
            {
                Console.WriteLine('Player 1 chance');
            }
            Console.WriteLine("\n");
            boar();
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
                ThreadStaticAttribute.sleep(2000);
            }
            FlagsAttribute = checkwin();
        }while (FlagsAttribute!= 1 && flag !=);

          console.clean();
            board();

        if (flag ==1)
            {
 Console.WriteLine("player {0} has won");
            }
           else
             Console.WriteLine("draw");
        }
        
}
