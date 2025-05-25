int n = int.Parse(Console.ReadLine());

PrintTriangle(n);

static void PrintTriangle (int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }

    for (int k = n - 1; k >= 1; k--)
    {
        for (int l = 1; l <= k; l++)
        {
            Console.Write($"{l} ");
        }
        Console.WriteLine();
    }
}
