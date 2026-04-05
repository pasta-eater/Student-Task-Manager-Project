using System;

public class User // Represents a user with a username and password
{
    public string Username { get; set; }
    private string Password { get; set; }

    public User(string user, string pass)
    {
        Username = user;
        Password = pass;
    }

    public bool CheckPassword(string input)
    {
        return input == Password;
    }
}
public class Student // Represents a student with a name, GWA, and ID number
{
    string name = "Emmanuel de Luna";
    double gwa = 1.28;
    int IDNum = 202511873;

    public static void Name()
    {
        Student myName = new Student();
        Console.WriteLine($"Student Name: {myName.name}");
    }
    public static void GWA()
    {
        Student myGWA = new Student();
        Console.WriteLine($"Student GWA: {myGWA.gwa}");
    }
    public static void ID()
    {
        Student myID = new Student();
        Console.WriteLine($"Student ID: {myID.IDNum}");
    }
}

public class Tasks // Represents the tasks assigned to the student for the week 
{
    public Tasks()
    {
        Console.WriteLine("Here are your tasks for the week:");
        string Title = "Quantitave Methods: Review for the Midterm Exam";
        Console.WriteLine($"Task: {Title}");
        Console.WriteLine("test");
        //test lang na comment hehe
    }
}

public class LandingPage // Represents the landing page of the application where the user can log in    
{
    public static void Main(string[] args)
    {
        User admin = new User("PastaDev63", "Admin123");
        bool isAuthenticated = false;
        
        Console.WriteLine("Welcome to the Student Task Manager!");
        Console.WriteLine("Do you want to log in? (yes/no)");
        string response = Console.ReadLine().Trim().ToLower(); // Para matandaan ko lang Trim is for removing unnecessary spaces and ToLower is para mag Lowercase.

        if (response == "yes")
        {
            while (!isAuthenticated)
            {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (admin.Username == username && admin.CheckPassword(password))
                {
                    Console.WriteLine("\n--- Login successful! ---\n");
                    isAuthenticated = true;
                }
            else
                {
                    Console.WriteLine("\nInvalid username or password. Please try again.");
                }
            }

            Student.Name();
            Student.GWA();
            Student.ID();
            Tasks tasks = new Tasks();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();  
            }
        else
        {
            Console.WriteLine("Exiting the program. Goodbye!\nPress any key to exit...");
            Console.ReadKey();  
        }
    }
}

