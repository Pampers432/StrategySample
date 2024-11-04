using Strategy.Carry;
using Strategy.Classes;
using Strategy.Robots;
using Strategy.Shoot;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            robots.Add(new Bot());
            robots.Add(new Defender());
            robots.Add(new Killer());

            foreach (var robot in robots)
            {
                robot.Voice();
                robot.Move();
                robot.Shoot();
                robot.Carry();

                Console.WriteLine();
            }
            Console.WriteLine("Pew Pew Pew");

            robots[1].SetShootBehaviour(new CantShoot());
            robots[1].SetCarryBehaviour(new CanCarry());
            robots[1].Voice();
            robots[1].Shoot();
            robots[1].Carry();
        }
    }
}
