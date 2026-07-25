using System.Text.Json;
class Program
{
    static void Main()
    {
        Student student=new Student()
        {
            Id=1,
            Name="Pradnya",
            Course="Dotnet"

        };


        string json=JsonSerializer.Serialize(student);
        File.WriteAllText("student.json",json);
        Console.WriteLine("Serialization successful");
        Console.WriteLine(json);

    }

}

//Serialization is the process of converting an object into a format such as JSON, XML, or 
// Binary so that it can be saved, stored, or transferred.


//1.Web App) When a client sends or receives data, objects are converted to JSON.
