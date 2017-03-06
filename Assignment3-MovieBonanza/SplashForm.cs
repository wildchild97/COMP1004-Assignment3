using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_MovieBonanza
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.previousForm = this;
            //pass a referance to the current form to the next form
            this.SplashFormTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();
        }
    }
}
