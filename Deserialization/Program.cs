using System;
using System.IO;
using System.Text.Json;
using Deserialization.Models;
class Program
{
    static void Main()
    {
        // Read the JSON file
        string json=File.ReadAllText("student.json");
        // Deserialize the JSON into a Student object
        Student? student=JsonSerializer.Deserialize<Student>(json);
        // Display the student information
        if(student!=null)
        {
           Console.WriteLine("Deserialization successful!");
           Console.WriteLine("Id:"+student.Id);
           Console.WriteLine("Name:"+student.Name);
           Console.WriteLine("Course:"+student.Course);
        }
        else
        {
            Console.WriteLine("Failed to deserialize the JSON");
        }
    }
}