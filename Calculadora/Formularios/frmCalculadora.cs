using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = Convert.ToInt32(txtVariableA.Text);
                b = int.Parse(txtVariableB.Text);

                if(rdbSuma.Checked)
                resultado = a + b;

                if(rdbResta.Checked)
                resultado = a - b;

                if(rdbMultiplicacion.Checked)
                resultado = a * b;

                if(rdbDivision.Checked)
                resultado = a / b;

                MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();

            }
            catch (Exception)
            {
                MessageBox.Show("Errpr en la conversion de datos");
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();

        }

    }
}
