using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Homework_12
{
    internal class Diet
    {
        private string _name;
        private string _author;
        private string _code;

        public Diet(string name, string author, string code, List<Ingredient> ingredients)
        {
            Name = name;
            Author = author;
            Code = code;
            Ingredients = ingredients;
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

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullOrWhiteSpaceException(value);
                }
                _author = value;
            }
        }

        [JsonIgnore]
        public string Code
        {
            get { return _code; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullOrWhiteSpaceException(value);
                }
                _code = value;
            }
        }

        public List<Ingredient> Ingredients { get; set; }
    }
}
