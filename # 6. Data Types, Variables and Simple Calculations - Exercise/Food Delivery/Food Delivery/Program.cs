int numberOfChickenMenus = int.Parse(Console.ReadLine());
int numberOfMenusWithFish = int.Parse(Console.ReadLine());  
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

double bill = numberOfChickenMenus * 10.35 + numberOfMenusWithFish * 12.40 + numberOfVegetarianMenus * 8.15;
double dessertPrice = 0.20 * bill;

double totalBill = bill + dessertPrice + 2.50;
Console.WriteLine(totalBill);

