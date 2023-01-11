// Method Overriding
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

// Calls to Overrided Method
Person p1 = new Person();
p1.Greet();

Person p2 = new Employee();
p2.Greet();

Employee emp = new Employee();
emp.Greet();

// output
// Hi! I am a person.
// Hello! I am an employee.
// Hello! I am an employee.

// Runtime Polymorphism
class Program
{
    public static void Display(Person p){ 
        p.Greet();
    }

    public static void Main()
    {
        Person p1 = new Person();
        Display(p1);
            
        Person p2 = new Employee();
        Display(p2);
            
        Employee emp = new Employee();
        Display(emp);
    }
}

// Rules for Overriding:
// A method, property, indexer, or event can be overridden in the derived class.
// Static methods cannot be overridden.
// Must use virtual keyword in the base class methods to indicate that the methods can be overridden.
// Must use the override keyword in the derived class to override the base class method.