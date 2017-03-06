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
    public partial class OrderForm : Form
    {
        //PRIVATE INSTANCE VARIABLES 


        //CONSTRUCTOR++++++++++++++++++++++

        public OrderForm()
        {
            InitializeComponent();
        }

        //PRIVATE METHODS++++++++++++++++++++

        //PUBLIC PROPERTIES++++++++++++++++++

        private void _cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _stream_Click(object sender, EventArgs e)
        {

        }

        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Show();
        }
    }
}
