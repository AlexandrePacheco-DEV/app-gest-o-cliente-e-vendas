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
            listUsuarios = new ListBox();
            PassUsuario = new TextBox();
            usuarioSenha = new TextBox();
            SuspendLayout();
            // 
            // btn_excluirUsuario
            // 
            btn_excluirUsuario.Location = new Point(144, 341);
            btn_excluirUsuario.Name = "btn_excluirUsuario";
            btn_excluirUsuario.Size = new Size(94, 29);
            btn_excluirUsuario.TabIndex = 0;
            btn_excluirUsuario.Text = "EXCLUIR";
            btn_excluirUsuario.UseVisualStyleBackColor = true;
            btn_excluirUsuario.Click += btn_excluirUsuario_Click;
            // 
            // btn_adicionarUsuario
            // 
            btn_adicionarUsuario.Location = new Point(524, 341);
            btn_adicionarUsuario.Name = "btn_adicionarUsuario";
            btn_adicionarUsuario.Size = new Size(141, 29);
            btn_adicionarUsuario.TabIndex = 1;
            btn_adicionarUsuario.Text = "ADD USUÁRIO";
            btn_adicionarUsuario.UseVisualStyleBackColor = true;
            btn_adicionarUsuario.Click += btn_adicionarUsuario_Click;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(372, 9);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(50, 20);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "label1";
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.Location = new Point(144, 54);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(521, 104);
            listUsuarios.TabIndex = 3;
            // 
            // PassUsuario
            // 
            PassUsuario.Location = new Point(144, 209);
            PassUsuario.Name = "PassUsuario";
            PassUsuario.Size = new Size(521, 27);
            PassUsuario.TabIndex = 4;
            // 
            // usuarioSenha
            // 
            usuarioSenha.Location = new Point(144, 257);
            usuarioSenha.Name = "usuarioSenha";
            usuarioSenha.Size = new Size(521, 27);
            usuarioSenha.TabIndex = 5;
            // 
            // cadastro_users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(usuarioSenha);
            Controls.Add(PassUsuario);
            Controls.Add(listUsuarios);
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
        private ListBox listUsuarios;
        private TextBox PassUsuario;
        private TextBox usuarioSenha;
    }
}