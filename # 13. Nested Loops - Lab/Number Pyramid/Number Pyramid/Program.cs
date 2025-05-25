int n = int.Parse(Console.ReadLine());
int counter = 1;

for (int i = 1; i <= n; i++)
{
	for (int j = 0; j < i; j++)
	{
        Console.Write($"{counter} ");
        counter++;

        if (counter > n)
        {
            Console.WriteLine();
            return;
        }
    }
    Console.WriteLine();
}
