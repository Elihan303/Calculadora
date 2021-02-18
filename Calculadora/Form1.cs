using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private const string c = " ";
        private double num1;
        private double num2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //BotonSuma
            operacion = 1;
            num1 = Convert.ToDouble(TextDisplay.Text);
            TextDisplay.Text = "";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //Boton0
            TextDisplay.Text =TextDisplay.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Boton1
            TextDisplay.Text = TextDisplay.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Boton2
            TextDisplay.Text = TextDisplay.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Boton3
            TextDisplay.Text = TextDisplay.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Boton4
            TextDisplay.Text = TextDisplay.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Boton5
            TextDisplay.Text = TextDisplay.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Boton6
            TextDisplay.Text = TextDisplay.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Boton7
            TextDisplay.Text = TextDisplay.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Boton8
            TextDisplay.Text = TextDisplay.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Boton9
            TextDisplay.Text = TextDisplay.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //BotonClear
            TextDisplay.Text =c;
        }

        private void TextDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //BotonIgual
            num2 = Convert.ToDouble(TextDisplay.Text);
            switch (operacion) {
                case 1: 
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;

            }
            
            TextDisplay.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //BotonResta
            operacion = 2;
            num1 = Convert.ToDouble(TextDisplay.Text);
            TextDisplay.Text = "";

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //BotonMultiplicar
            operacion = 3;
            num1 = Convert.ToDouble(TextDisplay.Text);
            TextDisplay.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacion = 4;
            num1 = Convert.ToDouble(TextDisplay.Text);
            TextDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //botonPunto
            TextDisplay.Text =  TextDisplay.Text + "."  ;
        }

        private void BorrarUno_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text.Length > 1)
            {
                TextDisplay.Text = TextDisplay.Text.Substring(0, TextDisplay.Text.Length - 1);
            }
            else
            {
                TextDisplay.Clear();
            }
        }
    }
}
