// Interface Segregation Principle
// Clients should not be forced to depend on methods they do not use.

// Fat Interface
public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    void AddCourse(Course cs);
    void EditCourse(Course cs);
    void DeleteCourse(Course cs);

    bool SubscribeCourse(Course cs);
    bool UnSubscribeCourse(Course cs);
    IList<Student> GetAllStudents();
    IList<Student> GetAllStudents(Course cs);

    IList<Course> GetAllCourse();
    IList<Course> GetAllCourses(Student std);
}

public class StudentRepository : IStudentRepository
{
    public void AddCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void AddStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void DeleteCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void DeleteStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public void EditCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public void EditStudent(Student std)
    {
        //implementation code removed for better clarity
    }

    public IList<Course> GetAllCourse()
    {
        //implementation code removed for better clarity
    }

    public IList<Course> GetAllCourses(Student std)
    {
        //implementation code removed for better clarity
    }

    public IList<Student> GetAllStudents()
    {
        //implementation code removed for better clarity
    }

    public IList<Student> GetAllStudents(Course cs)
    {
        //implementation code removed for better clarity
    }

    public bool SubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }

    public bool UnSubscribeCourse(Course cs)
    {
        //implementation code removed for better clarity
    }
}

// Interfaces after apllying ISP
public interface IStudentRepository
{
    void AddStudent(Student std);
    void EditStudent(Student std);
    void DeleteStudent(Student std);

    bool SubscribeCourse(Course cs);
    bool UnSubscribeCourse(Course cs);
    IList<Student> GetAllStudents();
    IList<Student> GetAllStudents(Course cs);
}

public interface ICourseRepository
{
    void AddCourse(Course cs);
    void EditCourse(Course cs);
    void DeleteCourse(Course cs);

    IList<Course> GetAllCourse();
    IList<Course> GetAllCourses(Student std);
}

// The following code smells detects ISP violation:

// When you have large interfaces.
// When you implement an interface in a concrete class where some methods do not have any implementation code or throw NotImplementedException.
// When you call only a small set of methods of a larger interface.

// The solution to ISP violations:

// Split large interfaces into smaller ones.
// inherit multiple small interfaces if required.
// Use the adapter design pattern for the third-party large interface so that your code can work with the adapter.
