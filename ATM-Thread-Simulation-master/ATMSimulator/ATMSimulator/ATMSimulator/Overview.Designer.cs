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
            this.SemaStatus = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(56, 139);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(366, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "How many ATM\'s do you want to run";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.Transparent;
            this.OneButton.Location = new System.Drawing.Point(61, 178);
            this.OneButton.Margin = new System.Windows.Forms.Padding(2);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(52, 51);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.Transparent;
            this.TwoButton.Location = new System.Drawing.Point(117, 178);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(2);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(52, 51);
            this.TwoButton.TabIndex = 2;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.Transparent;
            this.ThreeButton.Location = new System.Drawing.Point(173, 178);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(52, 51);
            this.ThreeButton.TabIndex = 3;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.Transparent;
            this.FourButton.Location = new System.Drawing.Point(229, 178);
            this.FourButton.Margin = new System.Windows.Forms.Padding(2);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(52, 51);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // SemaStatus
            // 
            this.SemaStatus.AutoSize = true;
            this.SemaStatus.BackColor = System.Drawing.Color.Transparent;
            this.SemaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemaStatus.Location = new System.Drawing.Point(56, 249);
            this.SemaStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemaStatus.Name = "SemaStatus";
            this.SemaStatus.Size = new System.Drawing.Size(361, 26);
            this.SemaStatus.TabIndex = 5;
            this.SemaStatus.Text = "Do you want semaphore protection?";
            this.SemaStatus.Click += new System.EventHandler(this.SemaStatus_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.Location = new System.Drawing.Point(61, 288);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(52, 51);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Yes";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.Location = new System.Drawing.Point(117, 288);
            this.NoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(52, 51);
            this.NoButton.TabIndex = 7;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(114, 86);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(240, 26);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Semaphore Status : On";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMSimulator.Properties.Resources.overviewbackground;
            this.ClientSize = new System.Drawing.Size(466, 414);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SemaStatus);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label SemaStatus;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}