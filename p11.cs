// Liskov Substitution Principle
// Let φ(x) be a property provable about objects x of type T. Then φ(y) should also be true for objects y of type S where S is a subtype of T.

// Subtypes must be substitutable for their base type

// Rectangle
public class Rectangle
{
    public virtual int Height {get;set;}
    public virtual int Width {get;set;}
}

// Square
class Square:Rectangle
{
    private int _height;
    private int _width;

    public override int Height
    {
        get{return _height;}
        set{
            _height=value;
            _width=value;
        }
    }

    public override int Width
    {
        get{return _width;}
        set
        {
            _width=value;
            _height=value;
        }
    }
}

// area of a rectangle
public class AreaCalculator
{
    public static int CalculateArea(Rectangle r)
    {
        return r.Height*r.Width;
    }
}
// LSP Violation
Rectangle sqr1 = new Square();
sqr1.Height = 6;
sqr1.Width = 8;
		
Console.WriteLine(AreaCalculator.CalculateArea(sqr1)); //returns 64
		
Rectangle sqr2 = new Square();
sqr2.Height = 8;
sqr2.Width = 6;
		
Console.WriteLine(AreaCalculator.CalculateArea(sqr2)); //returns 36

