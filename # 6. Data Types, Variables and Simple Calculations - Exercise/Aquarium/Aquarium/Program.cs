int length = int.Parse(Console.ReadLine()); 
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int volume = length * width * height;
double volumeInLiters = volume / 1000.0;
double requiredLiters = volumeInLiters * (1 - (percentage / 100));

Console.WriteLine($"{requiredLiters:f2}");


