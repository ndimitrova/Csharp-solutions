int n = int.Parse(Console.ReadLine());

int biggestNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()); 

    if (number >= biggestNumber)
    {
        biggestNumber = number;
    }   
}

Console.WriteLine(biggestNumber);
