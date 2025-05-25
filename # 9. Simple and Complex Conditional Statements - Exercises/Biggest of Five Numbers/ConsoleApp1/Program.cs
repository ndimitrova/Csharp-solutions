
int biggestNumber = int.MinValue;

for (int i = 0; i < 5; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > biggestNumber)
    {
        biggestNumber = number;
    }
}

Console.WriteLine(biggestNumber);
