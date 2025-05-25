int n = int.Parse(Console.ReadLine());

while (true)
{
	if (n >= 1 && n <= 100)
	{
		Console.WriteLine(n); 
		break;
	}
	else 
	{
		n = int.Parse(Console.ReadLine());
	}
}
