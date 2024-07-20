using System;

public enum DaysOfWeek
{
    Sunday,  
    Monday,    
    Tuesday,   
    Thursday, 
    Friday,   
    Saturday   
}

class Program
{
    static void Main(string[] args)
    {
   
        DaysOfWeek today = DaysOfWeek.Thursday;

        Console.WriteLine($"Today is: {today}");

        int dayValue = (int)today;
        Console.WriteLine($"Integer value of {today} is: {dayValue}");

        Console.WriteLine("\nDays of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine($"{day} = {(int)day}");
        }

        // Check if a specific day is a weekend
        if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
        {
            Console.WriteLine($"{today} is a weekend.");
        }
        else
        {
            Console.WriteLine($"{today} is a weekday.");
        }
    }
}