namespace Calculadora.Formularios
{
    partial class frmTemporizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            trmHora = new System.Windows.Forms.Timer(components);
            msnAlarma = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            alarrma1ToolStripMenuItem = new ToolStripMenuItem();
            msnAlarma.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(37, 43);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(286, 55);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00 x.x";
            // 
            // trmHora
            // 
            trmHora.Enabled = true;
            trmHora.Interval = 1000;
            trmHora.Tick += trmHora_Tick;
            // 
            // msnAlarma
            // 
            msnAlarma.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            msnAlarma.Location = new Point(0, 0);
            msnAlarma.Name = "msnAlarma";
            msnAlarma.Size = new Size(361, 24);
            msnAlarma.TabIndex = 1;
            msnAlarma.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarrma1ToolStripMenuItem });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(72, 20);
            establecerToolStripMenuItem.Text = "Establecer";
            // 
            // alarrma1ToolStripMenuItem
            // 
            alarrma1ToolStripMenuItem.Name = "alarrma1ToolStripMenuItem";
            alarrma1ToolStripMenuItem.Size = new Size(180, 22);
            alarrma1ToolStripMenuItem.Text = "Alarrma 1";
            alarrma1ToolStripMenuItem.Click += alarrma1ToolStripMenuItem_Click;
            // 
            // frmTemporizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 157);
            Controls.Add(lblHora);
            Controls.Add(msnAlarma);
            MainMenuStrip = msnAlarma;
            Name = "frmTemporizadores";
            Text = "Reloj";
            msnAlarma.ResumeLayout(false);
            msnAlarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer trmHora;
        private MenuStrip msnAlarma;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem alarrma1ToolStripMenuItem;
    }
}