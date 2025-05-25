int[] arr = Console.ReadLine().Split(" ")
.Select(int.Parse).ToArray();

int sumOfEvenNumbers = 0;
int sumOfOddNumbers = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        sumOfEvenNumbers += arr[i];
    }
    else
    {
        sumOfOddNumbers += arr[i];
    }
}

Console.WriteLine($"{sumOfEvenNumbers - sumOfOddNumbers}");
