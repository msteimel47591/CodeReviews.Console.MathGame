using ConsoleMathGame.Models;
using System.Diagnostics;

namespace ConsoleMathGame
{
    internal class GameEngine
    {

        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            int difficulty = Helpers.GetDifficulty(message);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, difficulty);
                int secondNumber = random.Next(1, difficulty);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your score was {score}. Press any key to go back to menu.");
                    Console.WriteLine($"Time to complete game was {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds.");
                    Console.ReadLine();
                }
            }

            string gameTime = $"{stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds";

            Helpers.AddToHistory(score, GameType.Addition, Enum.GetName(typeof(GameDifficulty), difficulty), gameTime);
        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            int difficulty = Helpers.GetDifficulty(message);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, difficulty);
                int secondNumber = random.Next(1, difficulty);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your score was {score}. Press any key to go back to menu.");
                    Console.WriteLine($"Time to complete game was {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds.");
                    Console.ReadLine();
                }
            }

            string gameTime = $"{stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds";

            Helpers.AddToHistory(score, GameType.Subtraction, Enum.GetName(typeof(GameDifficulty), difficulty), gameTime);

        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Random random = new Random();
            int score = 0;

            int difficulty = Helpers.GetDifficulty(message);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, difficulty);
                int secondNumber = random.Next(1, difficulty);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your score was {score}. Press any key to go back to menu.");
                    Console.WriteLine($"Time to complete game was {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds.");
                    Console.ReadLine();
                }
            }

            string gameTime = $"{stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds";

            Helpers.AddToHistory(score, GameType.Multiplication, Enum.GetName(typeof(GameDifficulty), difficulty), gameTime);
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int score = 0;

            int difficulty = Helpers.GetDifficulty(message);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();

                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct. Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your score was {score}. Press any key to go back to menu.");
                    Console.WriteLine($"Time to complete game was {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds.");
                    Console.ReadLine();
                }
            }

            string gameTime = $"{stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds";

            Helpers.AddToHistory(score, GameType.Division, Enum.GetName(typeof(GameDifficulty), difficulty), gameTime);


        }

        internal void RandomGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Random random = new Random();
            Random mathOperation = new Random();
            int score = 0;

            int difficulty = Helpers.GetDifficulty(message);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int firstNumber = random.Next(1, difficulty);
                int secondNumber = random.Next(1, difficulty);

                int operation = mathOperation.Next(1, 5);

                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        break;
                    case 4:
                        int[] divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                        firstNumber = divisionNumbers[0];
                        secondNumber = divisionNumbers[1];
                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        break;
                }

                string result = Console.ReadLine();

                result = Helpers.ValidateResults(result);

                switch (operation)
                {
                    case 1:
                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("Your answer was correct. Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("Your answer was correct. Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("Your answer was correct. Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine("Your answer was correct. Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                            Console.ReadLine();
                        }
                        break;
                }

                if (i == 4)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your score was {score}. Press any key to go back to menu.");
                    Console.WriteLine($"Time to complete game was {stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds.");
                    Console.ReadLine();
                }
            }
            string gameTime = $"{stopwatch.Elapsed.Minutes} minutes and {stopwatch.Elapsed.Seconds} seconds";

            Helpers.AddToHistory(score, GameType.Random, Enum.GetName(typeof(GameDifficulty), difficulty), gameTime);
        }
    }
}
