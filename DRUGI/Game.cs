using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRUGI
{
    class Game
    {
        Champion champion;
        public void SpawnChampion(ChampionFactory factory)
        {
            champion = factory.SpawnChampion();
        }
    }
}
