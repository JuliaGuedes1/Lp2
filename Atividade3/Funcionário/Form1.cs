using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerificaDesconto_Click(object sender, EventArgs e)
        {
            double verify1, verify2, aliquotaINSS, aliquotaIRPF, SalFamilia, SalLiqui;

            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text))
                MessageBox.Show("Nome em branco");
            else
                if (double.TryParse(txtSalBruto.Text, out verify1) && double.TryParse(txtNumFilhos.
                    Text, out verify2))
            {
                if (rbtnF.Checked == true || rbtnM.Checked == true)
                {
                    string nome;
                    nome = txtNomeFunc.Text;
                    if (rbtnF.Checked == true && ckboxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário da {0}\n que é casada\n" +
                     "e tem {1} filho(s)", nome, verify2);
                    if (rbtnF.Checked == true && ckboxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário da {0}\n que é solteira\n" +
                      "e tem {1} filho(s)", nome, verify2);
                    if (rbtnF.Checked == false && ckboxCasado.Checked == false)
                        lblDados.Text = string.Format("Os descontos do salário do {0}\n que ésolteiro\n" +
                     "e tem {1} filho(s)", nome, verify2);
                    if (rbtnF.Checked == false && ckboxCasado.Checked == true)
                        lblDados.Text = string.Format("Os descontos do salário do {0}\n que é casado\n" +
                     "e tem {1} filho(s)", nome, verify2);
                    //aliquota INSS
                    if (verify1 <= 800.47)
                    {
                        aliquotaINSS = verify1 * (7.65 / 100);
                        txtAliquotaINSS.Text = "7.65%";
                    }
                    else if (verify1 <= 1050)
                    {
                        aliquotaINSS = verify1 * (8.65 / 100);
                        txtAliquotaINSS.Text = "8.65%";
                    }
                    else if (verify1 <= 1400.77)
                    {
                        aliquotaINSS = verify1 * (9 / 100);
                        txtAliquotaINSS.Text = "9.00%";
                    }
                    else if (verify1 <= 2801.56)
                    {
                        aliquotaINSS = verify1 * (11 / 100);
                        txtAliquotaINSS.Text = "11.00%";
                    }

                    else
                    {
                        aliquotaINSS = 308.17;
                        txtAliquotaINSS.Text = "Teto";
                    }
                    txtDescINSS.Text = aliquotaINSS.ToString("N2");

                    //aliquota IRPF

                    if (verify1 <= 1257.12)
                    {
                        aliquotaIRPF = 0;
                        txtAliquotaIRPF.Text = "0";
                    }
                    else if (verify1 <= 2512.08)
                    {
                        aliquotaIRPF = verify1 * (15 / 100);
                        txtAliquotaIRPF.Text = "15%";
                    }
                    else
                    {
                        aliquotaIRPF = verify1 * (27.5 / 100);
                        txtAliquotaIRPF.Text = "27.5%";
                    }
                    txtDescIRPF.Text = aliquotaIRPF.ToString("N2");

                    //salário família
                    if (verify1 <= 435.52)
                        SalFamilia = verify2 * 22.33;
                    else if (verify1 <= 654.61)
                        SalFamilia = verify2 * 15.74;
                    else
                        SalFamilia = 0;

                    txtSalFamilia.Text = SalFamilia.ToString("N2");

                    //salário líquido
                    SalLiqui = verify1 - aliquotaINSS - aliquotaIRPF + SalFamilia;

                    txtSalLiqui.Text = SalLiqui.ToString("N2");
                }
               
            }

            else
                MessageBox.Show("Dados inválidos");

        }
    }
}
