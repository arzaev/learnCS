using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOOPlesson
{

    class Gun
    {

        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Load...");

            _isLoaded = true;

            Console.WriteLine("Loaded!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Gun is not loaded");
                Reload();
            }

            Console.WriteLine("Shot - shot\n");
            _isLoaded = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: false);
            gun.Shoot();
            Console.ReadLine();
        }
    }
}
