List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] currentCommand = command.Split();

    if (currentCommand[0] == "Contains")
    {
        int number = int.Parse(currentCommand[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else 
        { 
            Console.WriteLine("No such number"); 
        }
    }
    else if (currentCommand[0] == "PrintEven")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();
    }
    else if (currentCommand[0] == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();
    }
    
    else if (currentCommand[0] == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (currentCommand[0] == "Filter")
    {
        string condition = currentCommand[1];
        int number = int.Parse(currentCommand[2]);

        if (condition == "<")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= number)
                {
                    numbers[i] = 0;
                }
            }
        }
        else if(condition == ">")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= number)
                {
                    numbers[i] = 0;
                }
            }
        }
        else if (condition == ">=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < number)
                {
                    numbers[i] = 0;
                }
            }
        }
        else if (condition == "<=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > number)
                {
                    numbers[i] = 0;
                }
            }
        }
    }

    command = Console.ReadLine();
}

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] != 0)
    {
        Console.Write($"{numbers[i]} ");
    }
}
Console.WriteLine();



