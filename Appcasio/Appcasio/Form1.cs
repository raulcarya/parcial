using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcasio
{
    public partial class Form1 : Form
    {

        bool sigue = true,punto=true;
        string operacion;
        int numero1;
        double solucion;
        double numero2;



        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "1";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "2";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "3";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "4";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "5";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "6";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "7";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "8";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "9";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (sigue)
            {
                pantalla.Text = pantalla.Text + "";
                pantalla.Text = "0";
                sigue = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            sigue = true;
            numero1 = int.Parse(pantalla.Text);
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            sigue = true;
            numero1 = int.Parse(pantalla.Text);
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            sigue = true;
            numero1 = int.Parse(pantalla.Text);
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            sigue = true;
            numero1 = int.Parse(pantalla.Text);
        }

        private void btnigual_Click_Click(object sender, EventArgs e)
        {
             numero2 = double.Parse(pantalla.Text);
            sigue = true;
switch (operacion)
            {

                case "+":
                    solucion = numero1 + numero2;
                    pantalla.Text = solucion.ToString();
                    break;

                case "-":
                    solucion = numero1 - numero2;
                    pantalla.Text = solucion.ToString();
                    break;

                case "*":
                    solucion = numero1 * numero2;
                    pantalla.Text = solucion.ToString();
                    break;

                case "/":
                    solucion = numero1 / numero2;
                    pantalla.Text = solucion.ToString();
                    break;

                            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                pantalla.Text = pantalla.Text + ",";
                 
            }
            else
            {
                return;
            }
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        }
        }

    

