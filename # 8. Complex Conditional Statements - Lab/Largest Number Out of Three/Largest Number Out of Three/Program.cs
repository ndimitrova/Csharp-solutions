int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
	if (firstNumber > thirdNumber)
	{
        Console.WriteLine(firstNumber);
    }
    else 
    { 
        Console.WriteLine(thirdNumber); 
    }
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine(secondNumber);
    }
    else 
    { 
        Console.WriteLine(thirdNumber); 
    }
}
