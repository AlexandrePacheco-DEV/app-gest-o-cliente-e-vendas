namespace gestão_de_negócio_clientes_e_vendas
{
    partial class cadastro_produtos
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
            listProdutos = new ListBox();
            btnAdicionarProdutos = new Button();
            txtCodigo = new TextBox();
            txtPreco = new TextBox();
            txtProduto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDescricao = new TextBox();
            btn_excluirProdutos = new Button();
            SuspendLayout();
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.Location = new Point(173, 53);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(446, 64);
            listProdutos.TabIndex = 0;
            // 
            // btnAdicionarProdutos
            // 
            btnAdicionarProdutos.Location = new Point(173, 339);
            btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            btnAdicionarProdutos.Size = new Size(159, 29);
            btnAdicionarProdutos.TabIndex = 2;
            btnAdicionarProdutos.Text = "ADD PRODUTOS";
            btnAdicionarProdutos.UseVisualStyleBackColor = true;
            btnAdicionarProdutos.Click += btnAdicionarProdutos_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(187, 190);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(481, 190);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 4;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(338, 190);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(125, 27);
            txtProduto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 161);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 167);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 167);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "PREÇO UNI";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(338, 240);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 9;
            txtDescricao.Text = "DESCRIÇÃO";
            // 
            // btn_excluirProdutos
            // 
            btn_excluirProdutos.Location = new Point(460, 339);
            btn_excluirProdutos.Name = "btn_excluirProdutos";
            btn_excluirProdutos.Size = new Size(159, 29);
            btn_excluirProdutos.TabIndex = 10;
            btn_excluirProdutos.Text = "EXCLUIR PRODUTOS";
            btn_excluirProdutos.UseVisualStyleBackColor = true;
            btn_excluirProdutos.Click += btn_excluirProdutos_Click;
            // 
            // cadastro_produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_excluirProdutos);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Controls.Add(txtPreco);
            Controls.Add(txtCodigo);
            Controls.Add(btnAdicionarProdutos);
            Controls.Add(listProdutos);
            Name = "cadastro_produtos";
            Text = "Form5";
            Load += cadastro_produtos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listProdutos;
        private Button btnAdicionarProdutos;
        private TextBox txtCodigo;
        private TextBox txtPreco;
        private TextBox txtProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDescricao;
        private Button btn_excluirProdutos;
    }
}