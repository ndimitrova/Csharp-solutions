int[] arr = Console.ReadLine().Split(" ")
.Select(int.Parse).ToArray();

int sum = arr.Sum();

Console.WriteLine(sum);


