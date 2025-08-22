using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    UpdateStudent();
                    break;
                case 4:
                    DeleteStudent();
                    break;
                case 5:
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Student ID: ");
        s.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        s.Name = Console.ReadLine();

        students.Add(s);
        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\n--- Student List ---");
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
        }
    }

    static void UpdateStudent()
    {
        Console.Write("Enter Student ID to update: ");
        int id = int.Parse(Console.ReadLine());

        Student s = students.Find(stu => stu.Id == id);
        if (s == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("Enter new name: ");
        s.Name = Console.ReadLine();
        Console.WriteLine("Student updated successfully!");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        Student s = students.Find(stu => stu.Id == id);
        if (s == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        students.Remove(s);
        Console.WriteLine("Student deleted successfully!");
    }
}
