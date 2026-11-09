namespace helloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;

            if (double.TryParse(txtPeso.Text, out peso) &&
                double.TryParse(txtAltura.Text, out altura) &&
                altura > 0 && peso > 0)
            {
                double imc = peso / (altura * altura);

                lblResultado.Text = $"IMC Calculado: {imc:F2}";
                if(imc < 18.5)
                {
                    lblResultado.Text += " - Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    lblResultado.Text += " - Peso normal";
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    lblResultado.Text += " - Sobrepeso";
                }
                else
                {
                    lblResultado.Text += " - Obesidade";
                }
            }
            else
            {
                lblResultado.Text = "Digite um peso e uma altura válidos!";
            }
        }
    }
}