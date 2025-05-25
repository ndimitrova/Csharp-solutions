int centuries = int.Parse(Console.ReadLine());

int years = centuries * 100;
double days = years * 365.2422;
double hours = Math.Round(days) * 24;
double minutes = hours * 60;

Console.WriteLine($"{centuries} centuries = {years} years = {Math.Round(days)} days = {hours} hours = {minutes} minutes");