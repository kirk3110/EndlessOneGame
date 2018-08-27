using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessOneGame
{
    public class EndlessOne : Permanent
    {
        public int PowerToughness { get; private set; }

        public bool Sick { get; private set; }

        public EndlessOne(int powerToughness)
        {
            PowerToughness = powerToughness;
            Sick = true;
        }

        public override void Untap()
        {
            base.Untap();
            Sick = false;
        }
    }
}
