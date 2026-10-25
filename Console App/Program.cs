DateTime today = DateTime.Today;

// 1. Create a Christmas date for the current year
DateTime nextChristmas = new DateTime(today.Year, 12, 25);

// 2. If Christmas has already passed this year, roll over to next year
if (today > nextChristmas)
{
    nextChristmas = nextChristmas.AddYears(1);
}

DateTime lastChristmas = nextChristmas.AddYears(-1);
// 3. Calculate the difference in days
int daysUntilChristmas = (nextChristmas - today).Days;
int daysSinceChristmas = (today - lastChristmas).Days;

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");
Console.WriteLine($"There are {daysUntilChristmas} days until the next Christmas. {DateOnly.FromDateTime(nextChristmas)}");
Console.WriteLine($"There are {daysSinceChristmas} days since the last Christmas. {DateOnly.FromDateTime(lastChristmas)}");