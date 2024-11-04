using Strategy.Classes;
using Strategy.Shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Robots
{
    public class Bot : Robot
    {
        public override void Voice()
            {
                Console.WriteLine("I'm Bot");
            }
        }
}

