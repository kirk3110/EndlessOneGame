namespace EndlessOneGame
{
    partial class PlayerParamControl
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
            this.mParamValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mTitleLabel
            // 
            this.mTitleLabel.AutoSize = true;
            this.mTitleLabel.Location = new System.Drawing.Point(0, 10);
            this.mTitleLabel.Name = "mTitleLabel";
            this.mTitleLabel.Size = new System.Drawing.Size(25, 12);
            this.mTitleLabel.TabIndex = 0;
            this.mTitleLabel.Text = "title";
            // 
            // mParamValueLabel
            // 
            this.mParamValueLabel.AutoSize = true;
            this.mParamValueLabel.Location = new System.Drawing.Point(55, 10);
            this.mParamValueLabel.Name = "mParamValueLabel";
            this.mParamValueLabel.Size = new System.Drawing.Size(11, 12);
            this.mParamValueLabel.TabIndex = 1;
            this.mParamValueLabel.Text = "0";
            // 
            // PlayerParamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mParamValueLabel);
            this.Controls.Add(this.mTitleLabel);
            this.Name = "PlayerParamControl";
            this.Size = new System.Drawing.Size(95, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mTitleLabel;
        private System.Windows.Forms.Label mParamValueLabel;
    }
}
