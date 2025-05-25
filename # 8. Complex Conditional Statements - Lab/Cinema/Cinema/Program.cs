string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeats = int.Parse(Console.ReadLine());

double price = 0;

if (typeOfMovie == "Premiere")
{
    price = 12.00;
}
else if (typeOfMovie == "Normal")
{
    price = 7.50;
}
else
{
    price = 5.00;
}

double totalPrice = countOfRows * price * countOfSeats;

Console.WriteLine($"{totalPrice:f2}");
