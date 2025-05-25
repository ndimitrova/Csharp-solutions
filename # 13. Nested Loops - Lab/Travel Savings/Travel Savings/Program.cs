
string destination = Console.ReadLine();
double sum = 0;

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());

    while (budget > 0)
    {
        double collectedSum = double.Parse(Console.ReadLine());
        sum += collectedSum;
        Console.WriteLine($"Collected: {sum:f2}");
        budget -= collectedSum;
    }
    if (budget <= 0)
    {
        Console.WriteLine($"Going to {destination}!");
        sum = 0;
    }

    destination = Console.ReadLine();
}
