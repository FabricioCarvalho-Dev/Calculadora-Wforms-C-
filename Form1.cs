using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cauculadora
{
    public partial class CAUCULADORA : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao1 = "";

        public CAUCULADORA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao1 = "MULTIPLICAR";
            lblOperacao.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao1 = "SOMA";
            lblOperacao.Text = "+";


        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao1 = "SUBTRAIR";
            lblOperacao.Text = "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button_Igual_Click(object sender, EventArgs e)
        {
          valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            
          if (operacao1 == "SOMA")
            {
              txtResultado.Text = Convert.ToString(valor1 + valor2, CultureInfo.InvariantCulture);
            }

          else if(operacao1 == "SUBTRAIR")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2, CultureInfo.InvariantCulture);
            }
          else if (operacao1 == "MULTIPLICAR")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
            }
          else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
            }
        }

        private void button_divisor_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao1 = "DIVISÂO";
            lblOperacao.Text = "/";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_ponto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
    }
}
