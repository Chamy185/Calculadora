using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Para usar los componentes de alarma1
using System.Media; //Para usar los componentes de alarma1
using CSCore.SoundOut; //Para usar los componentes de al


namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        String alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void trmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if (lblHora.Text == alarma1)
            {
              SoundPlayer player = new SoundPlayer(@"C:\Users\1107473901-35599\source\repos\Calculadora\Calculadora\Sonidos\freesound_community-minecraft-calm-sound-effect-46382.wav");
                player.Play();
            }
        }

        private void alarrma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           alarma1= Interaction.InputBox("Ingrese la hora","Sistema","00:00:00 x.x");
        }
    }
}
