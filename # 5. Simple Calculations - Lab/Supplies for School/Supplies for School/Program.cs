int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
int numberOfPacketsOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner  = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalAmount = (((numberOfPackagesOfPens * 5.80) + (numberOfPacketsOfMarkers * 7.20) + (litersOfBoardCleaner * 1.20))) * ((100 - discount) / 100.0);

Console.WriteLine(totalAmount);

