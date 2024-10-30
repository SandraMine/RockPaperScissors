namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random random = new Random();
                int playerScore = 0;
                int enemyScore = 0;

                Console.WriteLine("Welcome to Rock Paper Scissors!");

                while (playerScore < 3 && enemyScore < 3)
                {
                    Console.WriteLine($"\nPlayer Score: {playerScore}, Enemy Score: {enemyScore}");
                    Console.WriteLine("Please enter 'r' for Rock, 'p' for Paper, or 's' for Scissors:");
                    string playerChoice = Console.ReadLine()?.ToLower();

                    int enemyChoice = random.Next(0, 3);
                    string enemyMove = enemyChoice switch
                    {
                        0 => "Rock",
                        1 => "Paper",
                        _ => "Scissors"
                    };

                    Console.WriteLine($"Enemy chooses {enemyMove}.");

                    switch (playerChoice)
                    {
                        case "r":
                            if (enemyChoice == 0) // Rock
                            {
                                Console.WriteLine("It's a tie!");
                            }
                            else if (enemyChoice == 1) // Paper
                            {
                                Console.WriteLine("Enemy wins this round.");
                                enemyScore++;
                            }
                            else // Scissors
                            {
                                Console.WriteLine("Player wins this round.");
                                playerScore++;
                            }
                            break;

                        case "p":
                            if (enemyChoice == 0) // Rock
                            {
                                Console.WriteLine("Player wins this round.");
                                playerScore++;
                            }
                            else if (enemyChoice == 1) // Paper
                            {
                                Console.WriteLine("It's a tie!");
                            }
                            else // Scissors
                            {
                                Console.WriteLine("Enemy wins this round.");
                                enemyScore++;
                            }
                            break;

                        case "s":
                            if (enemyChoice == 0) // Rock
                            {
                                Console.WriteLine("Enemy wins this round.");
                                enemyScore++;
                            }
                            else if (enemyChoice == 1) // Paper
                            {
                                Console.WriteLine("Player wins this round.");
                                playerScore++;
                            }
                            else // Scissors
                            {
                                Console.WriteLine("It's a tie!");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please enter 'r', 'p', or 's'.");
                            break;
                    }
                }

                Console.WriteLine(playerScore == 3 ? "You win!" : "You lose!");
            }
        }
    }

}
    

