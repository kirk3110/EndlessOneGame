namespace EndlessOneGame
{
    partial class IslandListControl
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
            this.mUntappedIslandCountControl = new EndlessOneGame.PlayerParamControl();
            this.mTappedIslandCountControl = new EndlessOneGame.PlayerParamControl();
            this.SuspendLayout();
            // 
            // mTitleLabel
            // 
            this.mTitleLabel.AutoSize = true;
            this.mTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.mTitleLabel.Name = "mTitleLabel";
            this.mTitleLabel.Size = new System.Drawing.Size(29, 12);
            this.mTitleLabel.TabIndex = 1;
            this.mTitleLabel.Text = "土地";
            // 
            // mUntappedLandCountControl
            // 
            this.mUntappedIslandCountControl.Location = new System.Drawing.Point(45, 0);
            this.mUntappedIslandCountControl.Name = "mUntappedLandCountControl";
            this.mUntappedIslandCountControl.ParamValue = 0;
            this.mUntappedIslandCountControl.Size = new System.Drawing.Size(95, 30);
            this.mUntappedIslandCountControl.TabIndex = 2;
            this.mUntappedIslandCountControl.Title = "アンタップ";
            // 
            // mTappedLandCountControl
            // 
            this.mTappedIslandCountControl.Location = new System.Drawing.Point(45, 24);
            this.mTappedIslandCountControl.Name = "mTappedLandCountControl";
            this.mTappedIslandCountControl.ParamValue = 0;
            this.mTappedIslandCountControl.Size = new System.Drawing.Size(95, 30);
            this.mTappedIslandCountControl.TabIndex = 3;
            this.mTappedIslandCountControl.Title = "タップ";
            // 
            // IslandListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTappedIslandCountControl);
            this.Controls.Add(this.mUntappedIslandCountControl);
            this.Controls.Add(this.mTitleLabel);
            this.Name = "IslandListControl";
            this.Size = new System.Drawing.Size(140, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mTitleLabel;
        private PlayerParamControl mUntappedIslandCountControl;
        private PlayerParamControl mTappedIslandCountControl;
    }
}
