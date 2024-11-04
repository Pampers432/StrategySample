using Strategy.Carry;
using Strategy.Classes;
using Strategy.Shoot;

namespace Strategy.Robots
{
    public class Killer : Robot
    {
        public Killer()
        {
            shootBehaviour = new CanShoot();
            carryBehaviour = new CantCarry();
        }

        public override void Voice()
        {
            Console.WriteLine("I'm Killer");
        }
    
        
    }
}
