using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOOPlesson
{

    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Load...");

            isLoaded = true;

            Console.WriteLine("Loaded!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Gun is not loaded");
                Reload();
            }

            Console.WriteLine("Shot - shot\n");
            isLoaded = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
            Console.ReadLine();
        }
    }
}
