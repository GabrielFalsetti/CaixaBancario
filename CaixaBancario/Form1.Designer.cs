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
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(57, 287);
            label2.Name = "label2";
            label2.Size = new Size(99, 41);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 15F);
            lblSaldo.Location = new Point(213, 287);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(94, 35);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "R$ 0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(35, 371);
            label4.Name = "label4";
            label4.Size = new Size(105, 41);
            label4.TabIndex = 3;
            label4.Text = "Limite:";
            // 
            // numValor
            // 
            numValor.Font = new Font("Segoe UI", 18F);
            numValor.Location = new Point(133, 43);
            numValor.Name = "numValor";
            numValor.Size = new Size(150, 47);
            numValor.TabIndex = 4;
            // 
            // numLimite
            // 
            numLimite.Font = new Font("Segoe UI", 18F);
            numLimite.Location = new Point(146, 371);
            numLimite.Minimum = new decimal(new int[] { -727379969, 232, 0, int.MinValue });
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(150, 47);
            numLimite.TabIndex = 5;
            // 
            // btDepositar
            // 
            btDepositar.Font = new Font("Segoe UI", 18F);
            btDepositar.Location = new Point(70, 143);
            btDepositar.Name = "btDepositar";
            btDepositar.Size = new Size(181, 53);
            btDepositar.TabIndex = 6;
            btDepositar.Text = "Depositar";
            btDepositar.UseVisualStyleBackColor = true;
            btDepositar.Click += btDepositar_Click;
            // 
            // btSacar
            // 
            btSacar.Font = new Font("Segoe UI", 18F);
            btSacar.Location = new Point(285, 143);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(181, 53);
            btSacar.TabIndex = 7;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = true;
            btSacar.Click += btSacar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btSacar);
            Controls.Add(btDepositar);
            Controls.Add(numLimite);
            Controls.Add(numValor);
            Controls.Add(label4);
            Controls.Add(lblSaldo);
            Controls.Add(label2);
            Controls.Add(label1);
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
