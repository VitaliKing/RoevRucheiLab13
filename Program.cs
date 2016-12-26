using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace RoevRuchei
{    
    class Program
    {
        public static void Motion(Zoo NameOf, Zoo NameIn, Animal Who)
        {
            NameIn.Aviars[0].Animal = Who;
            NameOf.Aviars[0].Animal = null;
        }

        static void Main(string[] args)
        {
            Zoo Ruchey = new Zoo();
            Ruchey.Name = "Роев Ручей";
            Zoo Log = new Zoo();
            Log.Name = "Бобровый лог";
            Animal Alex = new Animal("Alex", "Lev");
            Animal Marty = new Animal("Marty", "Zebra");
            Ruchey.Aviars[0].Animal = Alex;
            Log.Aviars[0].Animal = Marty;

            Motion(Ruchey, Log, Alex);
            Console.ReadKey();
        }
    }
}
