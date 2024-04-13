using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.ValueNumbers;

namespace WebApp.Aplication.Services;

public class DivideService : Numbers
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
}
