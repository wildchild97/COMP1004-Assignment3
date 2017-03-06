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
    public partial class StreamForm : Form
    {
        //PRIVATE INSTANCE VARIABLES 
        public OrderForm previousForm;


        //CONSTRUCTOR++++++++++++++++++++++

        public StreamForm()
        {
            InitializeComponent();
            ChargedLabel.Text = "Your credit Card has been charged $" + total;
            StreamLabel.Text =  movie[0].ToString() +" will begin streaming shortly";
        }

        //PUBLIC PROPERTIES++++++++++++++++++
        public static List<TextBox> movie { get; }
        public static double total { get; }

        //PRIVATE METHODS++++++++++++++++++++

        /// <summary>
        /// will terminate the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _oKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
