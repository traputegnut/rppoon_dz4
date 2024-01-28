using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRUGI
{
    class MechFactory:ChampionFactory
    {
        public override Champion SpawnChampion()
        {
            return new Mech();
        }
    }
}
