namespace Calculadora.Formularios
{
    partial class FrmRegistro
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
            tcMostrar = new TabControl();
            tpRegistros = new TabPage();
            btnRegistar = new Button();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            tpMostrar = new TabPage();
            dgvPersonas = new DataGridView();
            tcMostrar.SuspendLayout();
            tpRegistros.SuspendLayout();
            tpMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tcMostrar
            // 
            tcMostrar.Controls.Add(tpRegistros);
            tcMostrar.Controls.Add(tpMostrar);
            tcMostrar.Location = new Point(12, 24);
            tcMostrar.Name = "tcMostrar";
            tcMostrar.SelectedIndex = 0;
            tcMostrar.Size = new Size(486, 396);
            tcMostrar.TabIndex = 0;
            tcMostrar.SelectedIndexChanged += tcMostrar_SelectedIndexChanged;
            // 
            // tpRegistros
            // 
            tpRegistros.Controls.Add(btnRegistar);
            tpRegistros.Controls.Add(txtApellidos);
            tpRegistros.Controls.Add(txtNombre);
            tpRegistros.Controls.Add(label2);
            tpRegistros.Controls.Add(label1);
            tpRegistros.Controls.Add(dtpFecha);
            tpRegistros.Location = new Point(4, 24);
            tpRegistros.Name = "tpRegistros";
            tpRegistros.Padding = new Padding(3);
            tpRegistros.Size = new Size(478, 368);
            tpRegistros.TabIndex = 0;
            tpRegistros.Text = "Registros";
            tpRegistros.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(334, 209);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(75, 23);
            btnRegistar.TabIndex = 11;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(30, 187);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(154, 23);
            txtApellidos.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 132);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(30, 249);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(233, 23);
            dtpFecha.TabIndex = 6;
            // 
            // tpMostrar
            // 
            tpMostrar.Controls.Add(dgvPersonas);
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(478, 368);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(6, 6);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(466, 356);
            dgvPersonas.TabIndex = 0;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 426);
            Controls.Add(tcMostrar);
            Name = "FrmRegistro";
            Text = "Registro Alumnos";
            Load += FrmRegistro_Load;
            tcMostrar.ResumeLayout(false);
            tpRegistros.ResumeLayout(false);
            tpRegistros.PerformLayout();
            tpMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMostrar;
        private TabPage tpRegistros;
        private TabPage tpMostrar;
        private Button btnRegistar;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFecha;
        private DataGridView dgvPersonas;
    }
}