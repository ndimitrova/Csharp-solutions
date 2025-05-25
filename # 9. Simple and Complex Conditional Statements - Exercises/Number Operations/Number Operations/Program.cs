double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
char sign = char.Parse(Console.ReadLine());   

if (sign == '+')
{
    Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {(firstNumber + secondNumber):f2}");
}
else if (sign == '-')
{
    Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {(firstNumber - secondNumber):f2}");
}
else if (sign == '*')
{
    Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {(firstNumber * secondNumber):f2}");
}
else if (sign == '/')
{
    Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {(firstNumber / secondNumber):f2}");
}
