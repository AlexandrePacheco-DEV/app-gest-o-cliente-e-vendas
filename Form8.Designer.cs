namespace gestão_de_negócio_clientes_e_vendas
{
    partial class rastrear_pedido
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
            btn_buscarPedidos = new Button();
            txt_BuscarCpf = new TextBox();
            lblNomeConsulta = new Label();
            listPedidos = new ListBox();
            lblTotalConsulta = new Label();
            listItens = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_buscarPedidos
            // 
            btn_buscarPedidos.BackColor = Color.FromArgb(128, 255, 128);
            btn_buscarPedidos.Location = new Point(40, 293);
            btn_buscarPedidos.Name = "btn_buscarPedidos";
            btn_buscarPedidos.Size = new Size(204, 29);
            btn_buscarPedidos.TabIndex = 0;
            btn_buscarPedidos.Text = "BUSCAR PEDIDO";
            btn_buscarPedidos.UseVisualStyleBackColor = false;
            btn_buscarPedidos.Click += btn_buscarPedidos_Click;
            // 
            // txt_BuscarCpf
            // 
            txt_BuscarCpf.Location = new Point(16, 140);
            txt_BuscarCpf.Name = "txt_BuscarCpf";
            txt_BuscarCpf.Size = new Size(275, 27);
            txt_BuscarCpf.TabIndex = 1;
            // 
            // lblNomeConsulta
            // 
            lblNomeConsulta.AutoSize = true;
            lblNomeConsulta.Location = new Point(16, 103);
            lblNomeConsulta.Name = "lblNomeConsulta";
            lblNomeConsulta.Size = new Size(67, 20);
            lblNomeConsulta.TabIndex = 2;
            lblNomeConsulta.Text = "CLIENTE:";
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.Location = new Point(341, 126);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(438, 84);
            listPedidos.TabIndex = 3;
            listPedidos.SelectedIndexChanged += listPedidos_SelectedIndexChanged;
            // 
            // lblTotalConsulta
            // 
            lblTotalConsulta.AutoSize = true;
            lblTotalConsulta.Location = new Point(16, 204);
            lblTotalConsulta.Name = "lblTotalConsulta";
            lblTotalConsulta.Size = new Size(99, 20);
            lblTotalConsulta.TabIndex = 4;
            lblTotalConsulta.Text = "VALOR FINAL:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(341, 257);
            listItens.Name = "listItens";
            listItens.Size = new Size(438, 104);
            listItens.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 225);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "ITENS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 103);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "PEDIDOS:";
            // 
            // rastrear_pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listItens);
            Controls.Add(lblTotalConsulta);
            Controls.Add(listPedidos);
            Controls.Add(lblNomeConsulta);
            Controls.Add(txt_BuscarCpf);
            Controls.Add(btn_buscarPedidos);
            Name = "rastrear_pedido";
            Text = "RASTREAR PEDIDOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscarPedidos;
        private TextBox txt_BuscarCpf;
        private Label lblNomeConsulta;
        private ListBox listPedidos;
        private Label lblTotalConsulta;
        private ListBox listItens;
        private Label label1;
        private Label label2;
    }
}