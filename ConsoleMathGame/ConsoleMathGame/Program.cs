using ConsoleMathGame;

DateTime date = DateTime.UtcNow;
Menu menu = new Menu();

string name = Helpers.GetName();

menu.ShowMenu(name, date);







