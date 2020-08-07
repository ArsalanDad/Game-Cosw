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


            gamemenu();



        }

        public static void gamemenu()
        {
            Console.WriteLine("Welcome to Games Mania!!");
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("Lets start! Press any key"); Console.ReadKey();
            Random random = new Random(); //Random number generator 
            int winNum = random.Next(0, 100);  // number between 0-100          
            bool win = false;
            Console.Clear();
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
                    Console.WriteLine("Your guess is too low! Guess higher...."); //if number is to low promts user to guess higher
                }
                else if (i == winNum)            //else if the number is correct then
                {
                    Console.Clear();
                    Console.WriteLine("You Win!! Congrats");  //promots user/congrats user theyve won
                    win = true;
                }
                Console.WriteLine();

            } while (win == false);
            Console.ReadKey();
            game2();







        }
        public static void game2()
        {
            Console.Clear();
            Console.WriteLine("Lets go onto next game rock paper scciors");
            Console.WriteLine("Press any key to continue"); Console.ReadKey();
            Console.ReadLine();
            string inputPlayer, inputComputer;            // 2 inputs for player and computer
            int randomInt;
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
                            Console.WriteLine("Please enter a proper word!");
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
                    Console.WriteLine("Do you want to play the next game? Yes or no?");     //asks user if they want to play next game
                    string Continu3 = Console.ReadLine();
                }
            }
            game3();
        }
       
        public static void game3()
        {
            int scoreboard = 0;

            {   ///////////////////////////Q1/////////////////////////////////
                Console.Clear();
                Console.WriteLine("Today we will test your general knowledge");
                Console.WriteLine("There will be 8 questions with option Good Luck!");
                Console.WriteLine("Q1: Which civil rights activist was famous for refusing to give up her seat on a bus?");
                Console.WriteLine("   a.Rosa Parks  b.James Charles  c.Ivan Lee");
                string answer = Console.ReadLine();

                if (answer != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer == "a")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }


                //////////////////////////Q2/////////////////////////////////////
                Console.WriteLine("Q2: How many teeth does a normal adult have?");
                Console.WriteLine(" a.41  b.32  c.69");
                string answer1 = Console.ReadLine();

                if (answer1 != "b")
                {
                    Console.WriteLine("Correct anwser is b");
                }
                else if (answer1 == "b")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }



                ///////////////////////////Q3/////////////////////////////////
                Console.WriteLine("Q3:In which sport would you use a shuttlecock?");
                Console.WriteLine("   a.Rugby b.Badminton c. Cricket ");
                string answer2 = Console.ReadLine();

                if (answer2 != "b")
                {
                    Console.WriteLine("Correct anwser is b");
                }
                else if (answer2 == "b")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }



                ///////////////////////////Q4///////////////////////////////
                Console.WriteLine("Q4: What is the biggest country in the world?");
                Console.WriteLine("   a.Africa  b.China  c.Russia ");
                string answer3 = Console.ReadLine();

                if (answer3 != "c")
                {
                    Console.WriteLine("Correct anwser is c");
                }
                else if (answer3 == "c")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q5///////////////////////////////
                Console.WriteLine("Q5: How do you say thank you in maori ");
                Console.WriteLine("   a.Tena po pai  b.Kamusta c.Aroha mai ");
                string answer4 = Console.ReadLine();

                if (answer4 != "c")
                {
                    Console.WriteLine("Correct anwser is c");
                }
                else if (answer4 == "c")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q6///////////////////////////////
                Console.WriteLine("Q6: What is the best selling video game of all time? ");
                Console.WriteLine("   a.Minecraft  b.FIFA  c.Roblox ");
                string answer5 = Console.ReadLine();

                if (answer5 != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer5 == "a")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q7///////////////////////////////
                Console.WriteLine("Q7: What is the tallest mountain in the world ");
                Console.WriteLine("  a.Mt Everest  b.Mt Eden  c.Mt Fuji ");
                string answer6 = Console.ReadLine();

                if (answer6 != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer6 == "a")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q8///////////////////////////////
                Console.WriteLine("Q8: What is the capitak of new zealand? ");
                Console.WriteLine("  a.Queenstown  b.Auckland  c.Wellington ");
                string answer8 = Console.ReadLine();

                if (answer6 != "c")
                {
                    Console.WriteLine("Correct anwser is c");
                }
                else if (answer8 == "c")
                {
                    scoreboard++;
                    Console.WriteLine("Yes correct");
                }

                Console.Write("You scored" + scoreboard + " points!");


                string exit = "b";
                string usersinput = "";
                Console.WriteLine("Press b to exit");
                while (usersinput != exit)
                {
                    Console.WriteLine("Press b to exit");
                    usersinput = Console.ReadLine();

                }
                Console.ReadLine();


            }

        }
    }
}














    


       





                                
       

           












