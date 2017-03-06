namespace Assignment3_MovieBonanza
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.ChargedLabel = new System.Windows.Forms.Label();
            this.StreamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(147, 175);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this._oKButton_Click);
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.AutoSize = true;
            this.ThanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanksLabel.Location = new System.Drawing.Point(12, 9);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(363, 25);
            this.ThanksLabel.TabIndex = 1;
            this.ThanksLabel.Text = "Thank you for using Movie Bonanza!";
            // 
            // ChargedLabel
            // 
            this.ChargedLabel.AutoSize = true;
            this.ChargedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargedLabel.Location = new System.Drawing.Point(56, 58);
            this.ChargedLabel.Name = "ChargedLabel";
            this.ChargedLabel.Size = new System.Drawing.Size(276, 20);
            this.ChargedLabel.TabIndex = 2;
            this.ChargedLabel.Text = "Your credit Card has been charged ....";
            // 
            // StreamLabel
            // 
            this.StreamLabel.AutoSize = true;
            this.StreamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamLabel.Location = new System.Drawing.Point(56, 107);
            this.StreamLabel.Name = "StreamLabel";
            this.StreamLabel.Size = new System.Drawing.Size(216, 20);
            this.StreamLabel.TabIndex = 3;
            this.StreamLabel.Text = ".... will begin streaming shortly";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 210);
            this.ControlBox = false;
            this.Controls.Add(this.StreamLabel);
            this.Controls.Add(this.ChargedLabel);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.Label ChargedLabel;
        private System.Windows.Forms.Label StreamLabel;
    }
}