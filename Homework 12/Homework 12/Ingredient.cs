using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Homework_12
{
    internal class Ingredient
    {
        private double _price;
        private double _energyCost;
        private string _name;
        private string _manufacturer;

        public Ingredient(string name, double price, double energyCost, string manufacturer)
        {
            Name = name;
            Price = price;
            EnergyCost = energyCost;
            Manufacturer = manufacturer;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullOrWhiteSpaceException(value);
                }
                _name = value;
            }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullOrWhiteSpaceException(value);
                }
                _manufacturer = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    throw new ZeroOrBelowZeroException(value);
                }

                _price = value;
            }
        }


        [JsonProperty("Energy")]
        public double EnergyCost
        {
            get { return _energyCost; }
            set 
            {
                if (value <= 0)
                {
                    throw new ZeroOrBelowZeroException(value);
                }
                _energyCost = value; 
            }
        }

    }
}
