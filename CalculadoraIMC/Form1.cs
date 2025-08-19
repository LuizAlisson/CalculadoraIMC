using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class AchouQÑianomearessePNG : Form
    {
        public AchouQÑianomearessePNG()
        {
            InitializeComponent();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            double peso;
            double altura;

            if (!double.TryParse(txtPeso.Text, out peso))
            //Double tryparse transforma a string em Double e se der certo, roda o if
            //com o ! na frente para verificar se é diferente
            {
                MessageBox.Show("Digite um valor válido para o peso!", "Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //Retorna sem executar o resto do programa

            }

            else if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Digite um valor válido para o altura!", "Inválido",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //Retorna sem executar o resto do programa

            }
            else if (altura <= 0)
            //Verifica se o valor da altura é maior que zero
            {
                MessageBox.Show("A altura deve ser maior que zero!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                resultado = peso / (altura * altura);
                txtResultado.Text = resultado.ToString("F2");
                //F2 formata para duas casas decimais
            }

            if (resultado < 18.5)
            {
                lblCondição.Text = ("Abaixo do peso");
            }

            else if (resultado <= 24.9)
            {
                lblCondição.Text = ("Peso ideal");
                MessageBox.Show("VOCÊ ESTÁ NO PESO IDEAL", "PARABÉNS",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (resultado <= 29.9)
            {
                lblCondição.Text = ("Levemente acima do peso");
            }

            else if (resultado <= 34.9)
            {
                lblCondição.Text = ("Obesidade grau I");
            }

            else if (resultado <= 39.9)
            {
                lblCondição.Text = ("Obesidade grau II (severa)");
            }

            else if (resultado < 40)
            {
                lblCondição.Text = ("Obesidade III (Mórbida)");
            }



        }
    }
}
