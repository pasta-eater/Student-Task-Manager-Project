using System;

public class Student
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

public class Tasks
{
    public Tasks()
    {
        Console.WriteLine("Here are your tasks for the week:");
        string Title = "Quantitave Methods: Review for the Midterm Exam";
        Console.WriteLine($"Task: {Title}");
        Console.WriteLine("test");
        //test lang na comment
    }
}

public class LandingPage
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Student Task Manager!\nSign in to view your student information.");
        Console.ReadKey();
        Console.WriteLine("Do you want to sign in to view your student information? (Yes/No)");
        string answer = Console.ReadLine();

        if (answer == "Yes")
        {
            Console.WriteLine("Signing in...");
        }

        Console.ReadKey();
    }
}

