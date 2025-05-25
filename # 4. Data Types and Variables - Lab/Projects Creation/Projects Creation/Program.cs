string architecture = Console.ReadLine();

int countOfProjects = int.Parse(Console.ReadLine());

int hoursCount = countOfProjects * 3;

Console.WriteLine($"The architect {architecture} will need {hoursCount} hours to complete {countOfProjects} project/s.");
