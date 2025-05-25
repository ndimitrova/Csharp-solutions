using System.Collections.Generic;

string type = Console.ReadLine();

if (type == "int")
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());

    GreaterTnanTwoInts(firstNumber, secondNumber);
}
else if (type == "char")
{
    char firstSymbol = char.Parse(Console.ReadLine());
    char secondSymbol = char.Parse(Console.ReadLine());
    GreaterThatTWoChars(firstSymbol, secondSymbol);
}
else if(type == "string")
{
    string firstText = Console.ReadLine();
    string secondText = Console.ReadLine();
    GreaterThatTWoStrings(firstText, secondText);
}


static void GreaterTnanTwoInts(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else 
    { 
        Console.WriteLine(secondNumber);
    }
}
static void GreaterThatTWoChars(char firstChar, char secondChar)
{
    if (firstChar > secondChar)
    {
        Console.WriteLine(firstChar);
    }
    else 
    { 
        Console.WriteLine(secondChar);  
    }
}

static void GreaterThatTWoStrings(string firstText, string secondText)
{
    int comparison = firstText.CompareTo(secondText);

    if (comparison > 0)
    {
        Console.WriteLine(firstText);
    }
    else
    {
        Console.WriteLine(secondText);
    }
}