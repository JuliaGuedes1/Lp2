using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            double verify1, verify2, verify3, x;
            if (double.TryParse(txtA.Text, out verify1) &&
                double.TryParse(txtB.Text, out verify2) &&
                double.TryParse(txtC.Text, out verify3))
            {
                if (verify2 > verify1 && verify2 > verify3)
                {
                    x = verify1;
                    verify1 = verify2;
                    verify2 = x;
                }
                if (verify3 > verify2 && verify3 > verify1)
                {
                    x = verify1;
                    verify1 = verify3;
                    verify3 = x;
                }
                if (verify1 >= verify2 + verify3)
                    MessageBox.Show("Não forma triângulo");
                else if (verify1 == verify2 && verify2 == verify3)
                    MessageBox.Show("Triângulo Equilátero");
                else if (verify1 != verify2 && verify2 != verify3 && verify1 != verify3)
                    MessageBox.Show("Triângulo Escaleno");
                else if (verify1 == verify2 || verify2 == verify3 || verify3 == verify1)
                    MessageBox.Show("Triângulo Isósceles");
            }
            else
            MessageBox.Show("Dados inválidos");
            
                
            }





        }

    }

