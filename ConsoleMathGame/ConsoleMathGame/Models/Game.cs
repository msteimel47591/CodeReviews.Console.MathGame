
namespace ConsoleMathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType GameType { get; set; }
    public string GameDifficulty { get; set; }
    public string GameTime { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}

internal enum GameDifficulty
{
    Easy = 1,
    Medium = 2,
    Hard = 3
}
