namespace P2
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCPF = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            lblWhats = new Label();
            lblEnd = new Label();
            lblCEP = new Label();
            lblLogra = new Label();
            lblN = new Label();
            lblBai = new Label();
            lblCid = new Label();
            lblEst = new Label();
            lblCadastrados = new Label();
            msTel = new MaskedTextBox();
            msCPF = new MaskedTextBox();
            msCEP = new MaskedTextBox();
            msWhats = new MaskedTextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtLogra = new TextBox();
            txtCid = new TextBox();
            txtEst = new TextBox();
            btnBus = new Button();
            btnEx = new Button();
            btnCancelar = new Button();
            btnSalva = new Button();
            list1 = new ListBox();
            txtBai = new TextBox();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(23, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(35, 73);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 44);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(12, 102);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(54, 15);
            lblTel.TabIndex = 3;
            lblTel.Text = "Telefone:";
            // 
            // lblWhats
            // 
            lblWhats.AutoSize = true;
            lblWhats.Location = new Point(3, 128);
            lblWhats.Name = "lblWhats";
            lblWhats.Size = new Size(63, 15);
            lblWhats.TabIndex = 4;
            lblWhats.Text = "Whatsapp:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(253, 9);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(59, 15);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "Endereço:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(253, 47);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 6;
            lblCEP.Text = "CEP:";
            // 
            // lblLogra
            // 
            lblLogra.AutoSize = true;
            lblLogra.Location = new Point(212, 75);
            lblLogra.Name = "lblLogra";
            lblLogra.Size = new Size(72, 15);
            lblLogra.TabIndex = 7;
            lblLogra.Text = "Logradouro:";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(233, 133);
            lblN.Name = "lblN";
            lblN.Size = new Size(54, 15);
            lblN.TabIndex = 8;
            lblN.Text = "Número:";
            // 
            // lblBai
            // 
            lblBai.AutoSize = true;
            lblBai.Location = new Point(246, 162);
            lblBai.Name = "lblBai";
            lblBai.Size = new Size(41, 15);
            lblBai.TabIndex = 9;
            lblBai.Text = "Bairro:";
            // 
            // lblCid
            // 
            lblCid.AutoSize = true;
            lblCid.Location = new Point(240, 193);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(47, 15);
            lblCid.TabIndex = 10;
            lblCid.Text = "Cidade:";
            // 
            // lblEst
            // 
            lblEst.AutoSize = true;
            lblEst.Location = new Point(239, 104);
            lblEst.Name = "lblEst";
            lblEst.Size = new Size(45, 15);
            lblEst.TabIndex = 11;
            lblEst.Text = "Estado:";
            // 
            // lblCadastrados
            // 
            lblCadastrados.AutoSize = true;
            lblCadastrados.Location = new Point(23, 217);
            lblCadastrados.Name = "lblCadastrados";
            lblCadastrados.Size = new Size(132, 15);
            lblCadastrados.TabIndex = 12;
            lblCadastrados.Text = "Clientes já Cadastrados:";
            // 
            // msTel
            // 
            msTel.Location = new Point(72, 99);
            msTel.Mask = "(99) 00000-0000";
            msTel.Name = "msTel";
            msTel.Size = new Size(100, 23);
            msTel.TabIndex = 13;
            // 
            // msCPF
            // 
            msCPF.Location = new Point(72, 70);
            msCPF.Mask = "000-000-000-00";
            msCPF.Name = "msCPF";
            msCPF.Size = new Size(100, 23);
            msCPF.TabIndex = 15;
            // 
            // msCEP
            // 
            msCEP.Location = new Point(290, 44);
            msCEP.Mask = "00000-9999";
            msCEP.Name = "msCEP";
            msCEP.Size = new Size(100, 23);
            msCEP.TabIndex = 16;
            // 
            // msWhats
            // 
            msWhats.Location = new Point(72, 128);
            msWhats.Mask = "(99) 00000-0000";
            msWhats.Name = "msWhats";
            msWhats.Size = new Size(100, 23);
            msWhats.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(72, 9);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(137, 23);
            txtNome.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(72, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtLogra
            // 
            txtLogra.Location = new Point(290, 75);
            txtLogra.Name = "txtLogra";
            txtLogra.Size = new Size(100, 23);
            txtLogra.TabIndex = 22;
            // 
            // txtCid
            // 
            txtCid.Location = new Point(290, 190);
            txtCid.Name = "txtCid";
            txtCid.Size = new Size(100, 23);
            txtCid.TabIndex = 25;
            // 
            // txtEst
            // 
            txtEst.Location = new Point(290, 101);
            txtEst.Name = "txtEst";
            txtEst.Size = new Size(100, 23);
            txtEst.TabIndex = 26;
            // 
            // btnBus
            // 
            btnBus.Location = new Point(23, 345);
            btnBus.Name = "btnBus";
            btnBus.Size = new Size(75, 23);
            btnBus.TabIndex = 27;
            btnBus.Text = "Buscar CEP";
            btnBus.UseVisualStyleBackColor = true;
            btnBus.Click += btnBus_Click;
            // 
            // btnEx
            // 
            btnEx.Location = new Point(286, 345);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(75, 23);
            btnEx.TabIndex = 28;
            btnEx.Text = "Excluir";
            btnEx.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(124, 345);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 30;
            btnSalva.Text = "Salvar";
            btnSalva.UseVisualStyleBackColor = true;
            // 
            // list1
            // 
            list1.FormattingEnabled = true;
            list1.Location = new Point(23, 235);
            list1.Name = "list1";
            list1.Size = new Size(338, 94);
            list1.TabIndex = 31;
            list1.DoubleClick += list1_DoubleClick;
            // 
            // txtBai
            // 
            txtBai.Location = new Point(290, 162);
            txtBai.Name = "txtBai";
            txtBai.Size = new Size(100, 23);
            txtBai.TabIndex = 32;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(290, 130);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 33;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 497);
            Controls.Add(txtNum);
            Controls.Add(txtBai);
            Controls.Add(list1);
            Controls.Add(btnSalva);
            Controls.Add(btnCancelar);
            Controls.Add(btnEx);
            Controls.Add(btnBus);
            Controls.Add(txtEst);
            Controls.Add(txtCid);
            Controls.Add(txtLogra);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(msWhats);
            Controls.Add(msCEP);
            Controls.Add(msCPF);
            Controls.Add(msTel);
            Controls.Add(lblCadastrados);
            Controls.Add(lblEst);
            Controls.Add(lblCid);
            Controls.Add(lblBai);
            Controls.Add(lblN);
            Controls.Add(lblLogra);
            Controls.Add(lblCEP);
            Controls.Add(lblEnd);
            Controls.Add(lblWhats);
            Controls.Add(lblTel);
            Controls.Add(lblEmail);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Name = "frmClientes";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private Label lblEmail;
        private Label lblTel;
        private Label lblWhats;
        private Label lblEnd;
        private Label lblCEP;
        private Label lblLogra;
        private Label lblN;
        private Label lblBai;
        private Label lblCid;
        private Label lblEst;
        private Label lblCadastrados;
        private MaskedTextBox msTel;
        private MaskedTextBox msCPF;
        private MaskedTextBox msCEP;
        private MaskedTextBox msWhats;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtLogra;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtCid;
        private TextBox txtEst;
        private Button btnBus;
        private Button btnEx;
        private Button btnCancelar;
        private Button btnSalva;
        private ListBox list1;
        private TextBox txtBai;
        private TextBox txtNum;
    }
}