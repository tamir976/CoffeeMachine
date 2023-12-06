using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace CoffeeMachine
{
    public class Resource 
    {

        private ResourceLevels? resource;
        public void ResourceCheck()
        {
            resource = ReadResource();
            Console.WriteLine($"Water: {resource.Water}, \nMilk: {resource.Milk}, \nBeans: {resource.Beans}");
        }
        
        private ResourceLevels ReadResource()
        {
            return Coffee.ReadResourceLevels();
        }
    }
}
