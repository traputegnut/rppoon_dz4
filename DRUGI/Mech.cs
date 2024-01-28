using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRUGI
{
    class Mech:Champion
    {
        string specialEffect;
        public Mech(string specialEffect)
        {
            this.specialEffect = specialEffect;
        }
        public override void Attack()
        {
            Console.WriteLine($"Attack - {specialEffect}");
        }
    }
}
