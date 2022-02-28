using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ILogger
{
    void Log(string Sentence);
}
public class Logger : ILogger
{
    public void Log(string Sentence)
    {
        Console.WriteLine(Sentence);
    }
}
public class Calculator
{

    public double First, Second;
    public bool Flag1, Flag2;
    ILogger LogObj;
    public Calculator(ILogger LoggerObj)
    {
        LogObj = LoggerObj;
    }

    public bool Validate(string Input1, string Input2)
    {
        Flag1 = double.TryParse(Input1, out First);
        Flag2 = double.TryParse(Input2, out Second);
        if (Flag1 && Flag2)
        {
            return true;
        }
        else
        {
            LogObj.Log("Please enter valid numbers");
            return false;
        }
    }
    public double Add(double number1, double number2)
    {
        LogObj.Log("Addition is :");
        return number1 + number2;
    }
    public double Subtract(double number1, double number2)
    {
        LogObj.Log("Subtraction is :");
        return number1 - number2;
    }
    public double Multiply(double number1, double number2)
    {
        LogObj.Log("Multiplication  is :");

        return number1 * number2;
    }
    public double Divide(double number1, double number2)
    {
        if (number2 == 0)
        {
            LogObj.Log("Division by zero ");
            return -1;
        }
        LogObj.Log("Division is :");
        return number1 / number2;
    }
}
