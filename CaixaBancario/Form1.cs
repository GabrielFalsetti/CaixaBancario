namespace CaixaBancario
{
    public partial class Form1 : Form
    {
        /* ---------- VARIÁVEIS GLOBAIS ---------- */

        double saldo = 500, limite = 300;
        double taxa = 0.01;
        double taxaCruel = 0.8;

        /* ---------- INICIALIZAÇÕES ---------- */

        public Form1()
        {
            InitializeComponent();

            if (saldo > 0) lblSaldo.ForeColor = Color.LightGreen;
            else lblSaldo.ForeColor = Color.Red;

            lblSaldo.Text = saldo.ToString("c");
            numLimite.Value = (decimal)limite;

            AtualizarSaldo(saldo);
        }

        /* ---------- FUNÇÕES ---------- */

        // função para alterar o valor exibido do saldo
        public void AtualizarSaldo(double n)
        {
            lblSaldo.Text = n.ToString("c");

            // saldo
            if (n > 0) lblSaldo.ForeColor = Color.LightGreen;
            else lblSaldo.ForeColor = Color.Red;

            // texto limite real
            double limiteSaque = 0;
            if (saldo >= 0) limiteSaque = saldo + limite;
            else limiteSaque = limite + saldo;
            lblLimiteSaque.Text = $"(Limite para Sacar : {limiteSaque.ToString("c")})";
        }

        /* ---------- PROGRAMA ---------- */

        private void btDepositar_Click(object sender, EventArgs e)
        {
            if (numValor.Value > 0) saldo += (double)numValor.Value;
            else
            {
                lblErro.Visible = true;
                lblErro.Text = "O valor depositado deve ser maior que 0";
            }

            AtualizarSaldo(saldo);
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            if (numValor.Value > 0)
            {
                double novoSaldo = saldo - (double)numValor.Value;

                // Permite o saque se o novo saldo não for menor que -limite
                if (novoSaldo >= -limite)
                {
                    saldo = novoSaldo; // atualiza o saldo
                    AtualizarSaldo(saldo);
                    lblErro.Text = "";
                }
                else
                {
                    lblErro.Visible = true;
                    lblErro.Text = "Saldo insuficiente!\nVocê atingiu o limite de saque.";
                }
            }
            else
            {
                lblErro.Visible = true;
                lblErro.Text = "O valor do saque deve ser maior que 0!";
            }
        }

        private void btZerarValor_Click(object sender, EventArgs e)
        {
            numValor.Value = 0;
            lblErro.Text = "";
        }


        private void tempJuros_Tick(object sender, EventArgs e)
        {
            if (saldo > 0)
            {
                saldo += saldo * taxa;
                AtualizarSaldo(saldo);
            }
            else if (saldo < 0)
            {
                saldo += saldo * taxaCruel;
                AtualizarSaldo(saldo);
                lblTaxa.Text = $"Taxa Cruel: {taxaCruel * 100}% cada {tempJuros.Interval / 1000} (Segundos)";
            }

            lblSaldo.Text = saldo.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text = $"Taxa: {taxa * 100}% cada {tempJuros.Interval / 1000} (Segundos)";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja realmente sair do banco ?",
                                             "", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Txau");
        }
    }
}