﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    public class Calculator
    {

        //Bare en kommentar til jenkins
        public double Add(double a, double b)
        {
            //tester tester
            double temp = (a+b);
            Accumulator = temp;
            return (a+b);
        }

        public double Add(double a)
        {
            double result = a + Accumulator;
            Accumulator = result;
            return result;
        }


        public double Subtract(double a, double b)
        {
            double temp = (a-b);
            Accumulator = temp;
            return (a-b);
        }

        public double Subtract(double a)
        {
            double result = a - Accumulator;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double temp = (a*b);
            Accumulator = temp;
            return (a*b);
        }

        public double Multiply(double a)
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
        public double Divide(double a)
        {
            if (a == 0)
                throw new DivideByZeroException("You can't divide by zero");
            else
            {
                double temp = (Accumulator / a);
                Accumulator = temp;
                return temp;
            }
        }
        public double Power(double a, double exp)
        {
            if (a < 0 && exp < 0)
            {
                throw new ArgumentOutOfRangeException("You cant use power() on 2 negative numbers");
            }
            else
            {
                double temp = (Math.Pow(a, exp));
                Accumulator = temp;
                return temp;
            }
        }

        public double Power(double exp)
        {
            double temp = (Math.Pow(Accumulator, exp));
            Accumulator = temp;
            return temp;
        }

        public void Clear()
        {
            Accumulator = 0;
        }


        public double Accumulator { get; private set; }


    }
}
