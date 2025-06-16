using System;
using System.Collections.Generic;

public class PotionFactory
{
    private Dictionary<PotionType, Potion> potions = new();

    public Potion CreatePotion(PotionType type)
    {
        if (!potions.ContainsKey(type))
        {
            Potion potion = type switch
            {
                PotionType.ELIXIROFSORCERY => new ElixirOfSorcery(),
                PotionType.CORRUPTION => new CorruptionPotion(),
                PotionType.HEALING => new HealingPotion(),
                PotionType.MANA => new ManaPotion(),
                PotionType.ELIXIROFWRATH => new ElixirOfWrath(),
                PotionType.ELIXIROFIRON => new ElixirOfIron(),
                _ => throw new ArgumentException("Unknown potion type")
            };
            potions[type] = potion;
        }

        return potions[type];
    }
}