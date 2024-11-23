using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao danh sach hoc sinh
        List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Anh Quan", Age = 15 },
    new Student { Id = 2, Name = "Hoa", Age = 16 },
    new Student { Id = 3, Name = "Quang", Age = 17 },
    new Student { Id = 4, Name = "Lan", Age = 14 },
    new Student { Id = 5, Name = "Tuan", Age = 19 }
};


        // a. In danh sach toan bo hoc sinh
        Console.WriteLine("Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tim va in cac hoc sinh co tuoi tu 15 den 18
        var studentsInRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        foreach (var student in studentsInRange)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tim va in hoc sinh co ten bat dau bang chu "A"
        var studentsWithNameA = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
        foreach (var student in studentsWithNameA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tinh tong tuoi cua tat ca hoc sinh
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tim va in hoc sinh co tuoi lon nhat
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sap xep danh sach hoc sinh theo tuoi tang dan va in ra
        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}

