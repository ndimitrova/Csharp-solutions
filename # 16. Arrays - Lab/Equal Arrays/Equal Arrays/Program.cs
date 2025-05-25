int[] firstArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool isEqual = true;


for (int i = 0; i < firstArr.Length; i++)
{
	if (firstArr[i] != secondArr[i])
	{
		Console.WriteLine($"Arrays are not identical.");
		break;
	}
	if (i == firstArr.Length - 1)
	{
		Console.WriteLine("Arrays are identical.");
	}
}