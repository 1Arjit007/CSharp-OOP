// Class Relations: Association and Composition
    // Association
    // Composition
    //     Composition
    //     Aggregation
    // Inheritance

// Association
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
}

public class StudentRepository
{
    public Student GetStudent(int StudentId)
    {
        // get student by id from db here

        return new Student();
    }
    public bool Save(Student student)
    {
        // save student to db here
        Console.WriteLine("Student saved successfully");

        return true;
    }
    public bool Validate(Student student)
    {
        // get student from db to check whether the data is already exist
        Console.WriteLine("Student does not exist.");

        return true;
    }
}

// Composition
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public Address HomeAddress { get; set; }
}

public class Address
{
    public int AddressId { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

}

// Composition using Id Property

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public int AddressId { get; set; }
}

// Aggregation
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public Course EnrolledCourse { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public IList Topics { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}