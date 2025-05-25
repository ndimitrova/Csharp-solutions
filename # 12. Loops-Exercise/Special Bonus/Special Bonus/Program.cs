int stopNumber = int.Parse(Console.ReadLine());

int previousNumber = 0;

int nextNumber = int.Parse(Console.ReadLine());

while (nextNumber != stopNumber)
{
	previousNumber = nextNumber;

	nextNumber = int.Parse(Console.ReadLine());
}

if (nextNumber == stopNumber)
{
	Console.WriteLine($"{previousNumber * 1.20}");
}
