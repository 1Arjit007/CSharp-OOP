// Dependency Inversion Principle
// High-level modules should not depend on low-level modules. Both should depend on abstraction

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }

    // tight coupling
    private StudentRepository _stdRepo = new StudentRepository();

    public Student() { }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public class StudentRepository
{
    public void AddStudent(Student std)
    {
        //EF code removed for clarity
    }

    public void DeleteStudent(Student std)
    {
        //EF code removed for clarity
    }

    public void EditStudent(Student std)
    {
        //EF code removed for clarity
    }

    public IList GetAllStudents()
    {
        //EF code removed for clarity
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }

    private IStudentRepository _stdRepo;

    public Student(IStudentRepository stdRepo)
    {
        _stdRepo = stdRepo;
    }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    IList GetAllStudents();
}

public class StudentRepository : IStudentRepository
{
    public void AddStudent(Student std)
    {
        //code removed for clarity
    }

    public void DeleteStudent(Student std)
    {
        //code removed for clarity
    }

    public void EditStudent(Student std)
    {
        //code removed for clarity
    }

    public IList GetAllStudents()
    {
        //code removed for clarity
    }
}

internal class Program
{

    static void Main(string[] args)
    {
	    //for production
	    Student std1 = new Student(new StudentRepository);
	    //for unit test
	    Student std2 = new Student(new TestStudentRepository);
    }   

}


public class RepositoryFactory
{
    public static IStudentRepository GetStudentRepository() 
    {
        return new StudentRepository();
    }

public static IStudentRepository GetTestStudentRepository() 
    {
        return new TestStudentRepository();
    }

}

internal class Program
{

    static void Main(string[] args)
    {
	    //for production
	    Student std1 = new Student(RepositoryFactory.GetStudentRepository());


	    //for unit test
	    Student std2 = new Student(RepositoryFactory.TestGetStudentRepository());


    }

}


public class RepositoryFactory
{
    public static IStudentRepository GetStudentRepository() 
    {
        return new StudentRepository();
    }

public static IStudentRepository GetTestStudentRepository() 
    {
        return new TestStudentRepository();
    }

}

internal class Program
{

    static void Main(string[] args)
    {
	    //for production
	    Student std1 = new Student(RepositoryFactory.GetStudentRepository());


	    //for unit test
	    Student std2 = new Student(RepositoryFactory.TestGetStudentRepository());


    }

}
