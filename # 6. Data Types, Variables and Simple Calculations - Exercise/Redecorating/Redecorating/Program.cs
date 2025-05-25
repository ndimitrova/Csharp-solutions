int nylon = int.Parse(Console.ReadLine());  
int paint =  int.Parse(Console.ReadLine()); 
int thinner  = int.Parse(Console.ReadLine());
int hours  = int.Parse(Console.ReadLine());

double sumForMatterials = (nylon * 1.50) + ((paint * 14.50) * 1.10) + (thinner * 5) + 3.40;
double sumForWork = hours * sumForMatterials * 0.30;
double allCosts = sumForWork + sumForMatterials;

Console.WriteLine(allCosts);