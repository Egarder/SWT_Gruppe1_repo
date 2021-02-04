using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(-2, 2));
            Console.WriteLine(calc.Subtract(-2, 2));
            Console.WriteLine(calc.Multiply(-2, 2));

            try
            {
                Console.WriteLine(calc.Power(-2, 2));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.WriteLine(calc.Divide(2,2));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
