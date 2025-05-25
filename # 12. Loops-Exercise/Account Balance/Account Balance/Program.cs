string command = Console.ReadLine();
double sum = 0;

while (command != "End")
{
    double money = double.Parse(command);
    sum += money;

    if (money > 0)
    {
        Console.WriteLine($"Increase: {money:f2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
    }

    command = Console.ReadLine();
}
Console.WriteLine($"Balance: {sum:f2}");
