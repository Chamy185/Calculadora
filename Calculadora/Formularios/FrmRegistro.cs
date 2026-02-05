using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellidos.Text, Fecha = dtpFecha.Value });
            MessageBox.Show("Datos registrados correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tcMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMostrar.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
            }
        }
    }
}
