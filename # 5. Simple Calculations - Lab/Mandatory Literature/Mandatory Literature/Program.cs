int numeberOfPages = int.Parse(Console.ReadLine());
int pagesFor1Hour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());   

int hoursPerDay = (numeberOfPages / pagesFor1Hour) / numberOfDays;

Console.WriteLine(hoursPerDay);
