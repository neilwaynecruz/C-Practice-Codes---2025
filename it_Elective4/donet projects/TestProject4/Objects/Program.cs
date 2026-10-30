// var rex = new Dog { Name = "Rex" };

// rex.Bark(); // Rex: Woof!


// public class Dog

// {

// public string Name;

// public void Bark() =>

// Console.WriteLine($"{Name}: Woof!");

// }




using System;
using System.Security.Cryptography.X509Certificates;

// public class Person
// {
//     private string _name = "";
//     private int _age; 

//     public string Name
//     {
//         get => _name;
//         set => _name = value.Trim();
//     }

//     public int Age 
//     { 
//         get => _age; 
//         set => _age = value; 
//       }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Person person = new Person();

//         person.Name = "Neil Wayne Cruz";
//         person.Age = 20;

//         Console.WriteLine(person.Name);
//         Console.WriteLine(person.Age);
//     }
// }

// // Constructor
// public class Point
// {

// }



// public class Point
// {
//     public int X { get; set; }
//     public int Y { get; set; }

//     public Point(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }

//     public Point() : this(0, 0) { }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Point point1 = new Point(5, 10);
//         Console.WriteLine($"Point 1: X = {point1.X}, Y = {point1.Y}");

//         Point point2 = new Point();
//         Console.WriteLine($"Point 2: X = {point2.X}, Y = {point2.Y}");
//     }
// }

//Contructor
// public class Calc
// {
//     public int A {get; set;}
//     public int B {get; set;}

//     public  Calc(int num1, int num2)
//     {
//         A = num1;
//         B = num2;
//     }


//     // addition of 2 numbers
//     public int Add()
//     {
//             return A + B;
//     }

//     // subtraction of 2 numbers
//     public int subtract()
//     {
//         return A - B;
//     }

//     //Multiplication of 2 numbers
//     public int multiply()
//     {
//         return A * B;
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Calc num1 = new Calc(5, 10);

//         Console.WriteLine($"Sum of {num1.A} and {num1.B} is: ");

//         Console.WriteLine(num1.Add());
//         Console.WriteLine(num1.subtract());
//     }
// }


public class Circle
{
    public decimal Radius { get; set; }

    public Circle(decimal radius)
    {
        Radius = radius;
    }

    public decimal CalculateArea()
    {
        return (decimal)Math.PI * Radius * Radius;
    }

    
}

public class Rectangle
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }

    public Rectangle(decimal width, decimal height)
    {
        Width = width;
        Height = height;
    }

    public decimal CalculateArea()
    {
        return Width * Height;
    }
}


public class Operations
{
    public decimal CircleArea { get; set; }
    public decimal RectangleArea { get; set; }

    public Operations(decimal circleArea, decimal rectangleArea)
    {
        CircleArea = circleArea;
        RectangleArea = rectangleArea;
    }

    //Addition
    public decimal Addition()
    {
        return CircleArea + RectangleArea;
    }

    //Subtraction
    public decimal Subtraction()
    {
        return CircleArea - RectangleArea;
    }

    //Multiplication
    public decimal Multiplication()
    {
        return CircleArea * RectangleArea;
    }

    //Division
    public decimal Division()
    {
        return CircleArea / RectangleArea;
    }

    //Operation Selection
    public void PerformOperation()
    {
        Console.WriteLine($"Sum(+) of Circle Area and Rectangle Area: {Addition():N2}");
        Console.WriteLine($"Difference(-) of Circle Area and Rectangle Area: {Subtraction():N2}");
        Console.WriteLine($"Product(*) of Circle Area and Rectangle Area: {Multiplication():N2}");

        if (RectangleArea != 0)
        {
            Console.WriteLine($"Quotient(/) of Circle Area and Rectangle Area: {Division():N2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}


public class Program
{
    public static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        decimal circleInput = decimal.TryParse(Console.ReadLine(), out decimal parsedInput) ? parsedInput : 0m;
        Console.Write("Enter the width of the rectangle: ");
        decimal rectangleWidthInput = decimal.TryParse(Console.ReadLine(), out decimal parsedWidth) ? parsedWidth : 0m;
        Console. Write("Enter the height of the rectangle: ");
        decimal rectangleHeightInput = decimal.TryParse(Console.ReadLine(), out decimal parsedHeight) ? parsedHeight : 0m;
        // Console.Write("What Operation do you want to perform? [+, -, *, /]:  ");
        // string? operationInput = Console.ReadLine();
        // string operation = String.IsNullOrWhiteSpace(operationInput) ? "+" : operationInput;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("====================Input Values=============================");
        Console.WriteLine($"Circle Radius: {circleInput:N2} ");
        Console.WriteLine($"Rectangle Width: {rectangleWidthInput:N2}");
        Console.WriteLine($"Rectangle Height: {rectangleHeightInput:N2}");
        // Console.WriteLine($"Operation: {operation}");
        Console.WriteLine("==============================================================");

        //instance
        Circle circle = new Circle(circleInput);
        Rectangle rectangle = new Rectangle(rectangleWidthInput, rectangleHeightInput);

        Console.WriteLine();
        
        //Result
        Console.WriteLine("====================Area Calculation=========================");
        Console.WriteLine($"Circle Area: {circle.CalculateArea():N2}");
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():N2}");
        Console.WriteLine("==============================================================");
        Console.WriteLine();

        Operations operations = new Operations(circle.CalculateArea(), rectangle.CalculateArea());

        //Operation Results
        Console.WriteLine("====================Operation Result=========================");
        operations.PerformOperation();
        Console.WriteLine("==============================================================");
        Console.WriteLine();
    }
}