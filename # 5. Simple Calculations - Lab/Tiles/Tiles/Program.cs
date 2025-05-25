double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight;
double bathroomAreaWithSurplus = bathroomArea * 1.10;
double tileArea = tileWidth * tileHeight;
double tilesNeeded = bathroomAreaWithSurplus / tileArea;

Console.WriteLine($"{Math.Round(tilesNeeded)}");
