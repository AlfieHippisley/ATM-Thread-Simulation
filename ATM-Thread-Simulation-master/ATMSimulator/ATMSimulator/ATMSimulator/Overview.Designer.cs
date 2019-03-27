namespace ATMSimulator
{
    partial class Overview
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(21, 103);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(239, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "How many ATM\'s ";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.Transparent;
            this.OneButton.Location = new System.Drawing.Point(27, 147);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(70, 63);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.Transparent;
            this.TwoButton.Location = new System.Drawing.Point(103, 147);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(70, 63);
            this.TwoButton.TabIndex = 2;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.Transparent;
            this.ThreeButton.Location = new System.Drawing.Point(179, 147);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(70, 63);
            this.ThreeButton.TabIndex = 3;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.Transparent;
            this.FourButton.Location = new System.Drawing.Point(255, 147);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(70, 63);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMSimulator.Properties.Resources.overviewbackground;
            this.ClientSize = new System.Drawing.Size(621, 509);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Overview";
            this.Text = "Overview Panel";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button FourButton;
    }
}