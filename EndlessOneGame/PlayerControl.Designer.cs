namespace EndlessOneGame
{
    partial class PlayerControl
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
            this.components = new System.ComponentModel.Container();
            this.mPlayIslandButton = new System.Windows.Forms.Button();
            this.mPlayEndlessOneButton = new System.Windows.Forms.Button();
            this.mPlayBouncerButton = new System.Windows.Forms.Button();
            this.mAttackButton = new System.Windows.Forms.Button();
            this.mBlockButton = new System.Windows.Forms.Button();
            this.mPassButton = new System.Windows.Forms.Button();
            this.mEndTurnButton = new System.Windows.Forms.Button();
            this.mParamGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mLifeParamControl = new EndlessOneGame.PlayerParamControl();
            this.mEndlessOneListControl = new EndlessOneGame.EndlessOneListControl();
            this.mIslandListControl = new EndlessOneGame.IslandListControl();
            this.mGraveyardParamControl = new EndlessOneGame.PlayerParamControl();
            this.mLibraryParamControl = new EndlessOneGame.PlayerParamControl();
            this.mHandParamControl = new EndlessOneGame.PlayerParamControl();
            this.mPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mParamGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mPlayIslandButton
            // 
            this.mPlayIslandButton.Enabled = false;
            this.mPlayIslandButton.Location = new System.Drawing.Point(13, 25);
            this.mPlayIslandButton.Name = "mPlayIslandButton";
            this.mPlayIslandButton.Size = new System.Drawing.Size(160, 30);
            this.mPlayIslandButton.TabIndex = 10;
            this.mPlayIslandButton.Text = "島をプレイする";
            this.mPlayIslandButton.UseVisualStyleBackColor = true;
            this.mPlayIslandButton.Click += new System.EventHandler(this.PlayLandButton_Click);
            // 
            // mPlayEndlessOneButton
            // 
            this.mPlayEndlessOneButton.Enabled = false;
            this.mPlayEndlessOneButton.Location = new System.Drawing.Point(13, 61);
            this.mPlayEndlessOneButton.Name = "mPlayEndlessOneButton";
            this.mPlayEndlessOneButton.Size = new System.Drawing.Size(160, 30);
            this.mPlayEndlessOneButton.TabIndex = 11;
            this.mPlayEndlessOneButton.Text = "果てしなきものをプレイする";
            this.mPlayEndlessOneButton.UseVisualStyleBackColor = true;
            this.mPlayEndlessOneButton.Click += new System.EventHandler(this.PlayEndlessOneButton_Click);
            // 
            // mPlayBouncerButton
            // 
            this.mPlayBouncerButton.Enabled = false;
            this.mPlayBouncerButton.Location = new System.Drawing.Point(13, 97);
            this.mPlayBouncerButton.Name = "mPlayBouncerButton";
            this.mPlayBouncerButton.Size = new System.Drawing.Size(160, 30);
            this.mPlayBouncerButton.TabIndex = 12;
            this.mPlayBouncerButton.Text = "分散／送還をプレイする";
            this.mPlayBouncerButton.UseVisualStyleBackColor = true;
            this.mPlayBouncerButton.Click += new System.EventHandler(this.PlayBouncerButton_Click);
            // 
            // mAttackButton
            // 
            this.mAttackButton.Enabled = false;
            this.mAttackButton.Location = new System.Drawing.Point(13, 133);
            this.mAttackButton.Name = "mAttackButton";
            this.mAttackButton.Size = new System.Drawing.Size(160, 30);
            this.mAttackButton.TabIndex = 13;
            this.mAttackButton.Text = "アタックする";
            this.mAttackButton.UseVisualStyleBackColor = true;
            // 
            // mBlockButton
            // 
            this.mBlockButton.Enabled = false;
            this.mBlockButton.Location = new System.Drawing.Point(13, 61);
            this.mBlockButton.Name = "mBlockButton";
            this.mBlockButton.Size = new System.Drawing.Size(160, 30);
            this.mBlockButton.TabIndex = 14;
            this.mBlockButton.Text = "ブロックする";
            this.mBlockButton.UseVisualStyleBackColor = true;
            // 
            // mPassButton
            // 
            this.mPassButton.Enabled = false;
            this.mPassButton.Location = new System.Drawing.Point(13, 97);
            this.mPassButton.Name = "mPassButton";
            this.mPassButton.Size = new System.Drawing.Size(160, 30);
            this.mPassButton.TabIndex = 15;
            this.mPassButton.Text = "何もしない";
            this.mPassButton.UseVisualStyleBackColor = true;
            // 
            // mEndTurnButton
            // 
            this.mEndTurnButton.Enabled = false;
            this.mEndTurnButton.Location = new System.Drawing.Point(13, 169);
            this.mEndTurnButton.Name = "mEndTurnButton";
            this.mEndTurnButton.Size = new System.Drawing.Size(160, 30);
            this.mEndTurnButton.TabIndex = 16;
            this.mEndTurnButton.Text = "ターンを終わる";
            this.mEndTurnButton.UseVisualStyleBackColor = true;
            this.mEndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // mParamGroupBox
            // 
            this.mParamGroupBox.Controls.Add(this.mLifeParamControl);
            this.mParamGroupBox.Controls.Add(this.mEndlessOneListControl);
            this.mParamGroupBox.Controls.Add(this.mIslandListControl);
            this.mParamGroupBox.Controls.Add(this.mGraveyardParamControl);
            this.mParamGroupBox.Controls.Add(this.mLibraryParamControl);
            this.mParamGroupBox.Controls.Add(this.mHandParamControl);
            this.mParamGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mParamGroupBox.Name = "mParamGroupBox";
            this.mParamGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.mParamGroupBox.Size = new System.Drawing.Size(330, 370);
            this.mParamGroupBox.TabIndex = 21;
            this.mParamGroupBox.TabStop = false;
            this.mParamGroupBox.Text = "パラメータ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mEndTurnButton);
            this.groupBox1.Controls.Add(this.mPlayIslandButton);
            this.groupBox1.Controls.Add(this.mPlayEndlessOneButton);
            this.groupBox1.Controls.Add(this.mPlayBouncerButton);
            this.groupBox1.Controls.Add(this.mAttackButton);
            this.groupBox1.Location = new System.Drawing.Point(350, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(185, 215);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自分のターンの行動";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.mBlockButton);
            this.groupBox2.Controls.Add(this.mPassButton);
            this.groupBox2.Location = new System.Drawing.Point(350, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(185, 140);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相手のターンの行動";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "分散／送還をプレイする";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mLifeParamControl
            // 
            this.mLifeParamControl.Location = new System.Drawing.Point(13, 25);
            this.mLifeParamControl.Name = "mLifeParamControl";
            this.mLifeParamControl.ParamValue = 0;
            this.mLifeParamControl.Size = new System.Drawing.Size(95, 30);
            this.mLifeParamControl.TabIndex = 6;
            this.mLifeParamControl.Title = "ライフ";
            // 
            // mEndlessOneListControl
            // 
            this.mEndlessOneListControl.Location = new System.Drawing.Point(114, 86);
            this.mEndlessOneListControl.Name = "mEndlessOneListControl";
            this.mEndlessOneListControl.Size = new System.Drawing.Size(200, 271);
            this.mEndlessOneListControl.TabIndex = 19;
            // 
            // mIslandListControl
            // 
            this.mIslandListControl.Location = new System.Drawing.Point(114, 25);
            this.mIslandListControl.Name = "mIslandListControl";
            this.mIslandListControl.Size = new System.Drawing.Size(140, 55);
            this.mIslandListControl.TabIndex = 20;
            this.mIslandListControl.TappedIslandCount = 0;
            this.mIslandListControl.UntappedIslandCount = 0;
            // 
            // mGraveyardParamControl
            // 
            this.mGraveyardParamControl.Location = new System.Drawing.Point(13, 327);
            this.mGraveyardParamControl.Name = "mGraveyardParamControl";
            this.mGraveyardParamControl.ParamValue = 0;
            this.mGraveyardParamControl.Size = new System.Drawing.Size(95, 30);
            this.mGraveyardParamControl.TabIndex = 9;
            this.mGraveyardParamControl.Title = "墓地";
            // 
            // mLibraryParamControl
            // 
            this.mLibraryParamControl.Location = new System.Drawing.Point(13, 61);
            this.mLibraryParamControl.Name = "mLibraryParamControl";
            this.mLibraryParamControl.ParamValue = 0;
            this.mLibraryParamControl.Size = new System.Drawing.Size(95, 30);
            this.mLibraryParamControl.TabIndex = 7;
            this.mLibraryParamControl.Title = "ライブラリ";
            // 
            // mHandParamControl
            // 
            this.mHandParamControl.Location = new System.Drawing.Point(13, 97);
            this.mHandParamControl.Name = "mHandParamControl";
            this.mHandParamControl.ParamValue = 0;
            this.mHandParamControl.Size = new System.Drawing.Size(95, 30);
            this.mHandParamControl.TabIndex = 8;
            this.mHandParamControl.Title = "手札";
            // 
            // mPlayerBindingSource
            // 
            this.mPlayerBindingSource.DataSource = typeof(EndlessOneGame.Player);
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mParamGroupBox);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(550, 380);
            this.Load += new System.EventHandler(this.PlayerControl_Load);
            this.mParamGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mPlayerBindingSource;
        private System.Windows.Forms.Button mPlayIslandButton;
        private System.Windows.Forms.Button mPlayEndlessOneButton;
        private System.Windows.Forms.Button mPlayBouncerButton;
        private System.Windows.Forms.Button mAttackButton;
        private System.Windows.Forms.Button mBlockButton;
        private System.Windows.Forms.Button mPassButton;
        private System.Windows.Forms.Button mEndTurnButton;
        private EndlessOneListControl mEndlessOneListControl;
        private IslandListControl mIslandListControl;
        private PlayerParamControl mHandParamControl;
        private PlayerParamControl mGraveyardParamControl;
        private PlayerParamControl mLibraryParamControl;
        private PlayerParamControl mLifeParamControl;
        private System.Windows.Forms.GroupBox mParamGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}
