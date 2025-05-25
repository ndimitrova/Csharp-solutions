List<int> items = Console.ReadLine()
.Split(' ').Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] currentCommand = command.Split();

    if (currentCommand[0] == "Delete")
    {
        int elementForRemoving = int.Parse(currentCommand[1]);

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == elementForRemoving)
            {
                items.Remove(items[i]);
            }
        }
    }
    else if (currentCommand[0] == "Insert")
    {
        int elementForInserting = int.Parse(currentCommand[1]);
        int position = int.Parse(currentCommand[2]);

        items.Insert(position, elementForInserting);
    }

    command = Console.ReadLine();
}

if (command == "end")
{
    Console.WriteLine(string.Join(" ", items));
}
