using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOPlesson
{

    abstract class Weapon
    {
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Shot");
        }
    }

    class Bow : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Bow");
        }
    }

    class LaserGun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("laser");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}
