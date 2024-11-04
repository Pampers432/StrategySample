using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Carry
{
    public class CanCarry : ICarry
    {
        public void Carry()
        {
            Console.WriteLine("I'm carry");
        }
    }
}

