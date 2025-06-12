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
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_buscarPedidos
            // 
            btn_buscarPedidos.Location = new Point(258, 338);
            btn_buscarPedidos.Name = "btn_buscarPedidos";
            btn_buscarPedidos.Size = new Size(204, 29);
            btn_buscarPedidos.TabIndex = 0;
            btn_buscarPedidos.Text = "BUSCAR PEDIDO";
            btn_buscarPedidos.UseVisualStyleBackColor = true;
            btn_buscarPedidos.Click += btn_buscarPedidos_Click;
            // 
            // txt_BuscarCpf
            // 
            txt_BuscarCpf.Location = new Point(234, 200);
            txt_BuscarCpf.Name = "txt_BuscarCpf";
            txt_BuscarCpf.Size = new Size(275, 27);
            txt_BuscarCpf.TabIndex = 1;
            // 
            // lblNomeConsulta
            // 
            lblNomeConsulta.AutoSize = true;
            lblNomeConsulta.Location = new Point(338, 167);
            lblNomeConsulta.Name = "lblNomeConsulta";
            lblNomeConsulta.Size = new Size(67, 20);
            lblNomeConsulta.TabIndex = 2;
            lblNomeConsulta.Text = "CLIENTE:";
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.Location = new Point(107, 49);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(552, 104);
            listPedidos.TabIndex = 3;
            listPedidos.SelectedIndexChanged += listPedidos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 261);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // rastrear_pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listPedidos);
            Controls.Add(lblNomeConsulta);
            Controls.Add(txt_BuscarCpf);
            Controls.Add(btn_buscarPedidos);
            Name = "rastrear_pedido";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscarPedidos;
        private TextBox txt_BuscarCpf;
        private Label lblNomeConsulta;
        private ListBox listPedidos;
        private Label label1;
    }
}