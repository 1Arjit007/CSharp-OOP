// Class Inheritance in C#
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName(){ 
        return FirstName + " " + LastName;
    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public string CompanyName { get; set; }
    
}

// Inherited Members
Employee emp = new Employee();
emp.FirstName = "Steve";
emp.LastName = "Jobs";
emp.EmployeeId = 1;
emp.CompanyName = "Apple";

var fullname = emp.GetFullName(); //Steve Jobs 

// Inheritance of Public Members

class Person
{
    public string FirstName { get; set; } // can be inherited
}

class Employee : Person
{
        
}

Employee emp = new Employee();
emp.FirstName = "Bill"; // valid

// Inheritance of Private Members
class Person
{
    private string FirstName { get; set; }  // cannot be inherited
}

class Employee : Person
{
   
}

Employee emp = new Employee();
emp.FirstName; // Compile-time error

// Inheritance of Protected Members
class Person
{
    protected string FirstName { get; set; }
}

class Employee : Person
{
    public int GetName()
    {
        return this.FirstName;// valid
    }
}

Employee emp = new Employee();
emp.GetName();// valid
emp.FirstName; // Compile-time error. 

// Inheritance of Internal Members
class Person
{
    internal string FirstName { get; set; } 
}

class Employee : Person
{
        
}

Employee emp = new Employee();
emp.Name= "Steve";// valid

// Constructors in Inheritance

class Person
{
    public Person()
    {
	    Console.WriteLine("Person Constructor");
	}
}

class Employee : Person
{
    public Employee()
    {
	    Console.WriteLine("Employee Constructor");
	}   
}

Employee emp = new Employee();

// base Keyword
class Person
{
    public Person()
    {
	    Console.WriteLine("Person Constructor");
	}

    public Person(string val)
    {
	    Console.WriteLine(val);
	}
}

class Employee : Person
{
    public Employee() : base("Parameterized constructor of base class")
    {
	    Console.WriteLine("Employee Constructor");
	}   
}

Employee emp = new Employee();

// Instance variable	Instance Type	Instance Members of
// Base type	        Base type	    Base type
// Base type	        Derived type	Base type
// Derived type	    Derived type	Base and derived type

// Object Creation
class Person
{
    public int Id { get; set; }  
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
}

class Employee : Person
{
    public string CompanyName { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
	public static void Main()
	{
        Person per1 = new Person();
        per1.Id = 1; //valid
        per1.FirstName = "James"; //valid
        per1.LastName = "Bond"; //valid

        //per1.CompanyName; // not supported
        //per1.Salary;  // not supported

        Person per2 = new Employee();
        per2.Id = 2; //valid
        per2.FirstName = "Bill"; //valid
        per2.LastName = "Gates"; //valid

        //per2.CompanyName; // not supported
        //per2.Salary;  // not supported
 
        Employee emp = new Employee();
        emp.Id = 1; //valid
        emp.FirstName = "Steve";//valid
        emp.LastName = "Jobs";//valid
        emp.CompanyName = "XYZ"; //valid
        emp.Salary = 10000; //valid 

        //invalid, can't assign base type to derived type
        //Employee emp = new Person();
     }
}

// Type Conversion From Base to Derived

public static void Display(Employee emp){
    Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}");
}

public static void Main()
{
    Person per = new Employee();
    per.FirstName="Steve";
    per.LastName="Jobs";

    //Cannot convert from Person to Employee implicitly
    Display(per);//error 

    Display(per as Employee);//valid, explicit conversion

    Employee emp = new Employee();
    emp.FirstName = "Abdul";
    emp.LastName = "Kalam";
    Display(emp);//valid
}    

// Types of Inheritance
// Single Inheritance
// Multi-level Inheritance
// Hierarchical Inheritance
// Hybrid Inheritance
// Multiple Inheritance

// Important Points
// In C#, three types can participate in inheritance: Class, Struct, and Interface.
// A class can inherit a single class only. It cannot inherit from multiple classes.
// A class cannot inherit from a struct.
// A class can inherit (implement) one or more interfaces.
// A Struct can inherit from one or more interfaces. However, it cannot inherit from another struct or class.
// An interface can inherit from one or more interfaces but cannot inherit from a class or a struct.
// Constructors or destructors cannot be inherited.

