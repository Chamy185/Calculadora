namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            txtVariableA = new TextBox();
            label2 = new Label();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 53);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            label1.Click += label1_Click;
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(67, 101);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(136, 23);
            txtVariableA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 180);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "VariableB";
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(67, 262);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(136, 23);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(652, 164);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(652, 228);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Location = new Point(313, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 133);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(18, 103);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(67, 19);
            rdbDivision.TabIndex = 7;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(18, 78);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(101, 19);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(18, 53);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(53, 19);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(18, 28);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(55, 19);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(label2);
            Controls.Add(txtVariableA);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "frmCalculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVariableA;
        private Label label2;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private RadioButton rdbSuma;
    }
}