using System;

class App
{
    static void Main(string[] args)
    {
        ItemShop shop = new();
        shop.FillShelves();
        shop.Enumerate();
    }
}