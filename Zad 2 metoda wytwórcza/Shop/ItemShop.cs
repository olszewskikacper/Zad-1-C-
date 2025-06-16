using System;
using System.Collections.Generic;

public class ItemShop
{
    private List<Potion> topShelf = new();
    private List<Potion> bottomShelf = new();

    public void FillShelves()
    {
        PotionFactory factory = new();

        topShelf.Add(factory.CreatePotion(PotionType.ELIXIROFSORCERY));
        topShelf.Add(factory.CreatePotion(PotionType.ELIXIROFSORCERY));
        topShelf.Add(factory.CreatePotion(PotionType.ELIXIROFWRATH));
        bottomShelf.Add(factory.CreatePotion(PotionType.HEALING));
        bottomShelf.Add(factory.CreatePotion(PotionType.HEALING));
        bottomShelf.Add(factory.CreatePotion(PotionType.MANA));
    }

    public List<Potion> GetTopShelf() => topShelf;
    public List<Potion> GetBottomShelf() => bottomShelf;

    public void Enumerate()
    {
        Console.WriteLine("Top Shelf:");
        foreach (var potion in topShelf)
            potion.Drink();

        Console.WriteLine("Bottom Shelf:");
        foreach (var potion in bottomShelf)
            potion.Drink();
    }
}