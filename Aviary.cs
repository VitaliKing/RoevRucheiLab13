using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aviary
    {
        public string Number { get; set; }
        public Animal Animal { get; set; }

        private Aviary() { }

        public Aviary(Zoo Name) { this.Number = Number; }
    }
}
