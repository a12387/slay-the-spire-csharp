using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    internal static class Dungeon
    {
        static public AbstractPlayer Player { get; set; }

        static public void Init()
        {
            Player = new Player("Ironclad", 80);
        }
    }
}
