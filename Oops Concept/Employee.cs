namespace HR;

public class Employee : IWorker
{
    //Encapsulation
    private string name;
    private int age;

    //Override
    public void Work()
    {
        Console.WriteLine("Employee is working.");
    }

}

