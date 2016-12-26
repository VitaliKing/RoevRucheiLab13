using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Zoo
    {
        public Zoo ()
        {
            Aviars = new List<Aviary> { new Aviary(this) };
        }
        public string Name { get; set; }
        public List<Aviary> Aviars { get; set; }

        //public Zoo (string Name, List<Aviary> Aviars)
        //{
        //    this.Name = Name;
        //    this.Aviars = Aviars;
        //}

        
    }
}
