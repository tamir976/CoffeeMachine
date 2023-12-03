using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine
{
    public class Cappuccino : Coffee
    {
        private int sleep = 2000;
        public override void Brew()
        {
            if(CheckResourceAvailability(30, 50, 15))
            {
                Console.WriteLine("Brewing Cappuccino");
                Thread.Sleep(sleep);
                Console.WriteLine("Enjoy your Cappuccino");
            }
        }
    }
}
