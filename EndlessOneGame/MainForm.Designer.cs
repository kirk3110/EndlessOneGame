namespace EndlessOneGame
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.playerControl2 = new EndlessOneGame.PlayerControl();
            this.playerControl1 = new EndlessOneGame.PlayerControl();
            this.SuspendLayout();
            // 
            // playerControl2
            // 
            this.playerControl2.Location = new System.Drawing.Point(585, 12);
            this.playerControl2.Name = "playerControl2";
            this.playerControl2.Size = new System.Drawing.Size(550, 380);
            this.playerControl2.TabIndex = 1;
            this.playerControl2.PlayerDoSomething += new System.EventHandler(this.PlayerControl2_PlayerDoSomething);
            // 
            // playerControl1
            // 
            this.playerControl1.Location = new System.Drawing.Point(12, 12);
            this.playerControl1.Name = "playerControl1";
            this.playerControl1.Size = new System.Drawing.Size(550, 380);
            this.playerControl1.TabIndex = 0;
            this.playerControl1.PlayerDoSomething += new System.EventHandler(this.PlayerControl1_PlayerDoSomething);
            this.playerControl1.Load += new System.EventHandler(this.playerControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 403);
            this.Controls.Add(this.playerControl2);
            this.Controls.Add(this.playerControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerControl playerControl1;
        private PlayerControl playerControl2;
    }
}

