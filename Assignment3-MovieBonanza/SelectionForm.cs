using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// App name: Movie Bonanza	
// Author's name: Caitlin Foster	        Student	ID: 200311158
// App Creation	Date: March 5th 2017  
// App description: This application allows a user to select a movie from a given list to stream. 

namespace Assignment3_MovieBonanza
{
    public partial class SelectionForm : Form
    {

        //PRIVATE INSTANCE VARIABLES 

        public SplashForm previousForm;

        private string _movieTitle;
        private string _genre;
        private double _cost;

        public string _picture;
        public List<TextBox> _movie;

        //CONSTRUCTOR++++++++++++++++++++++
        public SelectionForm()
        {
            InitializeComponent();
            this._movie = new List<TextBox>();
        }

        ////PRIVATE METHODS++++++++++++++++++++
       
        /// <summary>
        /// this method sees which movie has been selected and stores the title and genre and reprints them in the appropriate textboxes to notify the user of their selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //see what movie was selected and save values
            if (MovieListView.SelectedItems.Count > 0)
            {
                this._movieTitle = MovieListView.SelectedItems[0].Text;
                this._genre = MovieListView.SelectedItems[0].SubItems[1].Text;               
            }

            //what picture should be loaded
            if (MovieListView.SelectedItems.Count == 0)
            {
                _picture = "50-FirstDates.jpg";
            }
            /*else if (MovieListView.SelectedItems.Count == 1)
            {
                _picture = "Dinosaur.jpg";
            }*/
            else if (MovieListView.SelectedItems.Count == 2)
            {
                _picture = "Beauty-and-the-Beast.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 3)
            {
                _picture = "Divergent.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 4)
            {
                _picture = "DontBreath.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 5)
            {
                _picture = "Furious_7.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 6)
            {
                _picture = "HolidayInn.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 7)
            {
                _picture = "IronMan.JPG";
            }
            else if (MovieListView.SelectedItems.Count == 8)
            {
                _picture = "laLaLand.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 9)
            {
                _picture = "legoMovie.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 10)
            {
                _picture = "Logan.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 11)
            {
                _picture = "Mulan.jpeg";
            }
            else if (MovieListView.SelectedItems.Count == 12)
            {
                _picture = "Stargate.jpeg";
            }
            else if (MovieListView.SelectedItems.Count == 13)
            {
                _picture = "Sound_of_music.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 14)
            {
                _picture = "TheMummy.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 15)
            {
               _picture = "Proposal.jpg";
            }
            else if (MovieListView.SelectedItems.Count == 16)
            {  
                _picture = "Ring.jpg";
            }

            MoviePictureBox.Load(this._picture);
            TitleTextBox.Text = this._movieTitle;
            CategoryTextBox.Text = this._genre;
            _calculateCost();
            CostTextBox.Text = this._cost.ToString();
            

            //save values to movie array
            this._movie.Add(TitleTextBox);
            this._movie.Add(CategoryTextBox);
            this._movie.Add(CostTextBox);
            
            NextButton.Enabled = true;
        }

        //PUBLIC PROPERTIES++++++++++++++++++

        /// <summary>
        /// This method assigns the cost of the movie based off the genre
        /// </summary>
        public void _calculateCost()
        {
            if (_genre == "Sci-Fi")
            {
                this._cost = 2.99;
            }
            else if (_genre == "Comedy")
            {
                this._cost = 1.99;
            }
            else if (_genre == "Action")
            {
                this._cost = 2.99;
            }
            else if (_genre == "Musical")
            {
                this._cost = 1.99;
            }
            else if (_genre == "Family")
            {
                this._cost = 0.99;
            }
            else if (_genre == "Thriller")
            {
                this._cost = 1.99;
            }
            else if (_genre == "New Release")
            {
                this._cost = 4.99;
            }
        }

        /// <summary>
        /// this method changes the application to the order form when the next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            OrderForm orderForm = new OrderForm();

            // pass a reference from the current form to the next form
            orderForm.previousForm = this;

            orderForm.Show();
            this.Hide();
        }
    }
}
