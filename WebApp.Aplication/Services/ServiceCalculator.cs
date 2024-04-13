using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.ValueNumbers;

namespace WebApp.AplicationCalculator.Services
{
    public class ServiceCalculator : Numbers
    {
        public double Divide()
        {
            if (B != 0)
            {
                return A / B;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }
        public double IntPlus()
        {
            return A + B;
        }
        public double MultiplicationInt()
        {
            return A * B;
        }
        public double Minus()
        {
            return A - B;
        }
    }
}
