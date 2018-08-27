namespace EndlessOneGame
{
    partial class SelectEndlessOneDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mListView = new System.Windows.Forms.ListView();
            this.mPowerToughnessColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mTappedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mSickColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectButton = new System.Windows.Forms.Button();
            this.mInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mListView
            // 
            this.mListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mPowerToughnessColumn,
            this.mTappedColumn,
            this.mSickColumn});
            this.mListView.FullRowSelect = true;
            this.mListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mListView.HoverSelection = true;
            this.mListView.Location = new System.Drawing.Point(27, 49);
            this.mListView.Name = "mListView";
            this.mListView.Size = new System.Drawing.Size(200, 235);
            this.mListView.TabIndex = 2;
            this.mListView.UseCompatibleStateImageBehavior = false;
            this.mListView.View = System.Windows.Forms.View.Details;
            this.mListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_ColumnWidthChanging);
            // 
            // mPowerToughnessColumn
            // 
            this.mPowerToughnessColumn.Text = "P/T";
            this.mPowerToughnessColumn.Width = 58;
            // 
            // mTappedColumn
            // 
            this.mTappedColumn.Text = "タップ";
            // 
            // mSickColumn
            // 
            this.mSickColumn.Text = "召喚酔い";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(82, 306);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(90, 30);
            this.SelectButton.TabIndex = 13;
            this.SelectButton.Text = "選択完了";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // mInfoLabel
            // 
            this.mInfoLabel.AutoSize = true;
            this.mInfoLabel.Location = new System.Drawing.Point(113, 20);
            this.mInfoLabel.Name = "mInfoLabel";
            this.mInfoLabel.Size = new System.Drawing.Size(29, 12);
            this.mInfoLabel.TabIndex = 14;
            this.mInfoLabel.Text = "説明";
            this.mInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectEndlessOneDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 361);
            this.Controls.Add(this.mInfoLabel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.mListView);
            this.MaximizeBox = false;
            this.Name = "SelectEndlessOneDialog";
            this.Text = "ChoiceEndlessOneDialog";
            this.Load += new System.EventHandler(this.SelectEndlessOneDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mListView;
        private System.Windows.Forms.ColumnHeader mPowerToughnessColumn;
        private System.Windows.Forms.ColumnHeader mTappedColumn;
        private System.Windows.Forms.ColumnHeader mSickColumn;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label mInfoLabel;
    }
}