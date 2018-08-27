using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndlessOneGame
{
    public class Permanent
    {
        public bool Tapped { get; private set; } = false;

        public void Tap()
        {
            Tapped = true;
        }

        public virtual void Untap()
        {
            Tapped = false;
        }
    }
}
