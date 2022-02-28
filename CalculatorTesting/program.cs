
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementation;

namespace Program
{
    public class ProgramClass
    {
        static int Main()
        {
            Console.WriteLine("Enter the first number :");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number :");
            string input2 = Console.ReadLine();

            ILogger logObj = new Logger();
            Calculator myObj = new Calculator(logObj);

            if (!myObj.Validate(input1, input2)) return 0;
            double number1 = myObj.First, number2 = myObj.Second;
            Console.WriteLine(myObj.Add(number1, number2));
            Console.WriteLine(myObj.Subtract(number1, number2));
            Console.WriteLine(myObj.Multiply(number1, number2));
            Console.WriteLine(myObj.Divide(number1, number2));

            Console.ReadLine();
            return 0;
        }
    }

}
