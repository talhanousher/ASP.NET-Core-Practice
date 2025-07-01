using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Calculator
{
    public double Number1 { get; set; }
    public double Number2 { get; set; }
    public Calculator(double num1, double num2)
    {
        Number1 = num1;
        Number2 = num2;
    }


    public double Add()
    {
        return Number1 + Number2;
    }
    public double Subtract()
    {
        return Number1 - Number2;
    }
    public double Multiply()
    {
        return Number1 * Number2;
    }
    public double Divide()
    {
        if (Number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return Number1 / Number2;
    }
}
