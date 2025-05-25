int n = int.Parse(Console.ReadLine());
int numbersDivisibleBy2 = 0;
int numbersDivisibleBy3 = 0;
int numbersDivisibleBy4 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine()); 

        if (number % 2 == 0)
        {
            numbersDivisibleBy2++;
        }
        if (number % 3 == 0) 
        { 
            numbersDivisibleBy3++;
        }
        if (number % 4 == 0) 
        { 
            numbersDivisibleBy4++; 
        }   
}
double percentDivisibleBy2 = (((double)numbersDivisibleBy2 / n) * 100);
double percentDivisibleBy3 = (((double)numbersDivisibleBy3 / n) * 100);
double percentDivisibleBy4 = (((double)numbersDivisibleBy4 / n) * 100);

Console.WriteLine($"{percentDivisibleBy2:f2}%");
Console.WriteLine($"{percentDivisibleBy3:f2}%");
Console.WriteLine($"{percentDivisibleBy4:f2}%");
