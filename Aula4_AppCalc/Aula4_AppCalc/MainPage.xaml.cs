using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula4_AppCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /**
         * Variavies usadas para memorizar a operação,
         * memória de cálculo e o que aparece no visor da
         * calculadora.
         **/
        string operacao = null;

        double memoria_de_calculo_pre_operacao = 0.0;
        double memoria_de_calculo_pos_operacao = 0.0;

        string para_aparecer_no_visor = "";


        /**
         * Método construtor da classe.
         */
        public MainPage()
        {
            InitializeComponent();
        }


        /**
         * Método para remover os sinais do visor quando for
         * digitar números.
         */
        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" || para_aparecer_no_visor == "-" ||
               para_aparecer_no_visor == "*" || para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = "";
            }
        }


        /**
         *  Botão para executar a operação desejada pelo usuário
         *  conforme a memória de cálculo.
         */
        private void Btn_igual(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoria_de_calculo_pre_operacao + memoria_de_calculo_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_de_calculo_pre_operacao - memoria_de_calculo_pos_operacao;
                        break;
                    case "*":
                        resultado = memoria_de_calculo_pre_operacao * memoria_de_calculo_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_de_calculo_pre_operacao / memoria_de_calculo_pos_operacao;
                        break;
                }

                visor.Text = resultado.ToString();

            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
        }



        /**
         * Comportamento das Operações
         **/
        private void Btn_somar(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_subtrair(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_multiplicar(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_dividir(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_zerar(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_de_calculo_pos_operacao = 0.0;
            memoria_de_calculo_pre_operacao = 0.0;
            operacao = null;
        }

        private void Btn_maismenos(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            valor_visor = valor_visor * -1;
            visor.Text = valor_visor.ToString();
        }

        private void Btn_porcento(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            valor_visor = valor_visor / 100;
            visor.Text = valor_visor.ToString();
        }

        private void Btn_ponto(object sender, EventArgs e)
        {
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }





        /**
         * Comportamento dos Botões de 0 à 9.
         **/

        private void Btn_0(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num0.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_1(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num1.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_2(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num2.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_3(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num3.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_4(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num4.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_5(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num5.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_6(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num6.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_7(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_8(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num8.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void Btn_9(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num9.Text;
            visor.Text = para_aparecer_no_visor;
        }
    }
}
