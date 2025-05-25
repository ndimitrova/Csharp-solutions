int number = int.Parse(Console.ReadLine());

int sum = 0;

while (true)
{
    int digit = number % 10;
    int newNumber = number / 10;
    sum += digit;
    number = newNumber;
    if (number <= 0)
    {
        Console.WriteLine(sum);
        break;
    }
}

