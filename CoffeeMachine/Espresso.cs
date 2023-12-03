using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoffeeMachine
{
    public class Espresso : Coffee
    {
        public override void Brew()
        {
            if (CheckResourceAvailability(30, 0, 15))
            {
                Console.WriteLine("Brewing Espresso");
                Thread.Sleep(2000);
                Console.WriteLine("Enjoy your Espresso");
            }
        }
    }
}
