using System;

abstract class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Employee : Person
{
    public string Position { get; set; }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Edit Employee");
            Console.WriteLine("3. Display Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        EditEmployee();
                        break;
                    case 3:
                        DisplayEmployees();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void AddEmployee()
    {
        Console.WriteLine("Add Employee");

        Employee newEmployee = new Employee();

        Console.Write("Enter Employee ID: ");
        newEmployee.ID = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        newEmployee.Name = Console.ReadLine();

        Console.Write("Enter Employee Position: ");
        newEmployee.Position = Console.ReadLine();

        employees.Add(newEmployee);

        Console.WriteLine("Employee added successfully!");
    }

    static void EditEmployee()
    {
        Console.WriteLine("Edit Employee");

        Console.Write("Enter Employee ID to edit: ");
        int idToEdit = int.Parse(Console.ReadLine());

        Employee employeeToEdit = employees.Find(e => e.ID == idToEdit);

        if (employeeToEdit != null)
        {
            Console.Write("Enter new Employee Name: ");
            employeeToEdit.Name = Console.ReadLine();

            Console.Write("Enter new Employee Position: ");
            employeeToEdit.Position = Console.ReadLine();

            Console.WriteLine("Employee details updated successfully!");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void DisplayEmployees()
    {
        Console.WriteLine("Employee List");

        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Position: {employee.Position}");
        }
    }
}
