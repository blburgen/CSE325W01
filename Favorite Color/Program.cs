Console.Write("What is your name? ");
string name = Console.ReadLine() ?? "person who did not want to give their name";
Console.WriteLine($"Welcome, {name}!");
Console.Write("What is your favorite color? ");
string favoriteColor = Console.ReadLine() ?? "blue";
Console.WriteLine($"Oh, I love {favoriteColor} too!");
