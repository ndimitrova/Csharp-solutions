string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

PrintTotalPrice(product, quantity);

static void PrintTotalPrice(string product, int quantity)
{
    double price = 0;   

    if (product == "coffee")
    {
        price = 1.50;
    }
    else if (product == "water")
    {
        price = 1.00;
    }
    else if(product == "coke")
    {
        price = 1.40;
    }
    else if (product == "snacks")
    {
        price = 2.00;
    }

    Console.WriteLine($"{(price * quantity):f2}");
}
