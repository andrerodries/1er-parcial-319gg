using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO2
{
    public partial class Form1 : Form
    {
        double numero1;
        double numero2;
        double resultado;
        String operaciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            numero1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(pantalla.Text);

            switch (operaciones) 
            { 
                case "+":
                    resultado=numero1+numero2;
                    pantalla.Text=resultado.ToString();
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }
    }
}
