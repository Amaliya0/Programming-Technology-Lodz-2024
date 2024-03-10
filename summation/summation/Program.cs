using System;

class Program
{
    static void Main()
    {
        //Input
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //Sum
        int SUM = num1 + num2;
        //result
        Console.WriteLine("Result of sum: " + SUM);
    }
}