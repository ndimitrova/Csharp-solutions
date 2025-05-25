int number = int.Parse(Console.ReadLine());
int numberInTheBeggining = number;
bool isSpecial = false;

while (true)
{
    int digit = number % 10;
    number = number / 10;   

    if (numberInTheBeggining % digit == 0)
    {
        isSpecial = true;
    }
    else
    {
        isSpecial = false;
        break;  
    }

    if (number <= 0) 
    { 
        break; 
    } 
}
if (isSpecial == true)
{
    Console.WriteLine($"{numberInTheBeggining} is special");
}
else
{
    Console.WriteLine($"{numberInTheBeggining} is not special");
}