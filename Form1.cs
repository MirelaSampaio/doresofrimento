namespace Aula04AplicativoDeBanco
{
    public partial class Form1 : Form
    {

        // Variáveis globais
        List<string> extratos = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            btnDeposito.BackColor = Color.SteelBlue;
            btnDeposito.ForeColor = Color.White;

            btnSaque.BackColor = Color.White;
            btnSaque.ForeColor = Color.Black;

        }

        private void lblDepositar_Click(object sender, EventArgs e)
        {

        }

        //private static double soma;
        //private static double subtrair;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValorDigitado.Text);
            double saldo = double.Parse(lblDinheiroNaConta.Text.Replace("R$", ""));

            //lblDinheiroNaConta.Text = $"R$ {soma}";
            
            double soma;
            if ( lblDepositar.Text == "Sacar")
            {
              soma = saldo + valor;        
              lblDinheiroNaConta.Text = $"R$ {soma}";
              extratos.Add($"Saque no valor de R${valor}");

            }
            else
            {
                soma = saldo - valor;
               
                lblDinheiroNaConta.Text = $"R$ {soma}";
            }
               
            
             
            
        }

        private void txtValorDigitado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDinheiroNaConta_Click(object sender, EventArgs e)
        {

        }
        private void Aula()
        {

              //double valor = double.Parse(txtValorDigitado.Text);
            // double saldo = double.Parse(lblDinheiroNaConta.Text.Replace("R$", ""));
          // double soma = valor + saldo;
             //lblDinheiroNaConta = $"R$ {soma}";


            //double saldo;
            //double valor;
            //valor = double.Parse(txtValorDigitado.Text);
            //saldo = double.Parse(lblDinheiroNaConta.Text);
            //string novoSaldo;
            //novoSaldo = lblDinheiroNaConta.Text;
            //novoSaldo = novoSaldo.Substring(0, 2);
            //novoSaldo = novoSaldo.Replace("R$", "");
            //saldo = double.Parse(novoSaldo);           
            //double soma = saldo + valor;
            //lblDinheiroNaConta.Text = $"R$ {soma}";

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
          
            btnSaque.BackColor = Color.SteelBlue;
            btnSaque.ForeColor = Color.White;

            btnDeposito.BackColor = Color.White;
            btnDeposito.ForeColor = Color.Black;

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {

            Form2 telaExtrato= new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();
        }
    }
}