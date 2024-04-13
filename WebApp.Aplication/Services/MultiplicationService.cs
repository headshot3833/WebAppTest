using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Aplication.Services;

public class MultiplicationService : DivideService
{
    public int MultiplicationInt()
    {
        return A * B;
    }
}
