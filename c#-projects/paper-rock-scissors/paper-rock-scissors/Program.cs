using System;

namespace paper_rock_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputplayer, inputCPU;
            int randomInt;

            bool playAgian = true;

            while (playAgian)
            {
                int scoreplayer = 0;
                int scoreCPU = 0;

                while (scoreplayer < 3 && scoreCPU < 3)
                {

                    Console.Write("choose between rock, paper and scissors:   ");
                    inputplayer =
                        Console.ReadLine();
                    inputplayer = inputplayer.ToUpper();

                    Random rnd = new Random();

                    randomeInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("computer chose rock");
                            if (inputplayer == "rock")
                            {
                                Console.WriteLine("draw!!\n\n");
                            }
                            else if (inputplayer == "paper")
                            {
                                Console.WriteLine("playerwins!!\n\n");
                                scoreplayer++;
                            }
                            else if (inputplayer == "scissors")
                            {
                                Console.WriteLine("CPU wins!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("computer chose paper");
                            if (inputplayer == "rock")
                            {
                                Console.WriteLine("CPU wins\n\n");
                                scoreCPU++;
                            }
                            else if (inputplayer == "scissore") 
                            {
                                Console.WriteLine("player wins\n\n");
                                scoreplayer++;
                            }
                            if (inputplayer == "paper")


                                Console.WriteLine("draw!!\n\n");

                            break;
                        case 3:
                            inputCPU = "scissors";
                            Console.writeline("computer chose scissors");
                            if (inputplayer == "scissors")
                            {
                                Console.WriteLine("draw!!\n\n");
                            }
                            else if (inputplayer == "paper")
                            {
                                Console.WriteLine("cpu wins!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputplayer == "rock")
                            {
                                Console.WriteLine("player wins!!\n\n");
                                scoreplayer++;
                            }
                            break;
                        default:
                            Console.WriteLine("invalid entry");
                            break;

                    }
                    Console.WriteLine("/n/nscores:\tplayer:\t{0}\tcpu:\t{1}", scoreplayer, scoreCPU);
                }
                if (scoreplayer == 3)
                {
                    Console.WriteLine("player won");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("cpu won");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play agian? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y") 

                playAgian = true;
                Console.Clear();

                if (loop == "n")
                {
                    playAgian = false;
                }
                else
                {

                }
            }


        }
    }
