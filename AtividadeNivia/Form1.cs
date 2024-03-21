using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeNivia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();
            txtVendas.Clear();
            txtCarros.Clear();
            txtRecebe.Clear();
            txtPorcentagem.Clear();
            txtResultado.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRecebe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSalario_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           double txtSal, txtCar, txtVenda, resultPorc, result;

            txtSal = Convert.ToDouble(txtSalario.Text);
            txtCar = Convert.ToDouble(txtCarros.Text);
            txtVenda = Convert.ToDouble(txtVendas.Text);


            resultPorc = txtVenda * 0.05;
            result = txtSal + txtCar + resultPorc;

            txtResultado.Text = result.ToString();
            txtPorcentagem.Text = resultPorc.ToString();


        }

        private void txtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
