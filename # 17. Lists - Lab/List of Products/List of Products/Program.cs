int countOfProducts = int.Parse(Console.ReadLine());

List <string> product = new List<string>();

for (int i = 0; i < countOfProducts; i++)
{
    string productName = Console.ReadLine();
    product.Add(productName);
}
product.Sort();

for (int i = 0; i < countOfProducts; i++)
{
    Console.WriteLine($"{i + 1}.{product[i]}");
}
