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
    public partial class SelectEndlessOneDialog : Form
    {
        public String InfoText
        {
            set { mInfoLabel.Text = value; }
            get { return mInfoLabel.Text; }
        }

        private List<EndlessOne> mSrcEndlessOneList;
        
        private List<int> mSelectedIndices = new List<int>();

        static public List<int> SelectEndlessOneIndicesFromDialog(
            List<EndlessOne> srcEndlessOneList, bool multiSelect, String infoText)
        {
            var dialog = new SelectEndlessOneDialog(srcEndlessOneList);
            dialog.mListView.MultiSelect = multiSelect;
            dialog.InfoText = infoText;

            dialog.ShowDialog();

            List<int> selected = dialog.mSelectedIndices;

            dialog.Dispose();

            return selected;
        }

        private SelectEndlessOneDialog(List<EndlessOne> srcEndlessOneList)
        {
            mSrcEndlessOneList = srcEndlessOneList;

            InitializeComponent();
        }

        private void SelectEndlessOneDialog_Load(object sender, EventArgs e)
        {
            foreach (var endlessOne in mSrcEndlessOneList)
            {
                string[] item = {
                    string.Format("{0}/{0}", endlessOne.PowerToughness),
                    endlessOne.Tapped.ToString(),
                    endlessOne.Sick.ToString()
                };
                mListView.Items.Add(new ListViewItem(item));
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            foreach (int index in mListView.SelectedIndices)
            {
                mSelectedIndices.Add(index);
            }
            Close();
        }

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = mListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
