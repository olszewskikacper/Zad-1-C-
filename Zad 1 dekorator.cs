using System;
using System.Collections.Generic;

//Wzorzec projektowy to Dekorator

// Abstrakcyjna klasa Beverage
abstract class Beverage
{
    public abstract string GetDescription();
    public abstract double GetCost();
}

// Konkretne klasy kaw
class Espresso : Beverage
{
    public override string GetDescription() => "Espresso";
    public override double GetCost() => 1.99;
}

class Cappuccino : Beverage
{
    public override string GetDescription() => "Cappuccino";
    public override double GetCost() => 2.49;
}

class Latte : Beverage
{
    public override string GetDescription() => "Latte";
    public override double GetCost() => 2.99;
}

// Dekorator bazowy
abstract class AddonDecorator : Beverage
{
    protected Beverage beverage;
    public AddonDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
}

// Dodatki
class Milk : AddonDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }
    public override string GetDescription() => beverage.GetDescription() + ", Milk";
    public override double GetCost() => beverage.GetCost() + 0.20;
}

class Syrup : AddonDecorator
{
    public Syrup(Beverage beverage) : base(beverage) { }
    public override string GetDescription() => beverage.GetDescription() + ", Syrup";
    public override double GetCost() => beverage.GetCost() + 0.30;
}

class WhippedCream : AddonDecorator
{
    public WhippedCream(Beverage beverage) : base(beverage) { }
    public override string GetDescription() => beverage.GetDescription() + ", Whipped Cream";
    public override double GetCost() => beverage.GetCost() + 0.70;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wybierz bazę kawy:");
        Console.WriteLine("1. Espresso");
        Console.WriteLine("2. Cappuccino");
        Console.WriteLine("3. Latte");
        Console.Write("Twój wybór: ");
        int choice = int.Parse(Console.ReadLine());

        Beverage beverage = choice switch
        {
            1 => new Espresso(),
            2 => new Cappuccino(),
            3 => new Latte(),
            _ => new Espresso()
        };

        Console.WriteLine("Dodaj dodatki (wpisz: milk, syrup, whipped, zakończ enterem):");
        while (true)
        {
            string input = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(input)) break;

            beverage = input switch
            {
                "milk" => new Milk(beverage),
                "syrup" => new Syrup(beverage),
                "whipped" => new WhippedCream(beverage),
                _ => beverage
            };
        }

        Console.WriteLine($"{beverage.GetDescription()}: ${beverage.GetCost():0.00}");
    }
}
