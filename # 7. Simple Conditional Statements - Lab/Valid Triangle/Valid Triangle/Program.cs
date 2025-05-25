int firstSide = int.Parse(Console.ReadLine());
int secondSide = int.Parse(Console.ReadLine());
int thirdSide = int.Parse(Console.ReadLine());

if ((firstSide < secondSide + thirdSide) && (secondSide < firstSide + thirdSide) && (thirdSide < firstSide + secondSide))
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");    
}
