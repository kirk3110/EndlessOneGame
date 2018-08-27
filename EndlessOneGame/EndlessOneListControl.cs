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
    public partial class EndlessOneListControl : UserControl
    {
        public EndlessOneListControl()
        {
            InitializeComponent();
        }

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = mListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        public void UpdateItems(List<EndlessOne> endlessOneList)
        {
            mListView.Items.Clear();

            foreach (var endlessOne in endlessOneList)
            {
                string[] item = {
                    string.Format("{0}/{0}", endlessOne.PowerToughness),
                    endlessOne.Tapped.ToString(),
                    endlessOne.Sick.ToString()
                };
                mListView.Items.Add(new ListViewItem(item));
            }
        }
    }
}
