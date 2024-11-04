using Strategy.Carry;
using Strategy.Shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public abstract class Robot
    {
        protected IShoot shootBehaviour;
        protected ICarry carryBehaviour;

        public Robot() 
        { 
            shootBehaviour = new CantShoot();
            carryBehaviour = new CanCarry();
        }

        public void SetShootBehaviour(IShoot NewShootBehaviour)
        {
            shootBehaviour = NewShootBehaviour;
        }

        public void SetCarryBehaviour(ICarry NewCarryBehaviour)
        {
            carryBehaviour = NewCarryBehaviour;
        }

        public void Move()
        {
            Console.WriteLine("I'm moving");
        }

        public void Shoot()
        {
            shootBehaviour.Shoot();
        }

        public void Carry()
        {
            carryBehaviour.Carry();
        }

        public abstract void Voice();

    }
}
