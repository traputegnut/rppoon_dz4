using System;

namespace DRUGI
{
    class Program   //radi se o metodi tvornica
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.SpawnChampion(new MechFactory());
            game.SpawnChampion(new AssassinFactory());
        }
    }
}
