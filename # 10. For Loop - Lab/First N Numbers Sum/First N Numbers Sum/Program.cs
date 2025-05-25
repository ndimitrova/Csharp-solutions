int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    if (i != n)
    {
        sum += i;
        Console.Write($"{i}+");
    }
    else
    {
        sum += i;
        Console.WriteLine($"{i}={sum}");
    }
}
