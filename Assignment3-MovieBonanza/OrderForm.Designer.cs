namespace Assignment3_MovieBonanza
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDPurchaseLabel = new System.Windows.Forms.Label();
            this.DVDCheckBox = new System.Windows.Forms.CheckBox();
            this.DVDOrderLabel = new System.Windows.Forms.Label();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(589, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this._printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.streamToolStripMenuItem.Text = "Strea&m";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this._stream_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cancelToolStripMenuItem.Text = "&Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this._cancel_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(500, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancel_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(12, 430);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 23);
            this.StreamButton.TabIndex = 2;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this._stream_Click);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(304, 397);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Movie Selected";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(6, 28);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(151, 22);
            this.TitleTextBox.TabIndex = 2;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(6, 63);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(151, 22);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(0, 91);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(300, 300);
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.DVDPurchaseLabel);
            this.OrderGroupBox.Controls.Add(this.DVDCheckBox);
            this.OrderGroupBox.Controls.Add(this.DVDOrderLabel);
            this.OrderGroupBox.Controls.Add(this.DVDTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.TotalTextBox);
            this.OrderGroupBox.Controls.Add(this.TaxLabel);
            this.OrderGroupBox.Controls.Add(this.TaxTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.CostLabel);
            this.OrderGroupBox.Controls.Add(this.CostTextBox);
            this.OrderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBox.Location = new System.Drawing.Point(338, 27);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(237, 253);
            this.OrderGroupBox.TabIndex = 4;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // DVDPurchaseLabel
            // 
            this.DVDPurchaseLabel.AutoSize = true;
            this.DVDPurchaseLabel.Location = new System.Drawing.Point(13, 71);
            this.DVDPurchaseLabel.Name = "DVDPurchaseLabel";
            this.DVDPurchaseLabel.Size = new System.Drawing.Size(66, 16);
            this.DVDPurchaseLabel.TabIndex = 11;
            this.DVDPurchaseLabel.Text = "Buy DVD:";
            // 
            // DVDCheckBox
            // 
            this.DVDCheckBox.AutoSize = true;
            this.DVDCheckBox.Location = new System.Drawing.Point(104, 67);
            this.DVDCheckBox.Name = "DVDCheckBox";
            this.DVDCheckBox.Size = new System.Drawing.Size(65, 20);
            this.DVDCheckBox.TabIndex = 10;
            this.DVDCheckBox.Text = "$10.00";
            this.DVDCheckBox.UseVisualStyleBackColor = true;
            this.DVDCheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // DVDOrderLabel
            // 
            this.DVDOrderLabel.AutoSize = true;
            this.DVDOrderLabel.Location = new System.Drawing.Point(12, 111);
            this.DVDOrderLabel.Name = "DVDOrderLabel";
            this.DVDOrderLabel.Size = new System.Drawing.Size(77, 16);
            this.DVDOrderLabel.TabIndex = 9;
            this.DVDOrderLabel.Text = "DVD Order:";
            this.DVDOrderLabel.Visible = false;
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DVDTextBox.Location = new System.Drawing.Point(104, 108);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.ReadOnly = true;
            this.DVDTextBox.Size = new System.Drawing.Size(100, 22);
            this.DVDTextBox.TabIndex = 8;
            this.DVDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DVDTextBox.Visible = false;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(12, 220);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(79, 16);
            this.GrandTotalLabel.TabIndex = 7;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(104, 217);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 6;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(12, 182);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(72, 16);
            this.TaxLabel.TabIndex = 5;
            this.TaxLabel.Text = "Sales Tax:";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTextBox.Location = new System.Drawing.Point(104, 182);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.TaxTextBox.TabIndex = 4;
            this.TaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(12, 147);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(66, 16);
            this.SubTotalLabel.TabIndex = 3;
            this.SubTotalLabel.Text = "SubTotal:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(104, 144);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubTotalTextBox.TabIndex = 2;
            this.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(13, 34);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(78, 16);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Movie Cost:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(104, 28);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 22);
            this.CostTextBox.TabIndex = 0;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(241, 430);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 465);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Order Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label DVDPurchaseLabel;
        private System.Windows.Forms.CheckBox DVDCheckBox;
        private System.Windows.Forms.Label DVDOrderLabel;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Button BackButton;
    }
}