using System;
class Program
{
    static void Main()
    {
        // Sample usage of the Employee class and overloaded operators 
        Employee employee1 = new Employee(1, "John", "Doe");
        Employee employee2 = new Employee(2, "Jane", "Doe");
        Employee employee3 = new Employee(1, "John", "Doe");
    

        // Check equality using overloaded ==
        Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
        Console.WriteLine($"employee1 == employee3: {employee1 == employee3}");

        // CHeck inequality using overloaded !=
        Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");
        Console.WriteLine($"employee1 != employee3: {employee1 != employee3}");

    }
 }
