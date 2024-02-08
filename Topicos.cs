using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using biblioteca;

namespace T.A.P
{
    public partial class Topic : Form
    {
        Class1 objeto = new Class1();
        public Topic()
        {
            InitializeComponent();
        }
        //variables para realizaar operaciones
        Double primerNum = 0, segubdoNuM = 0, Res;
        string OperacionVigente;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "1";
            }
            else
            {
                txtcal.Text += "1";
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "0";
            }
            else
            {
                txtcal.Text += "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int del = txtcal.Text.Length;
            string eliminar = txtcal.Text.Substring(0, del - 1);
            txtcal.Text = eliminar;

        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (Res != 0)
            {
                txtcal.Clear();
            }

            if (OperacionVigente != null)
            {
                OperacionVigente = "Division";
            }
            else
            {
                primerNum = Convert.ToDouble(txtcal.Text);
                OperacionVigente = "Division";
                txtcal.Clear();
            }
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            if (Res != 0)
            {
                txtcal.Clear();
            }

            if (OperacionVigente != null)
            {
                OperacionVigente = "suma";
            }
            else
            {
                primerNum = Convert.ToDouble(txtcal.Text);
                OperacionVigente = "suma";
                txtcal.Clear();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "2";
            }
            else
            {
                txtcal.Text += "2";
            }
        }
        public void BtnResukt_Click(object sender, EventArgs e)
        {
            
            segubdoNuM = Convert.ToDouble(txtcal.Text);



            switch (OperacionVigente)
            {

                case "suma":
                    Res = objeto.suma(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;

                case "resta":
                    Res = objeto.resta(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;
                case "Multiplicacion":
                    Res = objeto.Multiplicacion(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;

                case "Division":
                    Res = objeto.division(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;

                case "potencia":
                    Res = objeto.potencia(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;
                case "%":
                    Res = objeto.porcentaje(primerNum, segubdoNuM);
                    txtcal.Text = Res.ToString();
                    break;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "3";
            }
            else
            {
                txtcal.Text += "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "4";
            }
            else
            {
                txtcal.Text += "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "5";
            }
            else
            {
                txtcal.Text += "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "6";
            }
            else
            {
                txtcal.Text += "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "7";
            }
            else
            {
                txtcal.Text += "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "8";
            }
            else
            {
                txtcal.Text += "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtcal.Text == "0")
            {
                txtcal.Text = "9";
            }
            else
            {
                txtcal.Text += "9";
            }
        }
        private void btnmeno_Click(object sender, EventArgs e)
        {
            if (Res != 0)
            {
                txtcal.Clear();
            }

            if (OperacionVigente != null)
            {
                OperacionVigente = "resta";
            }
            else
            {
                primerNum = Convert.ToDouble(txtcal.Text);
                OperacionVigente = "resta";
                txtcal.Clear();
            }
        }

        private void txtcal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;


            txtcal.SelectAll();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            if (Res != 0)
            {
                txtcal.Clear();
            }

            if (OperacionVigente != null)
            {
                OperacionVigente = "Multiplicacion";
            }
            else
            {
                primerNum = Convert.ToDouble(txtcal.Text);
                OperacionVigente = "Multiplicacion";
                txtcal.Clear();
            }
        }

        private void txtcal_TextChanged(object sender, EventArgs e)
        {
            if (txtcal.Text.Trim() == "")
            {
                txtcal.Text = "";
                txtcal.SelectAll();

            }
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {       
            if (!txtcal.Text.Contains("."))
            {
                txtcal.Text += ".";
            }
        }
        public void BtnCe_Click(object sender, EventArgs e)
        {
            txtcal.Clear();
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        { 
            OperacionVigente = "Raiz";
            primerNum= Convert.ToDouble(txtcal.Text);
            Res =objeto.raiz(primerNum);
            txtcal.Text = Res.ToString();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtcal.Clear();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            primerNum = Convert.ToDouble(txtcal.Text);
            OperacionVigente = "potencia";
            txtcal.Clear();
        }
        public void btn1x_Click(object sender, EventArgs e)
        {
            OperacionVigente = "1/X";
            primerNum= Convert.ToDouble(txtcal.Text);
            Res=objeto.unoentreX(primerNum);
            txtcal.Text=Res.ToString();
        }
        private void btnmameno_Click(object sender, EventArgs e)
        {
            if (txtcal.Text.Contains("-"))
            {
                txtcal.Text = txtcal.Text.Trim('-');
            }
            else
            {
           txtcal.Text="-"+txtcal.Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OperacionVigente = "%";
            primerNum = Convert.ToDouble(txtcal.Text);         
            txtcal.Clear();
        }
    }
}
