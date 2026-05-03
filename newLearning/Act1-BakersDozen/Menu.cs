using System;

// this file has the specialty doughnuts
// each one inherits from a parent and just adds its own topping on top

// plain choco inherits from plain doughnut then puts choco glaze on it
public class PlainChoco : PlainDoughnut
{
    public PlainChoco()
    {
        Console.WriteLine("PlainChoco");
        Console.WriteLine("Toppings: ");
        toppings[tCount++] = new ChocoGlaze();
    }
}

// plain strawberry is just a plain doughnut with strawberry glaze
public class PlainStrawberry : PlainDoughnut
{
    public PlainStrawberry()
    {
        Console.WriteLine("PlainStrawberry");
        Console.WriteLine("Toppings: ");
        toppings[tCount++] = new StrawberryGlaze();
    }
}

// choco crunch inherits from plain choco so it already has choco glaze
// then we just add peanut crunch on top of that
public class ChocoCrunch : PlainChoco
{
    public ChocoCrunch()
    {
        Console.WriteLine("ChocoCrunch");
        Console.WriteLine("Toppings: ");
        toppings[tCount++] = new PeanutCrunch();
    }
}

// strawberry sprinkles inherits from plain strawberry
// so it already has the strawberry glaze, we just add candy sprinkles
public class StrawberrySprinkles : PlainStrawberry
{
    public StrawberrySprinkles()
    {
        Console.WriteLine("StrawberrySprinkles");
        Console.WriteLine("Toppings: ");
        toppings[tCount++] = new CandySprinkles();
    }
}

// cinnamon crunch comes from plain doughnut
// then gets two toppings: cinnamon dust and peanut crunch
public class CinnamonCrunch : PlainDoughnut
{
    public CinnamonCrunch()
    {
        Console.WriteLine("CinnamonCrunch");
        Console.WriteLine("Toppings: ");
        toppings[tCount++] = new CinnamonDust();
        toppings[tCount++] = new PeanutCrunch();
    }
}