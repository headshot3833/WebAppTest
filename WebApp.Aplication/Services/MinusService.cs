using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.ValueNumbers;

namespace WebApp.Aplication.Services;
public class MinusService : Numbers
{
    public int Minus()
    {
        return A - B;
    }
}
