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
    public partial class PlayerParamControl : UserControl
    {
        public string Title
        {
            get { return mTitleLabel.Text; }
            set { mTitleLabel.Text = value; }
        }

        public int ParamValue
        {
            get
            {
                return int.Parse(mParamValueLabel.Text);
            }

            set
            {
                mParamValueLabel.Text = value.ToString();
            }
        }

        public PlayerParamControl()
        {
            InitializeComponent();
        }
    }
}
