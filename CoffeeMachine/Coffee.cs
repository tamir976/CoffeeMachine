using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CoffeeMachine
{
    public abstract class Coffee
    {
        public abstract void Brew();
        protected bool CheckResourceAvailability(double waterNeeded, double milkNeeded, double beansNeeded) {
            
            var resourceLevels = ReadResourceLevels();

            if (resourceLevels.Water >= waterNeeded && resourceLevels.Milk >= milkNeeded && resourceLevels.Beans >= beansNeeded)
            {
                resourceLevels.Water -= waterNeeded;
                resourceLevels.Milk -= milkNeeded;
                resourceLevels.Beans -= beansNeeded;

                SaveResourceLevels(resourceLevels);
                return true;
            }
            else
            {
                Console.WriteLine("Not enough resources for making your coffee");

                return false;
            }
        }
        public static ResourceLevels ReadResourceLevels()
        {
            string json = File.ReadAllText("D:\\Coffee machine\\CoffeeMachine\\CoffeeMachine\\resources.json");
            return JsonSerializer.Deserialize<ResourceLevels>(json);
        }
        private static void SaveResourceLevels(ResourceLevels resourceLevels) 
        {
            string json = JsonSerializer.Serialize(resourceLevels, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText("D:\\Coffee machine\\CoffeeMachine\\CoffeeMachine\\resources.json", json);
        }

    }
    public class ResourceLevels
    {
        public double Water { get; set; }
        public double Milk { get; set; }
        public double Beans { get; set; }
    }
}
