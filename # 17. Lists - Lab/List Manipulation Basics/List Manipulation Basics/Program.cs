List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] currentCommand = command.Split();

    if (currentCommand[0] == "Add")
    {
        int number = int.Parse(currentCommand[1]);
        numbers.Add(number);
    }
    else if (currentCommand[0] == "Remove")
    {
        int number = int.Parse(currentCommand[1]);
        numbers.Remove(number);
    }
    else if (currentCommand[0] == "RemoveAt")
    {
        int index = int.Parse(currentCommand[1]);
        numbers.RemoveAt(index);
    }
    else if (currentCommand[0] == "Insert")
    {
        int number = int.Parse(currentCommand[1]);
        int index = int.Parse(currentCommand[2]);
        numbers.Insert(index, number);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));

