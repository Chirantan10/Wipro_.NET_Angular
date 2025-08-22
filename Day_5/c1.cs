using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public Dictionary<string, int> SubjectMarks { get; set; }

    public Student(int id, string name)
    {
        StudentId = id;
        StudentName = name;
        SubjectMarks = new Dictionary<string, int>();
    }

    public double GetAverageScore()
    {
        if (SubjectMarks.Count == 0)
            return 0;

        return SubjectMarks.Values.Average();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine("Subject Marks:");
        foreach (var subject in SubjectMarks)
        {
            Console.WriteLine($"  {subject.Key}: {subject.Value}");
        }
        Console.WriteLine($"Average Score: {GetAverageScore():F2}");
        Console.WriteLine("-----------------------------");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating a list to hold students
        List<Student> students = new List<Student>();

        // Creating student 1
        Student student1 = new Student(1, "Alice");
        student1.SubjectMarks.Add("Math", 85);
        student1.SubjectMarks.Add("Science", 90);
        student1.SubjectMarks.Add("English", 80);

        // Creating student 2
        Student student2 = new Student(2, "Bob");
        student2.SubjectMarks.Add("Math", 75);
        student2.SubjectMarks.Add("Science", 65);
        student2.SubjectMarks.Add("English", 70);

        // Adding students to the list
        students.Add(student1);
        students.Add(student2);

        // Display all student details with average
        foreach (var student in students)
        {
            student.DisplayDetails();
        }
    }
}
