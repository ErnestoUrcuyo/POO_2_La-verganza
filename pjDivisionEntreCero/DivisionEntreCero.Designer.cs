namespace pjDivisionEntreCero
{
    partial class DivisionEntreCero
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumerador = new System.Windows.Forms.TextBox();
            this.txtDenominador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERADOR";
            // 
            // txtNumerador
            // 
            this.txtNumerador.Location = new System.Drawing.Point(140, 38);
            this.txtNumerador.Name = "txtNumerador";
            this.txtNumerador.Size = new System.Drawing.Size(100, 23);
            this.txtNumerador.TabIndex = 1;
            // 
            // txtDenominador
            // 
            this.txtDenominador.Location = new System.Drawing.Point(140, 81);
            this.txtDenominador.Name = "txtDenominador";
            this.txtDenominador.Size = new System.Drawing.Size(100, 23);
            this.txtDenominador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "DENOMINADOR";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(96, 130);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(177, 128);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(51, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // DivisionEntreCero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 172);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenominador);
            this.Controls.Add(this.txtNumerador);
            this.Controls.Add(this.label1);
            this.Name = "DivisionEntreCero";
            this.Text = "División entre cero";
            this.Load += new System.EventHandler(this.DivisionEntreCero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumerador;
        private TextBox txtDenominador;
        private Label label2;
        private Button btnDividir;
        private Label lblResultado;
    }
}