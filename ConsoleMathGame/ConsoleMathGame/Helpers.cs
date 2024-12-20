using ConsoleMathGame.Models;

namespace ConsoleMathGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>();

        internal static string? ValidateResults(string result)
        {
            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
            {
                Console.WriteLine("Input must be a number");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static void AddToHistory(int gameScore, GameType gameType, string gameDifficulty, string gameTime)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = gameScore,
                GameType = gameType,
                GameDifficulty = gameDifficulty,
                GameTime = gameTime

            });
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} ---- {game.GameType} ---- score: {game.Score} ---- difficulty: {game.GameDifficulty} ---- time: {game.GameTime}");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
        }

        internal static int[] GetDivisionNumbers(int difficulty)
        {

            Random random = new Random();
            int firstNumber = random.Next(0, difficulty);
            int secondNumber = random.Next(0, difficulty);

            int[] result = new int[2];

            while (secondNumber == 0 || firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, difficulty);
                secondNumber = random.Next(1, difficulty);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be blank");
                name = Console.ReadLine();
            }
            return name;
        }

        internal static int GetDifficulty(string message)
        {
            bool difficultyValid = false;
            int difficulty = 0;
            string difficultyMessage = "";

            while (!difficultyValid)
            {
                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine("Select difficulty: 1 = easy, 2 = medium, 3 = hard");
                string result = Console.ReadLine();

                if (!String.IsNullOrEmpty(result) && int.TryParse(result, out int inputDifficulty) && inputDifficulty > 0 && inputDifficulty < 4)
                {
                    switch (inputDifficulty)
                    {
                        case 1:
                            difficulty = 9;
                            difficultyMessage = "Easy";
                            break;
                        case 2:
                            difficulty = 99;
                            difficultyMessage = "Medium";
                            break;
                        case 3:
                            difficulty = 999;
                            difficultyMessage = "Hard";
                            break;
                    }

                    difficultyValid = true;
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine($"{difficultyMessage} difficulty selected.");
            return difficulty;
        }

    }
}
