using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            //tester tester
            double temp = (a+b);
            Accumulator = temp;
            return (a+b);
        }

        public double Add(double a)
        {
            return a + Accumulator;
        }


        public double Substract(double a, double b)
        {
            double temp = (a-b);
            Accumulator = temp;
            return (a-b);
        }

        public double Substract(double a)
        {
            return a - Accumulator;
        }

        public double Multiply(double a, double b)
        {
            double temp = (a*b);
            Accumulator = temp;
            return (a*b);
        }

        public double Multiplyer(double a)
        {
            double temp = a * Accumulator;
            Accumulator = temp;
            return temp;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("You can't divide by zero");
            else
            {
                double temp = (a / b);
                Accumulator = temp;
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
                double temp = (Math.Pow(a, exp));
                Accumulator = temp;
                return temp;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double Accumulator { get; private set; }


    }
}
