using System;

// this file has the base doughnut class and all the toppings
// basically the building blocks for making any doughnut

// topping interface - any topping class needs to have a cost
public interface Topping
{
    double cost { get; }
}

// the plain doughnut is the base of everything
// all other doughnuts come from this one
public class PlainDoughnut
{
    // child classes need access to these so they can add toppings
    protected Topping[] toppings = new Topping[5];
    protected int tCount;

    // only this class needs to touch the cost directly
    private double cost;

    public PlainDoughnut()
    {
        Console.WriteLine("PlainDoughnut");
        cost = 20.00; // every doughnut starts at 20 pesos
        tCount = 0;
    }

    // adds up the base cost plus whatever toppings were added
    public double ComputeCost()
    {
        foreach (Topping t in toppings)
        {
            // some slots in the array might be empty so we skip those
            if (t != null) cost += t.cost;
        }
        return cost;
    }
}

// choco glaze topping - adds 5 pesos
public class ChocoGlaze : Topping
{
    public ChocoGlaze()
    {
        Console.WriteLine("...ChocoGlaze");
    }

    public double cost
    {
        get { return 5.00; }
    }
}

// strawberry glaze topping - adds 3 pesos
public class StrawberryGlaze : Topping
{
    public StrawberryGlaze()
    {
        Console.WriteLine("...StrawberryGlaze");
    }

    public double cost
    {
        get { return 3.00; }
    }
}

// candy sprinkles topping - adds 1.50 pesos
public class CandySprinkles : Topping
{
    public CandySprinkles()
    {
        Console.WriteLine("...CandySprinkles");
    }

    public double cost
    {
        get { return 1.50; }
    }
}

// peanut crunch topping - adds 1.75 pesos
public class PeanutCrunch : Topping
{
    public PeanutCrunch()
    {
        Console.WriteLine("...PeanutCrunch");
    }

    public double cost
    {
        get { return 1.75; }
    }
}

// cinnamon dust topping - adds 1.25 pesos
public class CinnamonDust : Topping
{
    public CinnamonDust()
    {
        Console.WriteLine("...CinnamonDust");
    }

    public double cost
    {
        get { return 1.25; }
    }
}