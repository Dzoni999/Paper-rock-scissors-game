namespace Paper_Rock_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;
     
           

            Console.WriteLine("- - - - - Welcome to game!- - - - -\n");
            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Choose PAPER, ROCK or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("\nPlayer: " + player);
                Console.WriteLine("\nComputer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You win!");
                           
                        }
                        
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                           
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        break;
                }

              


                Console.WriteLine("Would you like to play again? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!\n");
            Console.WriteLine("Goodbye!");

            Console.ReadKey();
        }

      }
    }


