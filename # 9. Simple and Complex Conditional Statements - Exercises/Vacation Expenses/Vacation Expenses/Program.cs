string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double sum = 0;

if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        sum = 30 * days * 0.80;
    }
    else 
    {
        sum = 10 * days * 0.80;
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        sum = 50 * days;
    }
    else
    {
        sum = 30 * days;
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        sum = 20 * days * 0.70;
    }
    else
    {
        sum = 15 * days * 0.70;
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        sum = 40 * days * 0.90;
    }
    else
    {
        sum = 10 * days * 0.90;
    }
}

Console.WriteLine($"{sum:f2}");