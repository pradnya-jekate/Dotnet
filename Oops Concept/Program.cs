using HR;
namespace oops;


public class Program
{
    //two types of classes
    //1. Abstract class-IWorker
    //2. Concrete class-Employee,Trainer


    //Entry Point function
    public static void Main(string[] args)
    {
        Console.WriteLine(" Polymorphism Example");
        //Polymorphism
        IWorker employee=new Employee();
        employee.Work();

        IWorker trainer=new Trainer();
        trainer.Work();
        

    }
}
       