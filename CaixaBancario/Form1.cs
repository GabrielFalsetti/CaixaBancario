namespace CaixaBancario
{
    public partial class Form1 : Form
    {
        // variável global
        double saldo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /* ---------- FUNÇÕES ---------- */

        // função para alterar o valor exibido do saldo
        void AtualizarSaldo(double n)
        {
            lblSaldo.Text = n.ToString("c");
        }

        /* ---------- PROGRAMA ---------- */

        private void btDepositar_Click(object sender, EventArgs e)
        {
            if (numValor.Value > 0) saldo = saldo + (double)numValor.Value;
            else lblDepErro.Text = "O valor depositado deve ser maior que 0";

            AtualizarSaldo(saldo);
        }
    }
}
