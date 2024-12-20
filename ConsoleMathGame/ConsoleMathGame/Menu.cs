
namespace ConsoleMathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()} It is {date.DayOfWeek}. This is your math game");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine(@$"What game would you like to play? Choose from the options below:
V - View History
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random
Q - Quit");
                Console.WriteLine("----------------------------------------------------------------------");

                string gameSelected = Console.ReadLine();


                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "r":
                        engine.RandomGame("Random game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);

        }
    }
}
