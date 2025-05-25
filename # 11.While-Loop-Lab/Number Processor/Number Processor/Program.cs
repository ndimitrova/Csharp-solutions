using System.Data;

int number = int.Parse(Console.ReadLine());

string commnand = Console.ReadLine();

while (commnand != "End")
{
    if (commnand == "Inc")
    {
        number += 1;
    }
    else if(commnand == "Dec")
    {
        number -= 1;
    }
    commnand = Console.ReadLine();
}

if (commnand == "End")
{
    Console.WriteLine(number);
}
