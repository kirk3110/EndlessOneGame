namespace EndlessOneGame
{
    partial class EndlessOneListControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mTitleLabel = new System.Windows.Forms.Label();
            this.mListView = new System.Windows.Forms.ListView();
            this.mPowerToughnessColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mTappedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mSickColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mTitleLabel
            // 
            this.mTitleLabel.AutoSize = true;
            this.mTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.mTitleLabel.Name = "mTitleLabel";
            this.mTitleLabel.Size = new System.Drawing.Size(57, 12);
            this.mTitleLabel.TabIndex = 0;
            this.mTitleLabel.Text = "クリーチャー";
            // 
            // mListView
            // 
            this.mListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mPowerToughnessColumn,
            this.mTappedColumn,
            this.mSickColumn});
            this.mListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mListView.Location = new System.Drawing.Point(0, 35);
            this.mListView.Name = "mListView";
            this.mListView.Size = new System.Drawing.Size(200, 235);
            this.mListView.TabIndex = 1;
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
            // EndlessOneListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mListView);
            this.Controls.Add(this.mTitleLabel);
            this.Name = "EndlessOneListControl";
            this.Size = new System.Drawing.Size(200, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mTitleLabel;
        private System.Windows.Forms.ListView mListView;
        private System.Windows.Forms.ColumnHeader mPowerToughnessColumn;
        private System.Windows.Forms.ColumnHeader mTappedColumn;
        private System.Windows.Forms.ColumnHeader mSickColumn;
    }
}
