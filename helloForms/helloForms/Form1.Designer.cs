namespace helloForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(309, 34);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 0;
            label1.Text = "Sistema IMC";
            label1.Click += Form1_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(40, 135);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 1;
            label2.Text = "Peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(26, 205);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 18F);
            txtAltura.Location = new Point(132, 205);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(226, 47);
            txtAltura.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 18F);
            txtPeso.Location = new Point(132, 135);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(226, 47);
            txtPeso.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(320, 282);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(210, 61);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14F);
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(40, 382);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(123, 32);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Button btnCalcular;
        private Label lblResultado;
    }
}