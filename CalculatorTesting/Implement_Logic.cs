using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public interface ILogger
    {
        void Log(string sentence);
    }
    public class Logger : ILogger
    {
        public void Log(string sentence)
        {
            Console.WriteLine(sentence);
        }
    }
    
    public class Calculator 
    {

        public double First, Second;

        ILogger Log_Obj;
        public Calculator(ILogger Logger_Obj)
        {
            Log_Obj = Logger_Obj;
        }

        public bool Validate(string input1, string input2)
        {
            bool flag1 = double.TryParse(input1, out First);
            bool flag2 = double.TryParse(input2, out Second);
            if (flag1 && flag2)
            {
                return true;
            }
            else
            {
                Log_Obj.Log("Please enter valid numbers");
                return false;
            }
        }
        public double Add(double number1, double number2)
        {
            Log_Obj.Log("Addition is :");
            return number1+number2;
        }
        public double Subtract(double number1, double number2)
        {
            Log_Obj.Log("Subtraction is :");
            return number1 - number2;
        }
        public double Multiply(double number1, double number2)
        {
            Log_Obj.Log("Multiplication  is :");

            return number1 * number2;
        }
        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                Log_Obj.Log("Division by zero ");
                return -1;
            }
            Log_Obj.Log("Division is :");
            return number1 / number2;
        }
    }
}
