using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; //Permite usar el streamreader y el streamwriter para abrir y guardar archivos

namespace Calculadora.Formularios
{
    public partial class frmEditor : Form
    {
        bool saved = false; //Variable para verificar si el archivo ha sido guardado o no
        String path; //Variable para almacenar la ruta del archivo abierto o guardado
        public frmEditor()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofpEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);
                }
            }

        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Guardar();
        }

        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);

                }
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saved == false)
            {
                Guardar();
                saved = true;
            }
            else{
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);

                }
            }
        }
    }
}
