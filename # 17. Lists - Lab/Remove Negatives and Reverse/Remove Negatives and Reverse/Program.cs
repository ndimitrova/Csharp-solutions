List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> positiveNums = new List<int>();

foreach (int number in numbers)
{
    if (number > 0)
    {
        positiveNums.Add(number);
    }
}

positiveNums.Reverse();

if (positiveNums.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", positiveNums));
}
