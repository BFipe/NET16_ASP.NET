using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Homework_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("potato", 15, 25, "Belarus"),
                new Ingredient("salad", 10, 5, "France"),
                new Ingredient("pork chop", 30.5, 155, "UK"),
                new Ingredient("milk", 8, 5.5, "Russia")
            };

            Diet diet = new Diet("Diet1", "Ilya", "ABCDE12", ingredients);

            var jsonSerializedDiet = JsonConvert.SerializeObject(diet, Formatting.Indented);
            Console.WriteLine(jsonSerializedDiet);
        }
    }
}
