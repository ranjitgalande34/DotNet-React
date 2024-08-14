using System;
using System.Collections.Generic;

public class Pizza
{
    private string size;
    private int cheeseToppings;
    private int pepperoniToppings;
    private int hamToppings;

    public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
    {
        this.size = size;
        this.cheeseToppings = cheeseToppings;
        this.pepperoniToppings = pepperoniToppings;
        this.hamToppings = hamToppings;
    }

   
    public string Size
    {
        get { return size; }
        set { size = value; }
    }

    public int CheeseToppings
    {
        get { return cheeseToppings; }
        set { cheeseToppings = value; }
    }

    public int PepperoniToppings
    {
        get { return pepperoniToppings; }
        set { pepperoniToppings = value; }
    }

    public int HamToppings
    {
        get { return hamToppings; }
        set { hamToppings = value; }
    }

    public double CalcCost()
    {
        double baseCost = 0;

        switch (size.ToLower())
        {
            case "small":
                baseCost = 10;
                break;
            case "medium":
                baseCost = 12;
                break;
            case "large":
                baseCost = 14;
                break;
            default:
                throw new ArgumentException("Invalid size");
        }

        double totalCost = baseCost + (2 * (cheeseToppings + pepperoniToppings + hamToppings));
        return totalCost;
    }

    public string GetDescription()
    {
        return $"Size: {size}, Cheese Toppings: {cheeseToppings}, Pepperoni Toppings: {pepperoniToppings}, Ham Toppings: {hamToppings}, Total Cost: ${CalcCost()}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Pizza> pizzas = new List<Pizza>();

        pizzas.Add(new Pizza("small", 2, 1, 1));
        pizzas.Add(new Pizza("medium", 1, 2, 1));
        pizzas.Add(new Pizza("large", 3, 3, 3));

        //while (true)
        //{
        //    Console.WriteLine("Your Want to customise ur pizza ?? y n");
        //    char ch=char.Parse(Console.ReadLine());

        //    if (ch == 'y') {
        //        Console.WriteLine("choose size 1.Largest 2.double large");
        //        string size = Console.ReadLine();

        //            }

        //}

        foreach (Pizza pizza in pizzas)
        {
            Console.WriteLine(pizza.GetDescription());
        }
    }
}


