using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculate.Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculate.Calculator();
        }

        //Test of Add()
        [Test]
        public void Add_TwoDoubles_CorrectResult()
        {
            double temp = uut.Add(2.5, 2.5);
            Assert.That(temp, Is.EqualTo(5));
        }

        [Test]
        public void Add_NegativeDoublePositiveDouble_NegativeResult()
        {
            double temp = uut.Add(-4, 2);
            Assert.That(temp, Is.Negative);
        }

        //Test of Subtract()
        [Test]
        public void Subtract_TwoDoubles_CorrectResult()
        {
            double temp = uut.Subtract(10.5, 2.5);
            Assert.That(temp, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ZeroAndTwo_ResultIsNegative()
        {
            double temp = uut.Subtract(0, 2);
            Assert.That(temp, Is.Negative);
        }

        [Test]
        public void Subtract_TwoNegativeDoubles_ResultInRange()
        {
            double temp = uut.Subtract(-7.88, -2.12);
            Assert.That(temp, Is.InRange(-5.77, -5.75));
        }


        //Test of Multiply()
        [Test]
        public void Multiply_DoubleByInt_ResultIsCorrect()
        {
            double temp = uut.Multiply(2.5, 2);
            Assert.That(temp, Is.EqualTo(5));
        }

        [Test]
        public void Multiply_NegativeDouble_ResultIsNegative()
        {
            //Act
            double temp = uut.Multiply(-2.5, 2);

            //Assert
            Assert.That(temp, Is.Negative);
        }

        [Test]
        public void Multiply_DecimalPrecision_ResultInRange()
        {
            //Act
            double temp = uut.Multiply(12.31, 10.22);

            //Assert
            Assert.That(temp, Is.InRange(125.8082, 125.8083));
        }

        //Test of Power()
        [Test]
        public void Power_TwoPositiveNumbers_ResultIsCorrect()
        {
            double temp = uut.Power(2, 2);
            Assert.That(temp, Is.EqualTo(4));
        }

        [Test]
        public void Power_OnePositiveOneNegative_ResultIsCorrect()
        {
            //Act
            double temp = uut.Power(-2.5, 2);

            //Assert
            Assert.That(temp, Is.EqualTo(6.25));
        }

        [Test]
        public void Power_TwoNegativeNumbers_ExceptionThrown()
        {
            Assert.That(()=>uut.Power(-2, -2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }



        //Test of divide
        [Test]
        public void Divide_TwoPositiveNumbers_ResultIsCorrect()
        {
            //Act
            double temp = uut.Divide(15, 2.5);

            //Assert
            Assert.That(temp, Is.EqualTo(6));
        }

        [Test]
        public void Divide_TwoNegativeNumbers_ResultIsCorrect()
        {
            //Act
            double temp = uut.Divide(-15, 2.5);

            //Assert
            Assert.That(temp, Is.EqualTo(-6));
        }

        [Test]
        public void Divide_DecimalPrecision_ResultIsInRange()
        {
            //Act
            double temp = uut.Divide(-15.213857, 2.5231124);

            //Assert
            Assert.That(temp, Is.InRange(-6.03, -6.02979));
        }

        [Test]
        public void zero_Divide_By2_Expected0()
        {
            Assert.That(() => uut.Divide(0, 2), Is.EqualTo(0));
        }

        //Test of exception Divide()
        [Test]
        public void Divide_ByZero_ExceptionThrown()
        {
            Assert.That(() => uut.Divide(1, 0), Throws.TypeOf<DivideByZeroException>());
        }
        [Test]
        public void Divide0_ByZero_ExceptionThrown()
        {
            Assert.That(() => uut.Divide(0, 0), Throws.TypeOf<DivideByZeroException>());
        }
        [Test]
        public void Dividenegative_ByZero_ExceptionThrown()
        {
            Assert.That(() => uut.Divide(-1, 0), Throws.TypeOf<DivideByZeroException>());
        }
       

        //Test of Accumulator
        [Test]
        public void Divide_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Divide(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Multiply(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Add_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Add(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Subtract(4, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(2));
        }

        [Test]
        public void Power_TwoPositiveNumbers_AccumulatorIsCorrect()
        {
            uut.Power(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Clear_AccumulatorIsCleared()
        {
            uut.Clear();
            Assert.That(uut.Accumulator, Is.Zero);
        }

        //Test of overloaded Add()
        [Test]
        public void OverloadedAdd_PositiveNumber_ResultCorrect()
        {
            uut.Add(5, 4);
            // Acummulater == 9
            Assert.That(uut.Add(3), Is.EqualTo(12));
        }

        [Test]
        public void OverloadedAdd_NegativeNumber_ResultCorrect()
        {
            uut.Add(5, 4);
            // Acummulater == 9
            Assert.That(uut.Add(-12), Is.EqualTo(-3));
        }

        [Test]
        public void OverloadedSubtract_PositiveNumber_ResultCorrect()
        {
            uut.Add(5, 4);
            // Acummulater == 9
            Assert.That(uut.Subtract(12), Is.EqualTo(3));
        }

        [Test]
        public void OverloadedSubtract_NegativeNumber_ResultCorrect()
        {
            uut.Add(5, 4);
            // Acummulater == 9
            Assert.That(uut.Subtract(-3), Is.EqualTo(-12));
        }


        [Test]
        public void OverloadedMultiply_PositiveNumber_ResultCorrect()
        {
            //uut.Clear();
            uut.Multiply(2, 5);
            Assert.That(uut.Multiply(2), Is.EqualTo(20));
        }

        [Test]
        public void OverloadedMultiply_NegativeNumber_ResultCorrect()
        {
            uut.Multiply(2, 5);
            Assert.That(uut.Multiply(-2), Is.EqualTo(-20));
        }

        [Test]
        public void OverloadedDivide_PositiveNumber_ResultCorrect()
        {
            uut.Divide(20, 2);
            Assert.That(uut.Divide(2), Is.EqualTo(5));
        }

        [Test]
        public void OverloadedDivide_NegativeNumber_ResultCorrect()
        {
            uut.Divide(20, 2);
            Assert.That(uut.Divide(-2), Is.EqualTo(-5));
        }

        [Test]
        public void OverloadedDivide_Zero_ExceptionThrown()
        {
            uut.Divide(20, 2);
            Assert.That(() => uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void OverloadedPower_TwoPositiveNumbers_ResultCorrect()
        {
            uut.Power(2, 2);
            Assert.That(uut.Power(2), Is.EqualTo(16));
        }

        [Test]
        public void OverloadedPower_OnePositiveOneNegativeNumbers_ResultCorrect()
        {
            uut.Power(2, 2);
            Assert.That(uut.Power(-2), Is.Positive);
        }


    }
}