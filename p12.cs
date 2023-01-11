// Open-Closed Principle
// Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.

// Open/Closed principle can be applied using the following approaches:

// Using Function Parameters
// Using Extension methods
// Using Classes, Abstract class, or Interface-based Inheritance
// Generics
// Composition and Dependency Injection

// Logger Class
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void Info(string message)
    {
        Console.WriteLine($"Info: {message}");
    }

    public void Debug(string message)
    {
        Console.WriteLine($"Debug: {message}");
    }
}

// Virtual Methods
public class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine(message);
    }

    public virtual void Info(string message)
    {
        Console.WriteLine($"Info: {message}");
    }

    public virtual void Debug(string message)
    {
        Console.WriteLine($"Debug: {message}");
    }
}

// Modify Class by Overriding Methods
public class NewLogger : Logger
{
    public override void Debug(string message)
    {
        Console.WriteLine($"Dev Debug -> {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        logger.Debug("Testing debug");

        Logger newlogger = new NewLogger();
        newlogger.Debug("Testing debug ");
    }
}

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }

    public void Subscribe(Student std)
    {
        Logger.Log("Starting Subscribe()");

        //apply business rules based on the course type live, online, offline, if any
        if (this.Type == "online")
        {
            //subscribe to online course
        }
        else if (this.Type == "offline")
        {
            //subscribe to offline course
        }

        // payment processing
        PaymentManager.ProcessPayment();

        //create CourseRepository class to save student and course into StudentCourse table

        // send confirmation email
        EmailManager.SendEmail();

        Logger.Log("End Subscribe()");
    }
}

// A Class follows OCP
public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public abstract void Subscribe(Student std);
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        //write code to subscribe to an online course
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        //write code to subscribe to a offline course
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student std = new Student(){FirstName ="Steve",LastName="Jobs"};
        Course onlineSoftwareEngCourse = new OnlineCourse(){Title ="Software Engineering"};
        onlineSoftwareEngCourse.Subscribe(std);
    }
}
