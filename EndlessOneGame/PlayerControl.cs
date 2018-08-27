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
    public partial class PlayerControl : UserControl
    {
        private Player mPlayer;

        public event EventHandler PlayerDoSomething;

        public PlayerControl()
        {
            InitializeComponent();
        }

        public void BindPlayerObject(Player player)
        {
            mPlayer = player;
        }

        public void UpdateControls()
        {
            if (mPlayer != null)
            {
                mLifeParamControl.ParamValue = mPlayer.Life;
                mLibraryParamControl.ParamValue = mPlayer.Library;
                mHandParamControl.ParamValue = mPlayer.Hand;
                mGraveyardParamControl.ParamValue = mPlayer.Graveyard;

                mPlayIslandButton.Enabled = mPlayer.CanPlayIsland();
                mPlayEndlessOneButton.Enabled = mPlayer.CanPlayEndlessOne();
                mPlayBouncerButton.Enabled = mPlayer.CanPlayBouncer();
                mEndTurnButton.Enabled = mPlayer.CanEndTurn();

                mIslandListControl.UpdateCount(mPlayer.IslandList);
                mEndlessOneListControl.UpdateItems(mPlayer.EndlessOneList);
            }
        }

        private void PlayerControl_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void PlayLandButton_Click(object sender, EventArgs e)
        {
            mPlayer.PlayIsland();
            PlayerDoSomething?.Invoke(this, EventArgs.Empty);
        }

        private void PlayEndlessOneButton_Click(object sender, EventArgs e)
        {
            int powerToughness = PlayEndlessOneDialog.InputPowerToughnessFromDialog(mPlayer.PayableMana);
            mPlayer.PlayEndlessOne(powerToughness);
            PlayerDoSomething?.Invoke(this, EventArgs.Empty);
        }

        private void PlayBouncerButton_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = SelectEndlessOneDialog.SelectEndlessOneIndicesFromDialog(
                mPlayer.EnemyEndlessOneList,
                false,
                mPlayer.BouncerName + "の対象を選択");
            if (selectedIndices.Count > 0)
            {
                mPlayer.PlayBouncer(selectedIndices[0]);
                PlayerDoSomething?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            mPlayer.EndTurn();
            PlayerDoSomething?.Invoke(this, EventArgs.Empty);
        }
    }
}
