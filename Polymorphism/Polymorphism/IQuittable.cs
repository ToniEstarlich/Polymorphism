using System;

// Step 1: Create an interface called IQuittable
interface IQuittable
{
    void Quit();
}

// Step 2: Inherit the IQuittable interface in the Employee class
class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
    }
}
