using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Shoot
{
    internal class CantShoot : IShoot
    {
        public void Shoot()
        {
            Console.WriteLine("I can't shoot");
        }
    }
}

