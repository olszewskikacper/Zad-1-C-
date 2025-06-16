using System;
public class HealingPotion : Potion
{
    public override void Drink() => Console.WriteLine("You feel healed!");
}