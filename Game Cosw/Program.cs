using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Cosw
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Welcome to Games Mania!!");
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +  name);
            Console.Write("Lets start! Press any key"); Console.ReadKey();



            Random random = new Random(); //Random number generator 
            int winNum = random.Next(0, 100);  // number between 0-100          
            bool win = false;

            Console.WriteLine("First game is a number guessing game!!"); //welcoming/intro 
            do
            {
                Console.WriteLine("Im thinking of a number between 0 to 100"); // lets user know the number is between 1-100
                string a = Console.ReadLine();

                int i = int.Parse(a);

                if (i > winNum) //check if the users number is higher than the random number
                {
                    Console.WriteLine("Your guess is too high! Guess lower..."); // prompts user to guess lower
                }
                else if (i < winNum) //check if the users number is lower than the random number    
                {
                    Console.WriteLine("Your guess is too low! Guess higher....");    //if number is to low promts user to guess higher
                }
                else if (i == winNum)            //else if the number is correct then
                {
                    Console.WriteLine("You Win!! Congrats");  //promots user/congrats user theyve won
                    win = true;
                }
                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Do you want to play the next game? Yes or no?");     //asks user if they want to play next game
            string Continu = Console.ReadLine();                                     

            if (Continu == "yes")
            {
                Console.WriteLine("");
                Console.WriteLine("......................................................");
                Console.WriteLine("");
                Console.WriteLine("Lets go onto next game rock paper scciors");
                Console.WriteLine("Press any key to continue");  Console.ReadKey(); 
                Console.ReadLine();
                string inputPlayer, inputComputer;            // 2 inputs for player and computer
                int randomInt;

                bool playAgain = true;

                while (playAgain)
                {

                    int scorePlayer = 0;                     //
                    int scoreComputer = 0;                   //  scores for player and computer

                    while (scorePlayer < 3 && scoreComputer < 3)
                    {


                        Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");           
                        inputPlayer = Console.ReadLine();
                        inputPlayer = inputPlayer.ToUpper();

                        Random rnd = new Random();

                        randomInt = rnd.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                inputComputer = "ROCK";                           //* If the computer chooses rock and the player chooses rock then its a tie
                                Console.WriteLine("Computer chose ROCK");         // otherwise if the players input is something else scciosrs, paper, then the computer
                                if (inputPlayer == "ROCK")                        // c
                                { 
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("COMPUTER WINS!!\n\n");
                                    scoreComputer++;
                                }
                                break;
                            case 2:
                                inputComputer = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("COMPUTER WINS!!\n\n");
                                    scoreComputer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3:
                                inputComputer = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("COMPUTER WINS!!\n\n");
                                    scoreComputer++;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid entry!");
                                break;
                        }

                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCOMPUTER:\t{1}", scorePlayer, scoreComputer);

                    }

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player WON!");
                    }
                    else if (scoreComputer == 3)
                    {
                        Console.WriteLine("Computer WON!");
                    }
                    {

                         



                    }
                }
            }
        }
    }
}
          












