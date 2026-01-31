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
            txtVariableA.Size = new Size(100, 23);
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
            txtVariableB.Size = new Size(100, 23);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(499, 169);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(499, 238);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(label2);
            Controls.Add(txtVariableA);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "frmCalculadora";
      
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
    }
}