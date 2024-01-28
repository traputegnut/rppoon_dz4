using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRUGI
{
    class AssassinFactory:ChampionFactory
    {
        public override Champion SpawnChampion()
        {
            return new Assassin();
        }
    }
}
