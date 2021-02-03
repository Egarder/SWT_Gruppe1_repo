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
        public void add_2_doubles_expected_equal()
        {
            double temp = uut.Add(2.5, 2.5);
            Assert.That(temp, Is.EqualTo(5));
        }

        [Test]
        public void add_negative_double_to_positive_expected_negative()
        {
            double temp = uut.Add(-4, 2);
            Assert.That(temp, Is.Negative);
        }

        //Test of Substract()
        [Test]
        public void substract_2_doubles_expected_equal()
        {
            double temp = uut.Substract(10.5, 2.5);
            Assert.That(temp, Is.EqualTo(8));
        }

        [Test]
        public void substract_negative_double_expected_negative()
        {
            double temp = uut.Substract(0, 2);
            Assert.That(temp, Is.Negative);
        }

        [Test]
        public void substract_two_negative_doubles_expected_inRange_ok()
        {
            double temp = uut.Substract(-7.88, -2.12);
            Assert.That(temp, Is.InRange(-5.77,-5.75));
        }


        //Test of Multiply()
        [Test]
        public void multiply_doubleByInt_expected_equal()
        {
            double temp = uut.Multiply(2.5, 2);
            Assert.That(temp, Is.EqualTo(5));
        }

        [Test]
        public void multiply_negative_double_expected_negative()
        {
            //Act
            double temp = uut.Multiply(-2.5, 2);

            //Assert
            Assert.That(temp, Is.Negative);
        }

        [Test]
        public void double_decimal_presicion_mulitply_expected_InRangeOf()
        {
            //Act
            double temp = uut.Multiply(12.31, 10.22);

            //Assert
            Assert.That(temp, Is.InRange(125.8082, 125.8083));
        }

        //Test of Power()
        [Test]
        public void power_of_double_expected_equal()
        {
            double temp = uut.Power(2, 2);
            Assert.That(temp, Is.EqualTo(4));
        }

        [Test]
        public void power_negative_double_expected_positive()
        {
            //Act
            double temp = uut.Power(-2.5, 2);

            //Assert
            Assert.That(temp, Is.Positive);
        }


        //Test of exception pow()
        [Test]
        public void exception_test_in_pow_of_negatives_thrown()
        {
            Assert.That(() => uut.Power(-2,-2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        //Test of divide
        [Test]
        public void positive_Divide_doubles_expected_Equalto()
        {
            //Act
            double temp = uut.Divide(15, 2.5);

            //Assert
            Assert.That(temp, Is.EqualTo(6));
        }

        [Test]
        public void negative_Divide_doubles_expected_Equalto()
        {
            //Act
            double temp = uut.Divide(-15, 2.5);

            //Assert
            Assert.That(temp, Is.EqualTo(-6));
        }

        [Test]
        public void longDecimal_Divide_doubles_expected_Equalto()
        {
            //Act
            double temp = uut.Divide(-15.213857, 2.5231124);

            //Assert
            Assert.That(temp, Is.InRange(-6.03,-6.02979));
        }


        //Test of exception Divide()
        [Test]
        public void divide_by_zero_test_exception_thrown()
        {
            Assert.That(() => uut.Divide(2, 0), Throws.TypeOf<DivideByZeroException>());
        }

        //Test of Accumulator
        [Test]
        public void Accumulator_holds_value_divie()
        {
            uut.Divide(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(1));
        }
        [Test]
        public void Accumulator_holds_value_multiply()
        {
            uut.Multiply(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
        [Test]
        public void Accumulator_holds_value_Add()
        {
            uut.Add(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
        [Test]
        public void Accumulator_holds_value_substract()
        {
            uut.Substract(4, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(2));
        }
        [Test]
        public void Accumulator_holds_value_Power()
        {
            uut.Power(2, 2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
    }
}