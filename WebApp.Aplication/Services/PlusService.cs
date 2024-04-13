using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Aplication.Services;

public class PlusService : DivideService
{
    public double IntPlus()
    {
        return A + B;
    }
}
