using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Americano : Coffee
    {
        public override void Brew()
        {
            if(CheckResourceAvailability(30, 0, 15))
            {
                Console.WriteLine("Brewing Americano");
                Thread.Sleep(2000);
                Console.WriteLine("Enjoy your Americano");
            }
        }
    }
}
