using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace CoffeeMachine
{
    public class Resource : Coffee
    {

        public override void Brew()
        {
            
        }
        private ResourceLevels? resource;
        public void ResourceCheck()
        {
            resource = ReadResource();
            Console.WriteLine($"Water: {resource.Water}, \nMilk: {resource.Milk}, \nBeans: {resource.Beans}");
        }
        
        private ResourceLevels ReadResource()
        {
            string json = File.ReadAllText("D:\\Coffee machine\\CoffeeMachine\\CoffeeMachine\\resources.json");
            return JsonSerializer.Deserialize<ResourceLevels>(json);
        }
    }
}
