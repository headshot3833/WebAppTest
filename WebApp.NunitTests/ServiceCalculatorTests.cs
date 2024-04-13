using WebApp.AplicationCalculator.Services;

namespace WebApp.NunitTests
{
    public class ServiceCalculatorTests
    {
        [Test]
        public void Divide_DividesTwoNumbers()
        {

            var calculator = new ServiceCalculator { A = 10, B = 5 };

            var result = calculator.Divide();


            Assert.AreEqual(2, result);
        }


        [Test]
        public void Divide_ByZero_ThrowsException()
        {

            var calculator = new ServiceCalculator { A = 10, B = 0 };


            Assert.Throws<DivideByZeroException>(() => calculator.Divide());
        }

        [Test]
        public void IntPlus_AddsTwoNumbers()
        {

            var calculator = new ServiceCalculator { A = 10, B = 5 };


            var result = calculator.IntPlus();


            Assert.AreEqual(15, result);
        }

        [Test]
        public void MultiplicationInt_MultipliesTwoNumbers()
        {

            var calculator = new ServiceCalculator { A = 10, B = 5 };

            var result = calculator.MultiplicationInt();


            Assert.AreEqual(50, result);
        }

        [Test]
        public void Minus_SubtractsTwoNumbers()
        {

            var calculator = new ServiceCalculator { A = 10, B = 5 };


            var result = calculator.Minus();


            Assert.AreEqual(5, result);
        }
    }
}