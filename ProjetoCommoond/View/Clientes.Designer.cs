
namespace ProjetoCommoond.View
{
    partial class Clientes
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
            this.groupInfoCliente = new System.Windows.Forms.GroupBox();
            this.lblClienteObs = new System.Windows.Forms.Label();
            this.txtClienteObs = new System.Windows.Forms.RichTextBox();
            this.lblClienteCnpj = new System.Windows.Forms.Label();
            this.txtClienteRazao = new System.Windows.Forms.TextBox();
            this.txtClienteNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtClienteCnpj = new System.Windows.Forms.TextBox();
            this.lblClienteNomeFantasia = new System.Windows.Forms.Label();
            this.lblClienteRazao = new System.Windows.Forms.Label();
            this.txtClienteInscricao = new System.Windows.Forms.TextBox();
            this.lblClienteInscricao = new System.Windows.Forms.Label();
            this.btnClienteAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnClienteEditar = new FontAwesome.Sharp.IconButton();
            this.dataFornec = new System.Windows.Forms.DataGridView();
            this.btnClienteCancelar = new FontAwesome.Sharp.IconButton();
            this.groupContatoCliente = new System.Windows.Forms.GroupBox();
            this.lblClienteContatoTelefone = new System.Windows.Forms.Label();
            this.txtClienteContatoTelefone = new System.Windows.Forms.TextBox();
            this.lblClienteContatoEmail = new System.Windows.Forms.Label();
            this.txtClienteContatoEmail = new System.Windows.Forms.TextBox();
            this.lblClienteContatoNome = new System.Windows.Forms.Label();
            this.txtClienteContatoNome = new System.Windows.Forms.TextBox();
            this.btnClienteExcluir = new FontAwesome.Sharp.IconButton();
            this.groupInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).BeginInit();
            this.groupContatoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoCliente
            // 
            this.groupInfoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupInfoCliente.Controls.Add(this.lblClienteObs);
            this.groupInfoCliente.Controls.Add(this.txtClienteObs);
            this.groupInfoCliente.Controls.Add(this.lblClienteCnpj);
            this.groupInfoCliente.Controls.Add(this.txtClienteRazao);
            this.groupInfoCliente.Controls.Add(this.txtClienteNomeFantasia);
            this.groupInfoCliente.Controls.Add(this.txtClienteCnpj);
            this.groupInfoCliente.Controls.Add(this.lblClienteNomeFantasia);
            this.groupInfoCliente.Controls.Add(this.lblClienteRazao);
            this.groupInfoCliente.Controls.Add(this.txtClienteInscricao);
            this.groupInfoCliente.Controls.Add(this.lblClienteInscricao);
            this.groupInfoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInfoCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupInfoCliente.ForeColor = System.Drawing.Color.White;
            this.groupInfoCliente.Location = new System.Drawing.Point(11, 10);
            this.groupInfoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoCliente.Name = "groupInfoCliente";
            this.groupInfoCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoCliente.Size = new System.Drawing.Size(601, 332);
            this.groupInfoCliente.TabIndex = 21;
            this.groupInfoCliente.TabStop = false;
            this.groupInfoCliente.Text = "Informações empresariais";
            // 
            // lblClienteObs
            // 
            this.lblClienteObs.AutoSize = true;
            this.lblClienteObs.ForeColor = System.Drawing.Color.White;
            this.lblClienteObs.Location = new System.Drawing.Point(19, 170);
            this.lblClienteObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteObs.Name = "lblClienteObs";
            this.lblClienteObs.Size = new System.Drawing.Size(228, 28);
            this.lblClienteObs.TabIndex = 11;
            this.lblClienteObs.Text = "Observações e endereço:";
            // 
            // txtClienteObs
            // 
            this.txtClienteObs.Location = new System.Drawing.Point(17, 198);
            this.txtClienteObs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteObs.Name = "txtClienteObs";
            this.txtClienteObs.Size = new System.Drawing.Size(570, 116);
            this.txtClienteObs.TabIndex = 10;
            this.txtClienteObs.Text = "";
            // 
            // lblClienteCnpj
            // 
            this.lblClienteCnpj.AutoSize = true;
            this.lblClienteCnpj.ForeColor = System.Drawing.Color.White;
            this.lblClienteCnpj.Location = new System.Drawing.Point(19, 44);
            this.lblClienteCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteCnpj.Name = "lblClienteCnpj";
            this.lblClienteCnpj.Size = new System.Drawing.Size(56, 28);
            this.lblClienteCnpj.TabIndex = 0;
            this.lblClienteCnpj.Text = "CNPJ";
            // 
            // txtClienteRazao
            // 
            this.txtClienteRazao.Location = new System.Drawing.Point(247, 72);
            this.txtClienteRazao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteRazao.Name = "txtClienteRazao";
            this.txtClienteRazao.Size = new System.Drawing.Size(340, 34);
            this.txtClienteRazao.TabIndex = 3;
            // 
            // txtClienteNomeFantasia
            // 
            this.txtClienteNomeFantasia.Location = new System.Drawing.Point(247, 135);
            this.txtClienteNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteNomeFantasia.Name = "txtClienteNomeFantasia";
            this.txtClienteNomeFantasia.Size = new System.Drawing.Size(340, 34);
            this.txtClienteNomeFantasia.TabIndex = 9;
            // 
            // txtClienteCnpj
            // 
            this.txtClienteCnpj.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClienteCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteCnpj.Location = new System.Drawing.Point(17, 73);
            this.txtClienteCnpj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteCnpj.Name = "txtClienteCnpj";
            this.txtClienteCnpj.Size = new System.Drawing.Size(212, 34);
            this.txtClienteCnpj.TabIndex = 1;
            // 
            // lblClienteNomeFantasia
            // 
            this.lblClienteNomeFantasia.AutoSize = true;
            this.lblClienteNomeFantasia.ForeColor = System.Drawing.Color.White;
            this.lblClienteNomeFantasia.Location = new System.Drawing.Point(249, 106);
            this.lblClienteNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteNomeFantasia.Name = "lblClienteNomeFantasia";
            this.lblClienteNomeFantasia.Size = new System.Drawing.Size(141, 28);
            this.lblClienteNomeFantasia.TabIndex = 8;
            this.lblClienteNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblClienteRazao
            // 
            this.lblClienteRazao.AutoSize = true;
            this.lblClienteRazao.ForeColor = System.Drawing.Color.White;
            this.lblClienteRazao.Location = new System.Drawing.Point(249, 44);
            this.lblClienteRazao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteRazao.Name = "lblClienteRazao";
            this.lblClienteRazao.Size = new System.Drawing.Size(122, 28);
            this.lblClienteRazao.TabIndex = 2;
            this.lblClienteRazao.Text = "Razão Social";
            // 
            // txtClienteInscricao
            // 
            this.txtClienteInscricao.Location = new System.Drawing.Point(17, 135);
            this.txtClienteInscricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteInscricao.Name = "txtClienteInscricao";
            this.txtClienteInscricao.Size = new System.Drawing.Size(212, 34);
            this.txtClienteInscricao.TabIndex = 7;
            // 
            // lblClienteInscricao
            // 
            this.lblClienteInscricao.AutoSize = true;
            this.lblClienteInscricao.ForeColor = System.Drawing.Color.White;
            this.lblClienteInscricao.Location = new System.Drawing.Point(19, 106);
            this.lblClienteInscricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteInscricao.Name = "lblClienteInscricao";
            this.lblClienteInscricao.Size = new System.Drawing.Size(166, 28);
            this.lblClienteInscricao.TabIndex = 6;
            this.lblClienteInscricao.Text = "Inscrição Estadual";
            // 
            // btnClienteAdicionar
            // 
            this.btnClienteAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClienteAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnClienteAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnClienteAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteAdicionar.Location = new System.Drawing.Point(620, 267);
            this.btnClienteAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteAdicionar.Name = "btnClienteAdicionar";
            this.btnClienteAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnClienteAdicionar.TabIndex = 24;
            this.btnClienteAdicionar.Text = "Adicionar";
            this.btnClienteAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnClienteEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteEditar.IconColor = System.Drawing.Color.Black;
            this.btnClienteEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteEditar.Location = new System.Drawing.Point(620, 308);
            this.btnClienteEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(159, 34);
            this.btnClienteEditar.TabIndex = 25;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = false;
            // 
            // dataFornec
            // 
            this.dataFornec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.dataFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFornec.Location = new System.Drawing.Point(11, 348);
            this.dataFornec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataFornec.Name = "dataFornec";
            this.dataFornec.RowHeadersWidth = 51;
            this.dataFornec.RowTemplate.Height = 25;
            this.dataFornec.Size = new System.Drawing.Size(937, 184);
            this.dataFornec.TabIndex = 23;
            // 
            // btnClienteCancelar
            // 
            this.btnClienteCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClienteCancelar.ForeColor = System.Drawing.Color.White;
            this.btnClienteCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteCancelar.IconColor = System.Drawing.Color.Black;
            this.btnClienteCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteCancelar.Location = new System.Drawing.Point(789, 267);
            this.btnClienteCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteCancelar.Name = "btnClienteCancelar";
            this.btnClienteCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnClienteCancelar.TabIndex = 26;
            this.btnClienteCancelar.Text = "Cancelar";
            this.btnClienteCancelar.UseVisualStyleBackColor = false;
            // 
            // groupContatoCliente
            // 
            this.groupContatoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoTelefone);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoTelefone);
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoEmail);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoEmail);
            this.groupContatoCliente.Controls.Add(this.lblClienteContatoNome);
            this.groupContatoCliente.Controls.Add(this.txtClienteContatoNome);
            this.groupContatoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupContatoCliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupContatoCliente.ForeColor = System.Drawing.Color.White;
            this.groupContatoCliente.Location = new System.Drawing.Point(620, 10);
            this.groupContatoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoCliente.Name = "groupContatoCliente";
            this.groupContatoCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoCliente.Size = new System.Drawing.Size(329, 251);
            this.groupContatoCliente.TabIndex = 22;
            this.groupContatoCliente.TabStop = false;
            this.groupContatoCliente.Text = "Contatos";
            // 
            // lblClienteContatoTelefone
            // 
            this.lblClienteContatoTelefone.AutoSize = true;
            this.lblClienteContatoTelefone.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoTelefone.Location = new System.Drawing.Point(17, 170);
            this.lblClienteContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoTelefone.Name = "lblClienteContatoTelefone";
            this.lblClienteContatoTelefone.Size = new System.Drawing.Size(164, 28);
            this.lblClienteContatoTelefone.TabIndex = 16;
            this.lblClienteContatoTelefone.Text = "Telefone Principal";
            // 
            // txtClienteContatoTelefone
            // 
            this.txtClienteContatoTelefone.Location = new System.Drawing.Point(15, 198);
            this.txtClienteContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoTelefone.Name = "txtClienteContatoTelefone";
            this.txtClienteContatoTelefone.Size = new System.Drawing.Size(296, 34);
            this.txtClienteContatoTelefone.TabIndex = 17;
            // 
            // lblClienteContatoEmail
            // 
            this.lblClienteContatoEmail.AutoSize = true;
            this.lblClienteContatoEmail.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoEmail.Location = new System.Drawing.Point(17, 106);
            this.lblClienteContatoEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoEmail.Name = "lblClienteContatoEmail";
            this.lblClienteContatoEmail.Size = new System.Drawing.Size(67, 28);
            this.lblClienteContatoEmail.TabIndex = 14;
            this.lblClienteContatoEmail.Text = "E-mail";
            // 
            // txtClienteContatoEmail
            // 
            this.txtClienteContatoEmail.Location = new System.Drawing.Point(15, 135);
            this.txtClienteContatoEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoEmail.Name = "txtClienteContatoEmail";
            this.txtClienteContatoEmail.Size = new System.Drawing.Size(296, 34);
            this.txtClienteContatoEmail.TabIndex = 15;
            // 
            // lblClienteContatoNome
            // 
            this.lblClienteContatoNome.AutoSize = true;
            this.lblClienteContatoNome.ForeColor = System.Drawing.Color.White;
            this.lblClienteContatoNome.Location = new System.Drawing.Point(17, 44);
            this.lblClienteContatoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteContatoNome.Name = "lblClienteContatoNome";
            this.lblClienteContatoNome.Size = new System.Drawing.Size(171, 28);
            this.lblClienteContatoNome.TabIndex = 12;
            this.lblClienteContatoNome.Text = "Nome do Contato";
            // 
            // txtClienteContatoNome
            // 
            this.txtClienteContatoNome.Location = new System.Drawing.Point(15, 72);
            this.txtClienteContatoNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteContatoNome.Name = "txtClienteContatoNome";
            this.txtClienteContatoNome.Size = new System.Drawing.Size(296, 34);
            this.txtClienteContatoNome.TabIndex = 13;
            // 
            // btnClienteExcluir
            // 
            this.btnClienteExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnClienteExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClienteExcluir.ForeColor = System.Drawing.Color.White;
            this.btnClienteExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteExcluir.IconColor = System.Drawing.Color.Black;
            this.btnClienteExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteExcluir.Location = new System.Drawing.Point(789, 308);
            this.btnClienteExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteExcluir.Name = "btnClienteExcluir";
            this.btnClienteExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnClienteExcluir.TabIndex = 27;
            this.btnClienteExcluir.Text = "Excluir";
            this.btnClienteExcluir.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupInfoCliente);
            this.Controls.Add(this.btnClienteAdicionar);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.dataFornec);
            this.Controls.Add(this.btnClienteCancelar);
            this.Controls.Add(this.groupContatoCliente);
            this.Controls.Add(this.btnClienteExcluir);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupInfoCliente.ResumeLayout(false);
            this.groupInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).EndInit();
            this.groupContatoCliente.ResumeLayout(false);
            this.groupContatoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoCliente;
        private System.Windows.Forms.Label lblClienteObs;
        private System.Windows.Forms.RichTextBox txtClienteObs;
        private System.Windows.Forms.Label lblClienteCnpj;
        private System.Windows.Forms.TextBox txtClienteRazao;
        private System.Windows.Forms.TextBox txtClienteNomeFantasia;
        private System.Windows.Forms.TextBox txtClienteCnpj;
        private System.Windows.Forms.Label lblClienteNomeFantasia;
        private System.Windows.Forms.Label lblClienteRazao;
        private System.Windows.Forms.TextBox txtClienteInscricao;
        private System.Windows.Forms.Label lblClienteInscricao;
        private FontAwesome.Sharp.IconButton btnClienteAdicionar;
        private FontAwesome.Sharp.IconButton btnClienteEditar;
        private System.Windows.Forms.DataGridView dataFornec;
        private FontAwesome.Sharp.IconButton btnClienteCancelar;
        private System.Windows.Forms.GroupBox groupContatoCliente;
        private System.Windows.Forms.Label lblClienteContatoTelefone;
        private System.Windows.Forms.TextBox txtClienteContatoTelefone;
        private System.Windows.Forms.Label lblClienteContatoEmail;
        private System.Windows.Forms.TextBox txtClienteContatoEmail;
        private System.Windows.Forms.Label lblClienteContatoNome;
        private System.Windows.Forms.TextBox txtClienteContatoNome;
        private FontAwesome.Sharp.IconButton btnClienteExcluir;
    }
}