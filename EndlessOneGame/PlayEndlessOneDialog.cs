using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessOneGame
{
    public partial class PlayEndlessOneDialog : Form
    {
        private int mMaxPowerToughness;
        private int mPowerToughnessInput;

        static public int InputPowerToughnessFromDialog(int maxPowerToughness)
        {
            var dialog = new PlayEndlessOneDialog(maxPowerToughness);
            dialog.ShowDialog();

            int input = dialog.mPowerToughnessInput;

            dialog.Dispose();

            return input;
        }

        private PlayEndlessOneDialog(int maxPowerToughness)
        {
            mMaxPowerToughness = maxPowerToughness;

            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mPowerToughnessInput = int.Parse(mPowerToughnessInputBox.Text);
            Close();
        }

        private void PowerToughnessInputBox_TextChanged(object sender, EventArgs e)
        {
            mPlayButton.Enabled = ValidateInput();
        }

        private bool ValidateInput()
        {
            bool parsable = int.TryParse(mPowerToughnessInputBox.Text, out int input);

            if (parsable)
            {
                return (0 <= input && input <= mMaxPowerToughness);
            }

            return false;
        }
    }
}
