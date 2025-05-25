double number = double.Parse(Console.ReadLine());
double power = double.Parse(Console.ReadLine());  

PrintNumberPower(number, power);

static void PrintNumberPower(double number, double power)
{
    double numberPower = Math.Pow(number, power);
    Console.WriteLine(numberPower);
}
