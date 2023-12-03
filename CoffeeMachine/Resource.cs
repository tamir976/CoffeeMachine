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

        private Resources resource;
        public void ResourceCheck()
        {
            resource = ReadResource();
            Console.WriteLine($"Water: {resource.Water}, Milk: {resource.Milk}, Beans: {resource.Beans}");
        }
        
        private Resources ReadResource()
        {
            string json = File.ReadAllText("D:\\Coffee machine\\CoffeeMachine\\CoffeeMachine\\resources.json");
            return JsonSerializer.Deserialize<Resources>(json);
        }
    }
    public class Resources
    {
        public double Water { get; set; }
        public double Milk { get; set; }
        public double Beans { get; set; }
    }
}
