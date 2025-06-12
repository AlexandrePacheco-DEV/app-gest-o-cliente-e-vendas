namespace gestão_de_negócio_clientes_e_vendas
{
    partial class cadastro_pedidos
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
            txtCPFCliente = new TextBox();
            lblNomeCliente = new Label();
            label1 = new Label();
            btnBuscarCliente = new Button();
            btnAdicionarItem = new Button();
            txtCodigoProduto = new TextBox();
            txtQuantidade = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblTotalPedido = new Label();
            SuspendLayout();
            // 
            // txtCPFCliente
            // 
            txtCPFCliente.Location = new Point(59, 133);
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(125, 27);
            txtCPFCliente.TabIndex = 0;
            txtCPFCliente.TextChanged += txtCPFCliente_TextChanged;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(81, 38);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(67, 20);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "CLIENTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 104);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "CPF DO CLIENTE";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(12, 199);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(215, 29);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "BUSCAR CLIENTE";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Location = new Point(472, 295);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(215, 29);
            btnAdicionarItem.TabIndex = 4;
            btnAdicionarItem.Text = "ADICIONAR ITENS";
            btnAdicionarItem.UseVisualStyleBackColor = true;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(505, 116);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(125, 27);
            txtCodigoProduto.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(501, 201);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 93);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 7;
            label2.Text = "CÓDIGO PRODUTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 178);
            label3.Name = "label3";
            label3.Size = new Size(182, 20);
            label3.TabIndex = 8;
            label3.Text = "QUANTIDADE PRODUTOS";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(519, 245);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(107, 20);
            lblTotalPedido.TabIndex = 9;
            lblTotalPedido.Text = "TOTAL PEDIDO";
            // 
            // cadastro_pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalPedido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQuantidade);
            Controls.Add(txtCodigoProduto);
            Controls.Add(btnAdicionarItem);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label1);
            Controls.Add(lblNomeCliente);
            Controls.Add(txtCPFCliente);
            Name = "cadastro_pedidos";
            Text = "Form4";
            Load += cadastro_pedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFCliente;
        private Label lblNomeCliente;
        private Label label1;
        private Button btnBuscarCliente;
        private Button btnAdicionarItem;
        private TextBox txtCodigoProduto;
        private TextBox txtQuantidade;
        private Label label2;
        private Label label3;
        private Label lblTotalPedido;
    }
}