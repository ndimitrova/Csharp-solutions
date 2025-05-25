double depositedAmount = double.Parse(Console.ReadLine());
int termOfTheDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double amount = depositedAmount + termOfTheDeposit * depositedAmount * (annualInterestRate / 100) / 12;

Console.WriteLine($"{amount:f2}");
