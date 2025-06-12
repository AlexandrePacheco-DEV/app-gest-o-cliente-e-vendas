namespace gestão_de_negócio_clientes_e_vendas
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
            btn_login = new Button();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 192, 0);
            btn_login.Location = new Point(247, 354);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(294, 29);
            btn_login.TabIndex = 0;
            btn_login.Text = "ENTRAR";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(247, 154);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(294, 27);
            txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(247, 212);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(294, 27);
            txt_senha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 118);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 188);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "SENHA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(btn_login);
            Name = "Form1";
            Text = "LOGIN ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Label label1;
        private Label label2;
    }
}
