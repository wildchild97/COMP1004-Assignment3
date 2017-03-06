﻿using System;
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
        public SelectionForm previousForm;

        //PRIVATE INSTANCE VARIABLES 
        private double _subTotal;
        private double _total;
        private double _tax;
        private double _DVD = 0;
        private double _cost;

        //CONSTRUCTOR++++++++++++++++++++++

        public OrderForm()
        {
            InitializeComponent();

            TitleTextBox.Text = movie[0].ToString();
            CategoryTextBox.Text = movie[1].ToString();
            CostTextBox.Text = "$" + movie[2].ToString();

            _cost = Convert.ToDouble(movie[2].ToString());

            calculatePrice();
            DVDTextBox.Text = _DVD.ToString();
            SubTotalTextBox.Text = _subTotal.ToString();
            TaxTextBox.Text = _tax.ToString();
            TotalTextBox.Text = _total.ToString();
        }

        // PUBLIC METHODS
        public static List<TextBox> movie { get; }
        public static string picture { get; }

        /// <summary>
        /// Calculates the subtotal, tax, and grand total of the users order 
        /// </summary>
        public void calculatePrice ()
        {
            _subTotal = _DVD + _cost;
            _tax = _subTotal * 0.13;
            _total = _subTotal + _tax;
        }

        //PRIVATE METHODS++++++++++++++++++++
        private void _cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _stream_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            StreamForm streamForm = new StreamForm();

            // pass a reference from the current form to the next form
            streamForm.previousForm = this;

            streamForm.Show();
            this.Hide();
        }

        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.Show();
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DVDTextBox.Visible = true;
            DVDOrderLabel.Visible = true;
            _DVD = 10;
        }
    }
}
