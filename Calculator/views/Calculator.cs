using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_grafiques.views
{
    public partial class Calculator : Form
    {
        private String optext;

        public Calculator()
        {
            InitializeComponent();
            optext = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = btn0.Text;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {

        }

    }
}
