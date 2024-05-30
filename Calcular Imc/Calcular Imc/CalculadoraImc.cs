using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Imc
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

        private void button1_Click(object sender, EventArgs e)
        {
            double Peso = Convert.ToDouble(textBox2.Text);
            double Altura = Convert.ToDouble(textBox3.Text);
            double Calcular_imc;
            string Nome = textBox7.Text;

            Calcular_imc = Peso / (Altura * Altura) ;

           
            if (Calcular_imc <= 18)
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Você está abaixo do peso ideal ! ") ;
            }
            else if ((Calcular_imc >= 19) && (Calcular_imc <= 24))
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Parabéns voçê está no seu peso normal ! ");
            }
            else if ((Calcular_imc >= 25) && (Calcular_imc <= 29))
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Você está acima de seu peso");
            }
            else if ((Calcular_imc >= 30) && (Calcular_imc <= 34))
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Obesidade grau I");
            }
            else if ((Calcular_imc >= 35) && (Calcular_imc <= 39))
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Obesidade grau II");
            }
            else if (Calcular_imc > 40)
            {
                Resultado.Text = (Nome + " seu IMC é " + Calcular_imc + " Obesidade grau III");
            }
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Resultado.Text = "";
        }
    }
}
