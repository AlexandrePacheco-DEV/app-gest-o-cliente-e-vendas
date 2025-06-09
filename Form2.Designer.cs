namespace gestão_de_negócio_clientes_e_vendas
{
    partial class cadastro_clientes
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
            lbl_user = new Label();
            btn_clientes = new Button();
            btn_produtos = new Button();
            btn_pedidos = new Button();
            cadastro_usuarios = new Button();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(158, 70);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(50, 20);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "label1";
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(36, 218);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(94, 29);
            btn_clientes.TabIndex = 1;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_produtos
            // 
            btn_produtos.Location = new Point(136, 218);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Size = new Size(94, 29);
            btn_produtos.TabIndex = 2;
            btn_produtos.Text = "PRODUTOS";
            btn_produtos.UseVisualStyleBackColor = true;
            btn_produtos.Click += btn_produtos_Click;
            // 
            // btn_pedidos
            // 
            btn_pedidos.Location = new Point(236, 218);
            btn_pedidos.Name = "btn_pedidos";
            btn_pedidos.Size = new Size(94, 29);
            btn_pedidos.TabIndex = 3;
            btn_pedidos.Text = "PEDIDOS";
            btn_pedidos.UseVisualStyleBackColor = true;
            btn_pedidos.Click += btn_pedidos_Click;
            // 
            // cadastro_usuarios
            // 
            cadastro_usuarios.Location = new Point(115, 263);
            cadastro_usuarios.Name = "cadastro_usuarios";
            cadastro_usuarios.Size = new Size(163, 29);
            cadastro_usuarios.TabIndex = 4;
            cadastro_usuarios.Text = "NOVO USUARIO";
            cadastro_usuarios.UseVisualStyleBackColor = true;
            cadastro_usuarios.Click += cadastro_usuarios_Click;
            // 
            // cadastro_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 433);
            Controls.Add(cadastro_usuarios);
            Controls.Add(btn_pedidos);
            Controls.Add(btn_produtos);
            Controls.Add(btn_clientes);
            Controls.Add(lbl_user);
            Name = "cadastro_clientes";
            Text = "CLIENTES";
            Load += cadastro_clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private Button btn_clientes;
        private Button btn_produtos;
        private Button btn_pedidos;
        private Button cadastro_usuarios;
    }
}