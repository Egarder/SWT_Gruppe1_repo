using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return (a+b);
        }
        public double Substract(double a, double b)
        {
            return (a-b);
        }
        public double Multiply(double a, double b)
        {
            return (a*b);
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("You can't divide by zero");
            else
            {
                return (a / b);
            }
        }
        public double Power(double a, double exp)
        {
            if (a < 0 && exp < 0)
            {
                throw new ArgumentOutOfRangeException("You cant use power() 2 negative numbers");
            }
            else
            {
                return (Math.Pow(a, exp));
            }


        }


    }
}
