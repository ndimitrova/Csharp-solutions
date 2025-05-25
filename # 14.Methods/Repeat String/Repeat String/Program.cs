string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

PrintText(text, count);

static void PrintText(string text, int count)
{
	for (int i = 0; i < count; i++)
	{
		Console.Write(text);
	}

	Console.WriteLine();
}
