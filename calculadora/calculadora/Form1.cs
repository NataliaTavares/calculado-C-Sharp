using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void somarButton_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultadoTextBox.Text);
            txtResultadoTextBox.Text = "";
            operacao = "SOMA";
            RespostaLabel.Text = "+";
        }

        private void subtrairButton_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultadoTextBox.Text);
            txtResultadoTextBox.Text = "";
            operacao = "SUBTRACAO";
            RespostaLabel.Text = "-";
        }

        private void multiplicarButton_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultadoTextBox.Text);
            txtResultadoTextBox.Text = "";
            operacao = "MULTIPLICACAO";
            RespostaLabel.Text = "X";
        }

        private void dividirButton_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultadoTextBox.Text);
            txtResultadoTextBox.Text = "";
            operacao = "DIVISAO";
            RespostaLabel.Text = "/";
        }

        private void limparTelaButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text = "";
            valor1 = 0;
            valor2 = 0;
            RespostaLabel.Text = "";
        }

        private void apagarButton_Click_1(object sender, EventArgs e)
        {
            int apaga = Convert.ToInt32(txtResultadoTextBox.Text);
            apaga = apaga / 10;

            txtResultadoTextBox.Text = Convert.ToString(apaga);

        }

        private void porcentagemButton_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtResultadoTextBox.Text);
            txtResultadoTextBox.Text = "";
            operacao = "PORCENTAGEM";
            RespostaLabel.Text = "%";
        }

        private void noveButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "9";
        }

        private void oitoButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "8";
        }

        private void seteButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "7";
        }

        private void seisButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "6";
        }

        private void cincoButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "5";
        }

        private void quatroButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "4";
        }

        private void tresButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "3";
        }

        private void doisButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "2";
        }

        private void umButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "1";
        }

        private void zeroButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += "0";
        }

        private void pontoButton_Click_1(object sender, EventArgs e)
        {
            txtResultadoTextBox.Text += ",";
        }

        private void igualButton_Click_1(object sender, EventArgs e)
        {
            valor2 = Convert.ToDecimal(txtResultadoTextBox.Text);

            if (operacao == "SOMA")
            {
                txtResultadoTextBox.Text = Convert.ToString(valor1 + valor2);
            }

            else if (operacao == "SUBTRACAO")
            {
                txtResultadoTextBox.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operacao == "DIVISAO")
            {
                txtResultadoTextBox.Text = Convert.ToString(valor1 / valor2);
            }

            else if (operacao == "MULTIPLICACAO")
            {
                txtResultadoTextBox.Text = Convert.ToString(valor1 * valor2);
            }

            else if (operacao == "PORCENTAGEM")
            {
                txtResultadoTextBox.Text = Convert.ToString(valor1 * (valor2 / 100));
            }
        }
    }
}
