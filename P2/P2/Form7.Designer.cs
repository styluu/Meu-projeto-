namespace P2
{
    partial class frmSenha
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
            btnSalvar = new Button();
            lblNova = new Label();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(192, 6);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(52, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNova
            // 
            lblNova.AutoSize = true;
            lblNova.Location = new Point(8, 9);
            lblNova.Name = "lblNova";
            lblNova.Size = new Size(72, 15);
            lblNova.TabIndex = 1;
            lblNova.Text = "Nova senha:";
            // 
            // txt1
            // 
            txt1.Location = new Point(86, 7);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 2;
            // 
            // frmSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 35);
            Controls.Add(txt1);
            Controls.Add(lblNova);
            Controls.Add(btnSalvar);
            Name = "frmSenha";
            Text = "Senha:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label lblNova;
        private TextBox txt1;
    }
}