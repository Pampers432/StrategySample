using Strategy.Carry;
using Strategy.Classes;
using Strategy.Shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Robots
{
    internal class Defender : Robot
    {
        public Defender()
        {
            shootBehaviour = new CanShoot();
            carryBehaviour = new CantCarry();
        }
        public override void Voice()
        {
            Console.WriteLine("I'm Defender");
        }
    }
}