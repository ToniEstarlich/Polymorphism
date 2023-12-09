using System;
 class Program
    {
        static void Main()
        {
            // Step 3: Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            // In this exasmple, an Employe object is treated as an IQuitable type.
            IQuittable quittableEmployee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
            };
            // Call the Quit() method on the IQuittable object.
            quittableEmployee.Quit();

            // Keep the console window open to see the result.
            Console.ReadLine();
        }
    }
