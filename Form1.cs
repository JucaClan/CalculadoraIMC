using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Impedir que o usuária quebre o código usando letras
            try
            {
                //obter números do form
                double altura, peso, calculo;
                //variaveis recebem txt
                altura = double.Parse(txtAltura.Text);
                peso = double.Parse(txtPeso.Text);
                //calcular IMC
                calculo = peso / (altura * altura);

                //verificar o IMC do usuário e mostrar sua classificação
                if (calculo <= 18.5)
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Você está baixo do peso!";

                }
                else if (calculo >= 18.6 && calculo <= 24.9)
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Você está no peso ideal, Parabéns!";
                }
                else if (calculo >= 25.0 && calculo <= 29.9)
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.OrangeRed;
                    lblStatus.Text = "Você está levemente acima do peso!";
                }
                else if (calculo >= 30.0 && calculo <= 34.9)
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Você está com obesidade grau I!";
                }
                else if (calculo >= 35.0 && calculo <= 39.9)
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Você está com obesidade grau II, Severa!";
                }
                else
                {
                    txtResultado.Text = Math.Round(calculo, 3).ToString();
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Você está com obesidade grau III, Morbida!";
                }
            }
            catch 
            {
                MessageBox.Show("Dados informados inválidos! ");
                //limpar os txts
                txtAltura.Clear();
                txtPeso.Clear();
                txtResultado.Clear();
                lblStatus.Text = "";
                
            }


        }   
    }
}
