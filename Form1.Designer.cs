namespace Aula04AplicativoDeBanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.lblDinheiroNaConta = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorDigitado = new System.Windows.Forms.TextBox();
            this.lblInformarValor = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnExtrato);
            this.panel1.Controls.Add(this.lblDinheiroNaConta);
            this.panel1.Controls.Add(this.lblSaldoAtual);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 132);
            this.panel1.TabIndex = 0;
            // 
            // btnExtrato
            // 
            this.btnExtrato.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtrato.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnExtrato.Location = new System.Drawing.Point(157, 73);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(130, 41);
            this.btnExtrato.TabIndex = 3;
            this.btnExtrato.Text = "Ver extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // lblDinheiroNaConta
            // 
            this.lblDinheiroNaConta.AutoSize = true;
            this.lblDinheiroNaConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinheiroNaConta.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDinheiroNaConta.Location = new System.Drawing.Point(19, 90);
            this.lblDinheiroNaConta.Name = "lblDinheiroNaConta";
            this.lblDinheiroNaConta.Size = new System.Drawing.Size(54, 24);
            this.lblDinheiroNaConta.TabIndex = 2;
            this.lblDinheiroNaConta.Text = "R$ 0";
            this.lblDinheiroNaConta.Click += new System.EventHandler(this.lblDinheiroNaConta_Click);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoAtual.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblSaldoAtual.Location = new System.Drawing.Point(19, 73);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(103, 17);
            this.lblSaldoAtual.TabIndex = 1;
            this.lblSaldoAtual.Text = "Seu saldo atual:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(19, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Misa\'s Bank";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSaque);
            this.panel2.Controls.Add(this.btnDeposito);
            this.panel2.Controls.Add(this.lblDepositar);
            this.panel2.Location = new System.Drawing.Point(30, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 239);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Controls.Add(this.txtValorDigitado);
            this.panel3.Controls.Add(this.lblInformarValor);
            this.panel3.Controls.Add(this.lblDeposito);
            this.panel3.Location = new System.Drawing.Point(19, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 139);
            this.panel3.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.Location = new System.Drawing.Point(26, 87);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(204, 38);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorDigitado
            // 
            this.txtValorDigitado.Location = new System.Drawing.Point(26, 58);
            this.txtValorDigitado.Name = "txtValorDigitado";
            this.txtValorDigitado.Size = new System.Drawing.Size(204, 23);
            this.txtValorDigitado.TabIndex = 2;
            this.txtValorDigitado.TextChanged += new System.EventHandler(this.txtValorDigitado_TextChanged);
            // 
            // lblInformarValor
            // 
            this.lblInformarValor.AutoSize = true;
            this.lblInformarValor.Location = new System.Drawing.Point(26, 40);
            this.lblInformarValor.Name = "lblInformarValor";
            this.lblInformarValor.Size = new System.Drawing.Size(91, 15);
            this.lblInformarValor.TabIndex = 1;
            this.lblInformarValor.Text = "Informe o valor:";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblDeposito.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDeposito.Location = new System.Drawing.Point(26, 13);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(94, 18);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "DEPÓSITO";
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaque.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaque.Location = new System.Drawing.Point(19, 36);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(121, 44);
            this.btnSaque.TabIndex = 6;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposito.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposito.Location = new System.Drawing.Point(157, 36);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(121, 44);
            this.btnDeposito.TabIndex = 5;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // lblDepositar
            // 
            this.lblDepositar.AutoSize = true;
            this.lblDepositar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepositar.ForeColor = System.Drawing.Color.SlateGray;
            this.lblDepositar.Location = new System.Drawing.Point(19, 11);
            this.lblDepositar.Name = "lblDepositar";
            this.lblDepositar.Size = new System.Drawing.Size(175, 21);
            this.lblDepositar.TabIndex = 4;
            this.lblDepositar.Text = "Operações disponíveis";
            this.lblDepositar.Click += new System.EventHandler(this.lblDepositar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnExtrato;
        private Label lblDinheiroNaConta;
        private Label lblSaldoAtual;
        private Label lblTitulo;
        private Panel panel2;
        private Panel panel3;
        private Button btnSalvar;
        private TextBox txtValorDigitado;
        private Label lblInformarValor;
        private Label lblDeposito;
        private Button btnSaque;
        private Button btnDeposito;
        private Label lblDepositar;
    }
}