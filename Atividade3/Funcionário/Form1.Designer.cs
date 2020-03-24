namespace Funcionário
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.llbAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.btnVerificaDesconto = new System.Windows.Forms.Button();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.ckboxCasado = new System.Windows.Forms.CheckBox();
            this.txtNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtSalLiqui = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.lblDados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(12, 51);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(12, 97);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(12, 139);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // llbAliquotaINSS
            // 
            this.llbAliquotaINSS.AutoSize = true;
            this.llbAliquotaINSS.Location = new System.Drawing.Point(12, 247);
            this.llbAliquotaINSS.Name = "llbAliquotaINSS";
            this.llbAliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.llbAliquotaINSS.TabIndex = 5;
            this.llbAliquotaINSS.Text = "Aliquota INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(12, 296);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIRPF.TabIndex = 6;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(12, 342);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalFamilia.TabIndex = 7;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(12, 390);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiquido.TabIndex = 8;
            this.lblSalLiquido.Text = "Salário Líquido";
            // 
            // btnVerificaDesconto
            // 
            this.btnVerificaDesconto.Location = new System.Drawing.Point(156, 186);
            this.btnVerificaDesconto.Name = "btnVerificaDesconto";
            this.btnVerificaDesconto.Size = new System.Drawing.Size(148, 32);
            this.btnVerificaDesconto.TabIndex = 10;
            this.btnVerificaDesconto.Text = "Verificar Desconto";
            this.btnVerificaDesconto.UseVisualStyleBackColor = true;
            this.btnVerificaDesconto.Click += new System.EventHandler(this.btnVerificaDesconto_Click);
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(435, 246);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 11;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(438, 341);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 12;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // ckboxCasado
            // 
            this.ckboxCasado.AutoSize = true;
            this.ckboxCasado.Location = new System.Drawing.Point(550, 186);
            this.ckboxCasado.Name = "ckboxCasado";
            this.ckboxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckboxCasado.TabIndex = 21;
            this.ckboxCasado.Text = "Casado";
            this.ckboxCasado.UseVisualStyleBackColor = true;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(128, 44);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(176, 20);
            this.txtNomeFunc.TabIndex = 22;
            this.txtNomeFunc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(128, 90);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(176, 20);
            this.txtSalBruto.TabIndex = 23;
            this.txtSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtNumFilhos
            // 
            this.txtNumFilhos.Location = new System.Drawing.Point(128, 139);
            this.txtNumFilhos.Name = "txtNumFilhos";
            this.txtNumFilhos.Size = new System.Drawing.Size(176, 20);
            this.txtNumFilhos.TabIndex = 24;
            // 
            // txtSalLiqui
            // 
            this.txtSalLiqui.Enabled = false;
            this.txtSalLiqui.Location = new System.Drawing.Point(128, 383);
            this.txtSalLiqui.Name = "txtSalLiqui";
            this.txtSalLiqui.Size = new System.Drawing.Size(176, 20);
            this.txtSalLiqui.TabIndex = 25;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(128, 339);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(176, 20);
            this.txtSalFamilia.TabIndex = 26;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(128, 293);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(176, 20);
            this.txtAliquotaIRPF.TabIndex = 27;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(128, 244);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(176, 20);
            this.txtAliquotaINSS.TabIndex = 28;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Location = new System.Drawing.Point(535, 333);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(153, 20);
            this.txtDescIRPF.TabIndex = 29;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Location = new System.Drawing.Point(535, 244);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(153, 20);
            this.txtDescINSS.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnM);
            this.groupBox1.Controls.Add(this.rbtnF);
            this.groupBox1.Location = new System.Drawing.Point(550, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 99);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(17, 64);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(34, 17);
            this.rbtnM.TabIndex = 1;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Checked = true;
            this.rbtnF.Location = new System.Drawing.Point(17, 20);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(31, 17);
            this.rbtnF.TabIndex = 0;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(3, 176);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 32;
            this.lblDados.Text = "Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 437);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtSalLiqui);
            this.Controls.Add(this.txtNumFilhos);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.ckboxCasado);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.btnVerificaDesconto);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.llbAliquotaINSS);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label llbAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Button btnVerificaDesconto;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.CheckBox ckboxCasado;
        private System.Windows.Forms.MaskedTextBox txtNomeFunc;
        private System.Windows.Forms.MaskedTextBox txtSalBruto;
        private System.Windows.Forms.MaskedTextBox txtNumFilhos;
        private System.Windows.Forms.MaskedTextBox txtSalLiqui;
        private System.Windows.Forms.MaskedTextBox txtSalFamilia;
        private System.Windows.Forms.MaskedTextBox txtAliquotaIRPF;
        private System.Windows.Forms.MaskedTextBox txtAliquotaINSS;
        private System.Windows.Forms.MaskedTextBox txtDescIRPF;
        private System.Windows.Forms.MaskedTextBox txtDescINSS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Label lblDados;
    }
}

