int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int product = firstNumber * secondNumber * thirdNumber; 

if (product == 0)
{
    Console.WriteLine("zero");
} 
else if (product > 0)
{
    Console.WriteLine("positive");
}
else
{
    Console.WriteLine("negative");
}
