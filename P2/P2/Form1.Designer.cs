namespace P2
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
            btnEntrar = new Button();
            lbl1 = new Label();
            txtUsu = new TextBox();
            txtSen = new TextBox();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(58, 119);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Usuário:";
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(12, 27);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(168, 23);
            txtUsu.TabIndex = 2;
            // 
            // txtSen
            // 
            txtSen.Location = new Point(12, 80);
            txtSen.Name = "txtSen";
            txtSen.Size = new Size(168, 23);
            txtSen.TabIndex = 3;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 62);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(42, 15);
            lbl2.TabIndex = 4;
            lbl2.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 164);
            Controls.Add(lbl2);
            Controls.Add(txtSen);
            Controls.Add(txtUsu);
            Controls.Add(lbl1);
            Controls.Add(btnEntrar);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lbl1;
        private TextBox txtUsu;
        private TextBox txtSen;
        private Label lbl2;
    }
}
