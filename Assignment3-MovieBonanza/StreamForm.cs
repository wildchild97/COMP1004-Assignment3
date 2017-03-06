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


        //CONSTRUCTOR++++++++++++++++++++++

        public StreamForm()
        {
            InitializeComponent();
            ChargedLabel.Text = "Your credit Card has been charged " + _grandTotal;
            StreamLabel.Text = _movieTitle +" will begin streaming shortly";
        }

        //PRIVATE METHODS++++++++++++++++++++

        //PUBLIC PROPERTIES++++++++++++++++++

        private void _oKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
