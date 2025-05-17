namespace Atividade_UC_12
{
    partial class Pedido
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lboDadosPedidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(271, 255);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 45);
            this.btnExcluir.TabIndex = 94;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(838, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 45);
            this.btnLimpar.TabIndex = 93;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(550, 255);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(133, 45);
            this.btnAtualizar.TabIndex = 92;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(13, 255);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 45);
            this.btnAdicionar.TabIndex = 91;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(740, 52);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(202, 26);
            this.txtStatus.TabIndex = 90;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(735, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 89;
            this.lblStatus.Text = "Status";
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPedido.Location = new System.Drawing.Point(508, 52);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.Size = new System.Drawing.Size(164, 26);
            this.txtDataPedido.TabIndex = 88;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedido.Location = new System.Drawing.Point(504, 22);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(119, 20);
            this.lblDataPedido.TabIndex = 87;
            this.lblDataPedido.Text = "Data de Pedido";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(38, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 26);
            this.txtID.TabIndex = 86;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(254, 52);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(164, 26);
            this.txtIDCliente.TabIndex = 85;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(250, 22);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(79, 20);
            this.lblIDCliente.TabIndex = 84;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(34, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 20);
            this.lblID.TabIndex = 83;
            this.lblID.Text = "ID Pedido";
            // 
            // lboDadosPedidos
            // 
            this.lboDadosPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboDadosPedidos.FormattingEnabled = true;
            this.lboDadosPedidos.ItemHeight = 20;
            this.lboDadosPedidos.Location = new System.Drawing.Point(13, 326);
            this.lboDadosPedidos.Name = "lboDadosPedidos";
            this.lboDadosPedidos.Size = new System.Drawing.Size(960, 204);
            this.lboDadosPedidos.TabIndex = 82;
            this.lboDadosPedidos.SelectedValueChanged += new System.EventHandler(this.lboDadosPedidos_SelectedValueChanged);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDataPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lboDadosPedidos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListBox lboDadosPedidos;
    }
}