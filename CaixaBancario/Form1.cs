namespace CaixaBancario
{
    public partial class Form1 : Form
    {
        /* ---------- VARIÁVEIS GLOBAIS ---------- */

        double saldo = 500, limite = 300, taxa = 0.01;

        /* ---------- INICIALIZAÇÕES ---------- */

        public Form1()
        {
            InitializeComponent();

            if (saldo > 0) lblSaldo.ForeColor = Color.LightGreen;
            else lblSaldo.ForeColor = Color.Red;

            lblSaldo.Text = saldo.ToString("c");
            numLimite.Value = (decimal)limite;

            lblTaxa.Text = $"Taxa : {taxa * 100}% a cada {tempJuros.Interval / 1000}s";

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

            // texto limite
            double limiteSaque = 0;

            if (saldo >= 0) limiteSaque = saldo + limite;
            else limiteSaque = limite + saldo;
                if (limiteSaque < 0) limiteSaque = 0; // Exibe 0, não um valor negativo, mas o saldo ainda pode ser negativo

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
            saldo += saldo * taxa;
            lblSaldo.Text = saldo.ToString("c");

            AtualizarSaldo(saldo);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?", "", MessageBoxButtons.YesNo);

            if (r == DialogResult.No) e.Cancel = true;
            else e.Cancel = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Ta duro dorme");
        }
    }
}