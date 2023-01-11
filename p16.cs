// C# Design Pattern: Singleton
// The singleton design pattern is a creational design pattern.

// Singleton Class Structure
// Should have a private or protected constructor. No public and parameterized constructors.
// Should have a static property (with a private backing field) to return an instance of a class. A static method can also be used to return an instance.
// At least have one non-static public method for a singleton operation.

// Singleton Class Structure
public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }

    public void DoSingletonOperation()
    {
        Console.WriteLine("singleton operation");
    }
}

// Singleton Object
static void Main(string[] args)
{
    Singleton s1 = Singleton.Instance;

    Singleton s2 = Singleton.Instance;

    Console.WriteLine(s1 == s2); // true
}

// Singleton Class
public class VoteMachine
{
    private VoteMachine _instance = null;
    private int _totalVotes = 0;
        
    private VoteMachine()
    {
    }

    public static VoteMachine Instance
    {
        get
        {
            if (_instance == null) {
                    
                    _instance = new VoteMachine();
                }
            }
            return _instance;
        }
    }

    public void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public int TotalVotes
    {
        get
        {
            return _totalVotes;
        }
    }
}

// Objects of Singleton Class
internal class Program
{
    static void Main(string[] args)
    {
        VoteMachine vm1 = VoteMachine.Instance;
        VoteMachine vm2 = VoteMachine.Instance;
        VoteMachine vm3 = VoteMachine.Instance;

        vm1.RegisterVote();
        vm2.RegisterVote();
        vm3.RegisterVote();

        Console.WriteLine(vm1.TotalVotes);
    }
}

// Test Singleton Object using Parallel class
internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Enumerable.Range(0, 10);
            
        Parallel.ForEach(numbers, i =>
        {                
            var vm = VoteMachine.Instance;
            vm.RegisterVote();
        });
        
        Console.WriteLine(VoteMachine.Instance.TotalVotes);
    }
}

// Thread-safe Singleton Class
public class VoteMachine
{
    private static VoteMachine _instance = null;
    private int _totalVotes = 0;

    private static readonly object lockObj = new object();

    private VoteMachine()
    {
    }

    public static VoteMachine Instance
    {
        get
        {
            lock (lockObj)
            {
                if (_instance == null)
                {
                    _instance = new VoteMachine();
                }
            }
                
            return _instance;
        }
    }

    public void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public int TotalVotes
    {
        get
        {
            return _totalVotes;
        }
    }
}

// Test Thread-safe Singleton Class
public class Program
{
    public static void Main(string[] args)
    {
        var numbers = Enumerable.Range(0, 10);
            
        Parallel.ForEach(numbers, i =>
        {                
            var vm = VoteMachine.Instance;
            vm.RegisterVote();
        });
            
        Console.WriteLine(VoteMachine.Instance.TotalVotes);
    }
}

// Thread-safe Singleton Class
public class VoteMachine
{
    private static VoteMachine _instance = null;
    private int _totalVotes = 0;

    private static readonly object lockObj = new object();
    
    private VoteMachine()
    {
    }

    public static VoteMachine Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new VoteMachine();
                    }
                }
            }
            return _instance;
        }
    }

    public void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public int TotalVotes
    {
        get
        {
            return _totalVotes;
        }
    }
}

// Singleton Class
public class VoteMachine
{
	private static readonly VoteMachine _instance = new VoteMachine();
	private int _totalVotes = 0;

	static VoteMachine()
	{
	}

	private VoteMachine()
	{
	}

	public static VoteMachine Instance
	{
		get
		{
			return _instance;
		}
	}

	public void RegisterVote()
	{
		_totalVotes += 1;
		Console.WriteLine("Registered Vote #" + _totalVotes);
	}

	public int TotalVotes
	{
		get
		{
			return _totalVotes;
		}
	}
}

// Singleton Class with Lazy Instantiation
public sealed class VoteMachine
{
	private static readonly Lazy<VoteMachine> _instance = new Lazy<VoteMachine>(() => new VoteMachine());
	private int _totalVotes = 0;
	
    private VoteMachine()
	{
	}

	public static VoteMachine Instance
	{
		get
		{
			return _instance.Value;
		}
	}

	public void RegisterVote()
	{
		_totalVotes += 1;
		Console.WriteLine("Registered Vote #" + _totalVotes);
	}

	public int TotalVotes
	{
		get
		{
			return _totalVotes;
		}
	}
}