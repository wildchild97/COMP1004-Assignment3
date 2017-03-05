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
            "Don\'t Scream",
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
            this.MovieListView.Size = new System.Drawing.Size(269, 232);
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
            this.PriceListView.Location = new System.Drawing.Point(18, 262);
            this.PriceListView.MultiSelect = false;
            this.PriceListView.Name = "PriceListView";
            this.PriceListView.Scrollable = false;
            this.PriceListView.Size = new System.Drawing.Size(148, 151);
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
            this.SelectionGroupBox.Location = new System.Drawing.Point(420, 153);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 429);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.PriceListView);
            this.Controls.Add(this.MovieListView);
            this.Name = "SelectionForm";
            this.Text = "Selection Form";
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
    }
}

