namespace gestão_de_negócio_clientes_e_vendas
{
    partial class cadastro_users
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
            btn_excluirUsuario = new Button();
            btn_adicionarUsuario = new Button();
            lbl_user = new Label();
            SuspendLayout();
            // 
            // btn_excluirUsuario
            // 
            btn_excluirUsuario.Location = new Point(144, 255);
            btn_excluirUsuario.Name = "btn_excluirUsuario";
            btn_excluirUsuario.Size = new Size(94, 29);
            btn_excluirUsuario.TabIndex = 0;
            btn_excluirUsuario.Text = "EXCLUIR";
            btn_excluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_adicionarUsuario
            // 
            btn_adicionarUsuario.Location = new Point(501, 255);
            btn_adicionarUsuario.Name = "btn_adicionarUsuario";
            btn_adicionarUsuario.Size = new Size(141, 29);
            btn_adicionarUsuario.TabIndex = 1;
            btn_adicionarUsuario.Text = "ADD USUÁRIO";
            btn_adicionarUsuario.UseVisualStyleBackColor = true;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(351, 44);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(50, 20);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "label1";
            // 
            // cadastro_users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_user);
            Controls.Add(btn_adicionarUsuario);
            Controls.Add(btn_excluirUsuario);
            Name = "cadastro_users";
            Text = "Form3";
            Load += cadastro_users_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_excluirUsuario;
        private Button btn_adicionarUsuario;
        private Label lbl_user;
    }
}