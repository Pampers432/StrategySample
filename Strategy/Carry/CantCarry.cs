using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Carry
{
    internal class CantCarry : ICarry
    {
        public void Carry()
        {
            Console.WriteLine("I can't carry");
        }
    }
}
