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
            lblErro = new Label();
            btLimparValor = new Button();
            label3 = new Label();
            lblLimiteSaque = new Label();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLimite).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 147);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 381);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(225, 384);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(84, 28);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "R$ 0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(140, 437);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 3;
            label4.Text = "Limite:";
            // 
            // numValor
            // 
            numValor.Font = new Font("Segoe UI", 18F);
            numValor.Location = new Point(186, 143);
            numValor.Margin = new Padding(3, 2, 3, 2);
            numValor.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(131, 39);
            numValor.TabIndex = 4;
            // 
            // numLimite
            // 
            numLimite.Font = new Font("Segoe UI", 18F);
            numLimite.Location = new Point(237, 437);
            numLimite.Margin = new Padding(3, 2, 3, 2);
            numLimite.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numLimite.Minimum = new decimal(new int[] { 100000000, 0, 0, int.MinValue });
            numLimite.Name = "numLimite";
            numLimite.Size = new Size(131, 39);
            numLimite.TabIndex = 5;
            // 
            // btDepositar
            // 
            btDepositar.BackColor = Color.OrangeRed;
            btDepositar.Font = new Font("Segoe UI", 18F);
            btDepositar.ForeColor = Color.White;
            btDepositar.Location = new Point(101, 217);
            btDepositar.Margin = new Padding(3, 2, 3, 2);
            btDepositar.Name = "btDepositar";
            btDepositar.Size = new Size(158, 40);
            btDepositar.TabIndex = 6;
            btDepositar.Text = "Depositar";
            btDepositar.UseVisualStyleBackColor = false;
            btDepositar.Click += btDepositar_Click;
            // 
            // btSacar
            // 
            btSacar.BackColor = Color.OrangeRed;
            btSacar.Font = new Font("Segoe UI", 18F);
            btSacar.ForeColor = Color.White;
            btSacar.Location = new Point(265, 217);
            btSacar.Margin = new Padding(3, 2, 3, 2);
            btSacar.Name = "btSacar";
            btSacar.Size = new Size(158, 40);
            btSacar.TabIndex = 7;
            btSacar.Text = "Sacar";
            btSacar.UseVisualStyleBackColor = false;
            btSacar.Click += btSacar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(101, 269);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(108, 21);
            lblErro.TabIndex = 8;
            lblErro.Text = "caixa de erro";
            lblErro.Visible = false;
            // 
            // btLimparValor
            // 
            btLimparValor.BackColor = Color.DarkRed;
            btLimparValor.Font = new Font("Segoe UI", 12F);
            btLimparValor.ForeColor = Color.White;
            btLimparValor.Location = new Point(323, 147);
            btLimparValor.Name = "btLimparValor";
            btLimparValor.Size = new Size(75, 33);
            btLimparValor.TabIndex = 9;
            btLimparValor.Text = "Zerar";
            btLimparValor.UseVisualStyleBackColor = false;
            btLimparValor.Click += btZerarValor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 38F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(37, 35);
            label3.Name = "label3";
            label3.Size = new Size(462, 68);
            label3.TabIndex = 10;
            label3.Text = "CAIXA BANCÁRIO";
            // 
            // lblLimiteSaque
            // 
            lblLimiteSaque.AutoSize = true;
            lblLimiteSaque.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLimiteSaque.ForeColor = Color.LightCoral;
            lblLimiteSaque.Location = new Point(144, 492);
            lblLimiteSaque.Name = "lblLimiteSaque";
            lblLimiteSaque.Size = new Size(165, 21);
            lblLimiteSaque.TabIndex = 11;
            lblLimiteSaque.Text = "(Limite para Sacar : )";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(533, 573);
            Controls.Add(lblLimiteSaque);
            Controls.Add(label3);
            Controls.Add(btLimparValor);
            Controls.Add(lblErro);
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
        private Label lblErro;
        private Button btLimparValor;
        private Label label3;
        private Label lblLimiteSaque;
    }
}
