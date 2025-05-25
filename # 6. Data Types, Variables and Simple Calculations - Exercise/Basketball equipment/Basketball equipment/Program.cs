int annualFee = int.Parse(Console.ReadLine());
double sneakersPrice = 0.60 * annualFee;
double uniform = 0.80 * sneakersPrice;
double ball = 0.25 * uniform;
double accessories = 0.20 * ball;

double total = annualFee + sneakersPrice + uniform + accessories + ball;

Console.WriteLine(total);
