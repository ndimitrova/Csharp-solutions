int startOfRange = int.Parse(Console.ReadLine());
int endOfRange  = int.Parse(Console.ReadLine());

for (int i = startOfRange; i <= endOfRange; i++)
{
    if (((i % 2 != 0) || i == 2) && ((i % 3 != 0) || i == 3) && ((i % 5 != 0) || i == 5) && ((i % 7 != 0) || i == 7))
    {
        Console.Write($"{i} ");
    }
}