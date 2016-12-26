using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal(string Name, string Type)
        {
            this.Name = Name;
            this.Type = Type;
        }
    }
}
