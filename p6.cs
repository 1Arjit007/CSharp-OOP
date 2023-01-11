// polymorphism can be achieved in two ways:
// Compile-time Polymorphism
// Run-time Polymorphism

// Compile-time Polymorphism (Method Overloading)

// Rules for Method Overloading
// Method names should be the same but method signatures must be different. Either the number of parameters, type of parameters, or order of parameters must be different.
// The return type of the methods does not play any role in the method overloading.
// Optional Parameters take precedence over implicit type conversion when deciding which method definition to bind.

// Method Overloading Method Overloading
class ConsolePrinter
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public void Print(string str1, string str2)
    {
        Console.WriteLine($"{str1}, {str2}");
    }

    public void Print(string str1, string str2, string str3)
    {
        Console.WriteLine($"{str1}, {str2}, {str3}");
    }
}

// Method Overloading
class ConsolePrinter
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public void Print(int a)
    {
        Console.WriteLine($"Integer {a}");
    }
}

// Method Overloading
class ConsolePrinter
{
    public void Print(int a, string str)
    {
        Console.WriteLine($"{a}, {str}");
    }

    public void Print(string str, int a)
    {
        Console.WriteLine($"{a}, {str}");
    }
}

// Invalid Method Overloading
// class ConsolePrinter
// {
//     public void Print(int a, string str)
//     {
//         Console.WriteLine($"{a}, {str}");
//     }

//     public int Print(int a, string str)
//     {
//         Console.WriteLine($"{a}, {str}");
//         return 0;
//     }
// }

// Method Overloading
class ConsolePrinter
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }

    public void Print(string str1, string str2)
    {
        Console.WriteLine($"{str1}, {str2}");
    }

    public void Print(string str1, string str2, string str3)
    {
        Console.WriteLine($"{str1}, {str2}, {str3}");
    }

    public void Print(int a)
    {
        Console.WriteLine($"Integer {a}");
    }

    public void Print(int a, string str)
    {
        Console.WriteLine($"{a}, {str}");
    }

    public void Print(string str, int a)
    {
        Console.WriteLine($"{a}, {str}");
    }
}

// Method Overloading
public static void Main()
{
	ConsolePrinter cp = new ConsolePrinter();
	cp.Print("Hello World!");
	cp.Print(1, "John");
}