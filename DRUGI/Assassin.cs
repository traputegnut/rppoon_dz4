using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRUGI
{
    class Assassin:Champion
    {
        string ability;
        public Assassin(string ability)
        {
            this.ability = ability;
        }
        public override void Attack()
        {
            Console.WriteLine($"Attack - {ability}");
        }
    }
}
