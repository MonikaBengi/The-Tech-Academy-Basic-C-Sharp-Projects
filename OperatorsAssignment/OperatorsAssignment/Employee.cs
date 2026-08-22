namespace OperatorsAssignment
{
    // Represents an employee with an ID, first name, and last name.
    public class Employee
    {
        // Gets or sets the unique ID of the employee.
        public int Id { get; set; }

        // Gets or sets the employee's first name.
        public string FirstName { get; set; }

        // Gets or sets the employee's last name.
        public string LastName { get; set; }

        // Overloads the == operator to compare two employees by their ID.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both variables refer to the same object, they are equal.
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // If only one of them is null, they are not equal.
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Compare the employees by their ID.
            return employee1.Id == employee2.Id;
        }

        // Overloads the != operator because comparison operators must be overloaded in pairs.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Returns the opposite result of the == operator.
            return !(employee1 == employee2);
        }

        // Overrides Equals so Employee objects are also compared by their ID.
        public override bool Equals(object obj)
        {
            // Convert the object to an Employee if possible.
            Employee employee = obj as Employee;

            // Use the overloaded == operator to compare the employees.
            return this == employee;
        }

        // Overrides GetHashCode to use the employee ID.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}