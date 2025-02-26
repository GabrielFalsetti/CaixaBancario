namespace CaixaBancario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblSaldo = new Label();
            label4 = new Label();
            numValor = new NumericUpDown();
            numLimite = new NumericUpDown();
            btDepositar = new Button();
            btSacar = new Button();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(50, 215);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 15F);
            lblSaldo.Location = new Point(186, 215);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(77, 28);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "R$ 0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(31, 278);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 3;
            label4.Text = "Limite:";
            // 
            // numValor
            // 
            numValor.Font = new Font("Segoe UI", 18F);
            numValor.Location = new Point(116, 32);
            numValor.Margin = new Padding(3, 2, 3, 2);
            numValor.Name = "numValor";
            numValor.Size = new Size(131, 39);
            numValor.TabIndex = 4;
            // 
            // numLimite
            // 
            numLimite.Font = new Font("Segoe UI", 18F);
            numLimite.Location = new Point(128, 278);
            numLimite.Margin = new Padding(3, 2, 3, 2);
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(131, 39);
            numLimite.TabIndex = 5;
            // 
            // btDepositar
            // 
            btDepositar.Font = new Font("Segoe UI", 18F);
            btDepositar.Location = new Point(61, 107);
            btDepositar.Margin = new Padding(3, 2, 3, 2);
            btDepositar.Name = "btDepositar";
            btDepositar.Size = new Size(158, 40);
            btDepositar.TabIndex = 6;
            btDepositar.Text = "Depositar";
            btDepositar.UseVisualStyleBackColor = true;
            btDepositar.Click += btDepositar_Click;
            // 
            // btSacar
            // 
            btSacar.Font = new Font("Segoe UI", 18F);
            btSacar.Location = new Point(249, 107);
            btSacar.Margin = new Padding(3, 2, 3, 2);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(158, 40);
            btSacar.TabIndex = 7;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btSacar);
            Controls.Add(btDepositar);
            Controls.Add(numLimite);
            Controls.Add(numValor);
            Controls.Add(label4);
            Controls.Add(lblSaldo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblSaldo;
        private Label label4;
        private NumericUpDown numValor;
        private NumericUpDown numLimite;
        private Button btDepositar;
        private Button btSacar;
    }
}
