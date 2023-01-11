// Override Method without Virtual and Override Keywords
class Person
{
    public virtual void Greet()
    {
        Console.WriteLine("Hi! I am a person.");
    }
}

class Employee : Person
{
    public override void Greet()
    {
        Console.WriteLine("Hello! I am an employee.");
    }
}

// Method Hiding
class Program
{
    public static void Main()
    {
        Person p1 = new Person();
        p1.Greet(); // I am a person!

        Person p2 = new Employee();
        P2.Greet(); //I am a person!

        Employee emp = new Employee();
        emp.Greet(); //I am an employee!
    }
}

// new Keyword
class Person
{
    public void Greet()
    {
        Console.WriteLine("I am a person!");
    }
}

class Employee : Person
{
    public new void Greet()
    {
        Console.WriteLine("I am the Manager!");
    }
}
