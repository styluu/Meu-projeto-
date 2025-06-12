namespace P2
{
    partial class frmUsuário
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
            lblUsu = new Label();
            lblSen = new Label();
            lbl3 = new Label();
            txtUsu = new TextBox();
            txtSen = new TextBox();
            cb1 = new CheckBox();
            btnCadas = new Button();
            btnEx = new Button();
            list1 = new ListBox();
            SuspendLayout();
            // 
            // lblUsu
            // 
            lblUsu.AutoSize = true;
            lblUsu.Location = new Point(56, 36);
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(50, 15);
            lblUsu.TabIndex = 0;
            lblUsu.Text = "Usuário:";
            // 
            // lblSen
            // 
            lblSen.AutoSize = true;
            lblSen.Location = new Point(56, 95);
            lblSen.Name = "lblSen";
            lblSen.Size = new Size(42, 15);
            lblSen.TabIndex = 1;
            lblSen.Text = "Senha:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(56, 179);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(123, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "Usuários Cadastrados:";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(56, 54);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(134, 23);
            txtUsu.TabIndex = 3;
            // 
            // txtSen
            // 
            txtSen.Location = new Point(56, 113);
            txtSen.Name = "txtSen";
            txtSen.Size = new Size(134, 23);
            txtSen.TabIndex = 4;
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.Location = new Point(196, 115);
            cb1.Name = "cb1";
            cb1.Size = new Size(102, 19);
            cb1.TabIndex = 5;
            cb1.Text = "Mostrar Senha";
            cb1.UseVisualStyleBackColor = true;
            // 
            // btnCadas
            // 
            btnCadas.Location = new Point(313, 145);
            btnCadas.Name = "btnCadas";
            btnCadas.Size = new Size(75, 23);
            btnCadas.TabIndex = 6;
            btnCadas.Text = "Cadastrar";
            btnCadas.UseVisualStyleBackColor = true;
            // 
            // btnEx
            // 
            btnEx.Location = new Point(313, 179);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(75, 23);
            btnEx.TabIndex = 7;
            btnEx.Text = "Excluir";
            btnEx.UseVisualStyleBackColor = true;
            // 
            // list1
            // 
            list1.FormattingEnabled = true;
            list1.Location = new Point(77, 297);
            list1.Name = "list1";
            list1.Size = new Size(120, 94);
            list1.TabIndex = 8;
            // 
            // frmUsuário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(list1);
            Controls.Add(btnEx);
            Controls.Add(btnCadas);
            Controls.Add(cb1);
            Controls.Add(txtSen);
            Controls.Add(txtUsu);
            Controls.Add(lbl3);
            Controls.Add(lblSen);
            Controls.Add(lblUsu);
            Name = "frmUsuário";
            Text = "Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsu;
        private Label lblSen;
        private Label lbl3;
        private TextBox txtUsu;
        private TextBox txtSen;
        private CheckBox cb1;
        private Button btnCadas;
        private Button btnEx;
        private ListBox list1;
    }
}