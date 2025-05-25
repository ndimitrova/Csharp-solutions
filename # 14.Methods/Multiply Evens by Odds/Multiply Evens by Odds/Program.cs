int number = Math.Abs(int.Parse(Console.ReadLine()));


GetSumOfEvenDigits(number);
GetSumOfOddDigits(number);
GetMultipleOfEvenAndOdds(number);


static int  GetSumOfEvenDigits(int number)
{
    List<int> listOfEven = new List<int>();

    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;

        if (digit % 2 == 0)
        {
            listOfEven.Add(digit);
        }
    }

    return listOfEven.Sum();
}
static int GetSumOfOddDigits(int number)
{
    List<int> listOfOdd = new List<int>();

    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;

        if (digit % 2 != 0)
        {
            listOfOdd.Add(digit);
        }
    }

    return listOfOdd.Sum();
}

static void GetMultipleOfEvenAndOdds(int number)
{
	int sum = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
    Console.WriteLine(sum);
}





