using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessOneGame
{
    public partial class IslandListControl : UserControl
    {
        public int UntappedIslandCount
        {
            get
            {
                return mUntappedIslandCountControl.ParamValue;
            }

            set
            {
                mUntappedIslandCountControl.ParamValue = value;
            }
        }
 
        public int TappedIslandCount
        {
            get
            {
                return mTappedIslandCountControl.ParamValue;
            }

            set
            {
                mTappedIslandCountControl.ParamValue = value;
            }
        }

        public void UpdateCount(List<Island> islandList)
        {
            TappedIslandCount = islandList.Count(island => island.Tapped);
            UntappedIslandCount = islandList.Count(island => !island.Tapped);
        }

        public IslandListControl()
        {
            InitializeComponent();
        }
    }
}
