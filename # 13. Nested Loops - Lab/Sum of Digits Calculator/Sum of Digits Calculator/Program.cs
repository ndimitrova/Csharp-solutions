string command = Console.ReadLine();
int sum = 0;

while (command != "End")
{
    int number = int.Parse(command);

    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number = number / 10;
    }
    if (number <= 0)
    {
        Console.WriteLine($"Sum of digits = {sum}");
        sum = 0;
    }

    command = Console.ReadLine();
}

if (command == "End")
{
    Console.WriteLine("Goodbye");
}
