using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Homework_12
{
    internal class Ingredient
    {

        public Ingredient(string name, double price, double energyCost, string manufacturer)
        {
            Name = name;
            Price = price;
            EnergyCost = energyCost;
            Manufacturer = manufacturer;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        [JsonProperty ("Energy")]
        public double EnergyCost { get; set; }
        public string Manufacturer { get; set; }
    }
}
