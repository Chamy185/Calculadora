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
            tpRegistro = new TabPage();
            tpMostrar = new TabPage();
            btnRegistar = new Button();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtpRegistro = new DateTimePicker();
            tcMostrar.SuspendLayout();
            tpRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // tcMostrar
            // 
            tcMostrar.Controls.Add(tpRegistro);
            tcMostrar.Controls.Add(tpMostrar);
            tcMostrar.Location = new Point(12, 24);
            tcMostrar.Name = "tcMostrar";
            tcMostrar.SelectedIndex = 0;
            tcMostrar.Size = new Size(765, 396);
            tcMostrar.TabIndex = 0;
            // 
            // tpRegistro
            // 
            tpRegistro.Controls.Add(btnRegistar);
            tpRegistro.Controls.Add(txtApellidos);
            tpRegistro.Controls.Add(txtNombre);
            tpRegistro.Controls.Add(label2);
            tpRegistro.Controls.Add(label1);
            tpRegistro.Controls.Add(dtpRegistro);
            tpRegistro.Location = new Point(4, 24);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Padding = new Padding(3);
            tpRegistro.Size = new Size(757, 368);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            tpRegistro.UseVisualStyleBackColor = true;
            // 
            // tpMostrar
            // 
            tpMostrar.Location = new Point(4, 24);
            tpMostrar.Name = "tpMostrar";
            tpMostrar.Padding = new Padding(3);
            tpMostrar.Size = new Size(757, 368);
            tpMostrar.TabIndex = 1;
            tpMostrar.Text = "Mostrar";
            tpMostrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(549, 234);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(75, 23);
            btnRegistar.TabIndex = 11;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(30, 216);
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
            label2.Location = new Point(30, 161);
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
            // dtpRegistro
            // 
            dtpRegistro.Location = new Point(19, 311);
            dtpRegistro.Name = "dtpRegistro";
            dtpRegistro.Size = new Size(233, 23);
            dtpRegistro.TabIndex = 6;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcMostrar);
            Name = "FrmRegistro";
            Text = "Registro Alumnos";
            tcMostrar.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            tpRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMostrar;
        private TabPage tpRegistro;
        private TabPage tpMostrar;
        private Button btnRegistar;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpRegistro;
    }
}