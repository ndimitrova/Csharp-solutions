int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine()); 

CalculateRectangleArea(width, length);

static void CalculateRectangleArea(int width, int height)
{
    int rectangleArea = width * height; 

    Console.WriteLine(rectangleArea);
}
