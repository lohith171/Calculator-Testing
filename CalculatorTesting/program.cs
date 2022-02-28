
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the first number :");
        string Input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number :");
        string Input2 = Console.ReadLine();

        ILogger LogObj = new Logger();
        Calculator MyObj = new Calculator(LogObj);

        if (!MyObj.Validate(Input1, Input2)) return 0;
        double Number1 = MyObj.First, Number2 = MyObj.Second;
        Console.WriteLine(MyObj.Add(Number1, Number2));
        Console.WriteLine(MyObj.Subtract(Number1, Number2));
        Console.WriteLine(MyObj.Multiply(Number1, Number2));
        Console.WriteLine(MyObj.Divide(Number1, Number2));

        Console.ReadLine();
        return 0;
    }
}

