namespace EndlessOneGame
{
    partial class PlayEndlessOneDialog
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
            this.mLabel = new System.Windows.Forms.Label();
            this.mPowerToughnessInputBox = new System.Windows.Forms.TextBox();
            this.mPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(12, 40);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(75, 12);
            this.mLabel.TabIndex = 0;
            this.mLabel.Text = "パワー/タフネス";
            // 
            // mPowerToughnessInputBox
            // 
            this.mPowerToughnessInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mPowerToughnessInputBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.mPowerToughnessInputBox.Location = new System.Drawing.Point(109, 37);
            this.mPowerToughnessInputBox.Name = "mPowerToughnessInputBox";
            this.mPowerToughnessInputBox.ShortcutsEnabled = false;
            this.mPowerToughnessInputBox.Size = new System.Drawing.Size(63, 19);
            this.mPowerToughnessInputBox.TabIndex = 1;
            this.mPowerToughnessInputBox.Text = "1";
            this.mPowerToughnessInputBox.TextChanged += new System.EventHandler(this.PowerToughnessInputBox_TextChanged);
            // 
            // mPlayButton
            // 
            this.mPlayButton.Location = new System.Drawing.Point(48, 83);
            this.mPlayButton.Name = "mPlayButton";
            this.mPlayButton.Size = new System.Drawing.Size(90, 30);
            this.mPlayButton.TabIndex = 12;
            this.mPlayButton.Text = "プレイする";
            this.mPlayButton.UseVisualStyleBackColor = true;
            this.mPlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PlayEndlessOneDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 141);
            this.Controls.Add(this.mPlayButton);
            this.Controls.Add(this.mPowerToughnessInputBox);
            this.Controls.Add(this.mLabel);
            this.MaximizeBox = false;
            this.Name = "PlayEndlessOneDialog";
            this.Text = "PlayEndlessOneDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TextBox mPowerToughnessInputBox;
        private System.Windows.Forms.Button mPlayButton;
    }
}