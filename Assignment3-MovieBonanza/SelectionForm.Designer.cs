namespace Assignment3_MovieBonanza
{
    partial class SelectionForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "50 First Dates",
            "Comedy"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dinosaur",
            "Family"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Beauty and The Beast (2017)",
            "New Release"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Divergent",
            "Action"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Don\'t Breath",
            "Thriller"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fast and Furious 7",
            "Action"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Holiday Inn",
            "Musical"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iron Man",
            "Action"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "La La Land",
            "New Release"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lego Movie",
            "Family"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Logan",
            "New Release"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mulan",
            "Family"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Stargate",
            "Sci-Fi"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "The Sound of Music",
            "Musical"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "The Mummy",
            "Sci-Fi"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "The Proposal",
            "Comedy"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "The Ring",
            "Thriller"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "New Releases",
            "$4.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Comedy",
            "$1.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Family",
            "$0.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sci-Fi",
            "$2.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "Musical",
            "$1.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "Thriller",
            "$1.99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "Action",
            "$2.99"}, -1);
            this.MovieListView = new System.Windows.Forms.ListView();
            this.Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceListView = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieListView
            // 
            this.MovieListView.AllowColumnReorder = true;
            this.MovieListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Movie,
            this.Genre});
            this.MovieListView.GridLines = true;
            this.MovieListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MovieListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17});
            this.MovieListView.Location = new System.Drawing.Point(18, 18);
            this.MovieListView.Margin = new System.Windows.Forms.Padding(9);
            this.MovieListView.MultiSelect = false;
            this.MovieListView.Name = "MovieListView";
            this.MovieListView.Size = new System.Drawing.Size(253, 150);
            this.MovieListView.TabIndex = 1;
            this.MovieListView.TileSize = new System.Drawing.Size(200, 30);
            this.MovieListView.UseCompatibleStateImageBehavior = false;
            this.MovieListView.View = System.Windows.Forms.View.Details;
            // 
            // Movie
            // 
            this.Movie.Text = "Movie";
            this.Movie.Width = 150;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 80;
            // 
            // PriceListView
            // 
            this.PriceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.Price});
            this.PriceListView.Enabled = false;
            this.PriceListView.GridLines = true;
            this.PriceListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PriceListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.PriceListView.Location = new System.Drawing.Point(18, 180);
            this.PriceListView.MultiSelect = false;
            this.PriceListView.Name = "PriceListView";
            this.PriceListView.Scrollable = false;
            this.PriceListView.Size = new System.Drawing.Size(130, 150);
            this.PriceListView.TabIndex = 2;
            this.PriceListView.UseCompatibleStateImageBehavior = false;
            this.PriceListView.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 80;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Location = new System.Drawing.Point(18, 345);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(244, 150);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(76, 26);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(142, 22);
            this.TitleTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(76, 68);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(142, 22);
            this.CostTextBox.TabIndex = 4;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(76, 109);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(142, 22);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(7, 71);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(38, 16);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(37, 16);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(7, 112);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(66, 16);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(283, 18);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(300, 320);
            this.MoviePictureBox.TabIndex = 4;
            this.MoviePictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(508, 472);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 498);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.PriceListView);
            this.Controls.Add(this.MovieListView);
            this.Name = "SelectionForm";
            this.Text = "Selection Form";
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MovieListView;
        private System.Windows.Forms.ColumnHeader Movie;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ListView PriceListView;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

