int n = int.Parse(Console.ReadLine());
int sum = 0;    

for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());
    
    if (letter == 'a')
    {
        sum += 1;
    }
    else if (letter == 'e')
    {
        sum += 2;
    }
    else if (letter == 'i')
    {
        sum += 3;
    }
    else if (letter == 'o')
    {
        sum += 4;
    }
    else if (letter == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);
