using System;


    //Step 1: Create an  Employee class with Id, FirsName, and LastName properties.
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Comstructor
        public Employee( int id, string frstName, string lastName)
        {
            Id = id;
            FirstName = FirstName;
            LastName = LastName;
        }

        // Step: Overload the "==" operator to check if two Employe objects are equal by comparing their Id property.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or if their Id properties are equal
            return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
                  !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
                   employee1.Id == employee2.Id;
        }

        // Overload the "!=" operator to complement the "==" operator.
        public static bool operator  !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
