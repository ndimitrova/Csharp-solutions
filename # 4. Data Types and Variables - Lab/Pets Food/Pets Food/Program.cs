int countPackagesDogFood = int.Parse(Console.ReadLine());
int countPackagesCatFood = int.Parse(Console.ReadLine());

double expense = (countPackagesCatFood * 4) + (countPackagesDogFood * 2.50);

Console.WriteLine($"{expense:f2} lv.");

