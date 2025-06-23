using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarenhieghttoCelcius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCelsuis_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            double Fahrenheit = 0;

            celsius = double.Parse(txtCelsuis.Text);

            Fahrenheit = (celsius * 9 / 5) + 32;

            txtFahrenheit.Text = Fahrenheit.ToString();
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
