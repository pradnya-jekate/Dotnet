using System;
using MathEngine;
MathEngine.MathEngine engine=new MathEngine.MathEngine();
while(true)
{
    Console.WriteLine("\n=======MathEngine=======");
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Exit");

    Console.WriteLine("\n Enter Choice:");
    int choice=Convert.ToInt32(Console.ReadLine());

    if(choice==5)
    {
        Console.WriteLine("Thank you! ");
        break;
    }
    Console.WriteLine("Enter First Number:");
    double num1=Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter Second Number:");
    double num2=Convert.ToDouble(Console.ReadLine());

    MathEngine.MathOperation operation=null;
    switch(choice)
    {
        case 1:
            operation=engine.Add;
            break;
        case 2:
            operation=engine.Subtract;
            break;
        case 3:
            operation=engine.Multiply;
            break;
        case 4:
            operation=engine.Divide;
            break;
        default:
            Console.WriteLine("Invalid Choice");
            continue;
    }
    try
    {
        double result=operation(num1,num2);
        Console.WriteLine($"\nResult = {result}");
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Error:" + ex.Message);
    }
}

namespace MathEngine
{
    //Delegate Definition
    public delegate double MathOperation(double a, double b);

    public class MathEngine
    {
        public double Add(double a, double b)=>a + b;
        public double Subtract(double a, double b)=>a - b;
        public double Multiply(double a, double b)=>a * b;
        public double Divide(double a, double b)
        {
            if(b==0)
                throw new DivideByZeroException("Cannot divide by zero!");
                return a/b;
        }
    }
}
