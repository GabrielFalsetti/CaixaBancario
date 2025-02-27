namespace CaixaBancario
{
    public partial class Form1 : Form
    {
        double saldo=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {

        }

        private void btSacar_Click(object sender, EventArgs e)
        {            
            //Saldo > 0 
            if (numValor.Value > 0)
            {
                //numValor tirar do saldo
                saldo = saldo - (double)numValor.Value;
                //numValor que tirar de saldo não pode ser < que o limite
                if (saldo > (double)numLimite.Value)
                {
                    lblSaldo.Text = saldo.ToString("c");
                }
            }
        }
    }
}
