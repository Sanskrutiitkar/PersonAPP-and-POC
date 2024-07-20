using System;

public class Student
{
    private string studentName;
    private int StudentAge;

    // Default constructor
    public Student()
    {
        studentName = "not given";
        StudentAge = 0;
        Console.WriteLine("Default constructor called.");
    }

    // Constructor with one parameter
    public Student(string name) : this() 
    {
        this.studentName = name;
        Console.WriteLine("Constructor with name called.");
    }

    public Student(string name, int age) : this(name) 
    {
        this.StudentAge = age;
        Console.WriteLine("Constructor with name and age called.");
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {studentName}, Age: {StudentAge}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating person with default constructor:");
        Student person1 = new Student();
        person1.PrintDetails();

        Console.WriteLine("\nCreating person with name constructor:");
        Student person2 = new Student("Sanskrti");
        person2.PrintDetails();

        Console.WriteLine("\nCreating person with name and age constructor:");
        Student person3 = new Student("Srushti", 25);
        person3.PrintDetails();
    }
}