namespace gestão_de_negócio_clientes_e_vendas
{
    partial class clientes
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
            btn_buscarCep = new Button();
            txtLogradouro = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtEstado = new TextBox();
            txtCep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_buscarCep
            // 
            btn_buscarCep.Location = new Point(340, 345);
            btn_buscarCep.Name = "btn_buscarCep";
            btn_buscarCep.Size = new Size(94, 29);
            btn_buscarCep.TabIndex = 0;
            btn_buscarCep.Text = "BUSCAR";
            btn_buscarCep.UseVisualStyleBackColor = true;
            btn_buscarCep.Click += btn_buscarCep_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(236, 182);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(125, 27);
            txtLogradouro.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(236, 252);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 27);
            txtCidade.TabIndex = 2;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(390, 182);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(125, 27);
            txtBairro.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(390, 252);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(236, 100);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(279, 27);
            txtCep.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 62);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 159);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "LOGRADOURO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 159);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "BAIRRO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 229);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "ESTADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 229);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "CIDADE";
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCep);
            Controls.Add(txtEstado);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtLogradouro);
            Controls.Add(btn_buscarCep);
            Name = "clientes";
            Text = "Form7";
            Load += clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscarCep;
        private TextBox txtLogradouro;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtEstado;
        private TextBox txtCep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}