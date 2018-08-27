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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Player.CreateTwoPlayers();
            playerControl1.BindPlayerObject(Player.SFirstPlayer);
            playerControl2.BindPlayerObject(Player.SSecondPlayer);
        }

        private void PlayerControl1_PlayerDoSomething(object sender, EventArgs e)
        {
            playerControl1.UpdateControls();
            playerControl2.UpdateControls();
        }

        private void PlayerControl2_PlayerDoSomething(object sender, EventArgs e)
        {
            playerControl1.UpdateControls();
            playerControl2.UpdateControls();
        }

        private void playerControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
