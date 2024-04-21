using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string input;
            if(radioButton1.Checked==true)
            {
                input= radioButton1.Text;
                MessageBox.Show("You have selected " + input+" Programming Language");
            }
            if(radioButton2.Checked==true)
            {
                input= radioButton2.Text;
                MessageBox.Show("You have selected " + input+ " Programming Language");

            }
            if(radioButton3.Checked==true)
            {
                input= radioButton3.Text;
                MessageBox.Show("You have selected " + input+ " Programming Language");
            }
            if(radioButton4.Checked==true)
            {
                input= radioButton4.Text;
                MessageBox.Show("You have selected " + input+" Programming Language");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
