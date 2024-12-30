using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class PainfulStabs : AbstractPower
    {
        public PainfulStabs() : base("PainfulStabs", 1, PowerType.Buff)
        {
        }
        public override void OnHurt(ref int amount)
        {
            
        }
    }
}
