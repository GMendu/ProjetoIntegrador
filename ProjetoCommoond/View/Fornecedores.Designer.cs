
namespace ProjetoCommoond.View
{
    partial class Fornecedores
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
            this.groupInfoFornec = new System.Windows.Forms.GroupBox();
            this.lblFornecObs = new System.Windows.Forms.Label();
            this.txtFornecObs = new System.Windows.Forms.RichTextBox();
            this.lblFornecCnpj = new System.Windows.Forms.Label();
            this.txtFornecRazao = new System.Windows.Forms.TextBox();
            this.txtFornecNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtFornecCnpj = new System.Windows.Forms.TextBox();
            this.lblFornecNomeFantasia = new System.Windows.Forms.Label();
            this.lblFornecRazao = new System.Windows.Forms.Label();
            this.txtFornecInscricao = new System.Windows.Forms.TextBox();
            this.lblFornecInscricao = new System.Windows.Forms.Label();
            this.btnFornecAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnFornecEditar = new FontAwesome.Sharp.IconButton();
            this.dataFornec = new System.Windows.Forms.DataGridView();
            this.btnFornecCancelar = new FontAwesome.Sharp.IconButton();
            this.groupContatoFornec = new System.Windows.Forms.GroupBox();
            this.lblFornecContatoTelefone = new System.Windows.Forms.Label();
            this.txtFornecContatoTelefone = new System.Windows.Forms.TextBox();
            this.lblFornecContatoEmail = new System.Windows.Forms.Label();
            this.txtFornecContatoEmail = new System.Windows.Forms.TextBox();
            this.lblFornecContatoNome = new System.Windows.Forms.Label();
            this.txtFornecContatoNome = new System.Windows.Forms.TextBox();
            this.btnFornecExcluir = new FontAwesome.Sharp.IconButton();
            this.groupInfoFornec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).BeginInit();
            this.groupContatoFornec.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoFornec
            // 
            this.groupInfoFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupInfoFornec.Controls.Add(this.lblFornecObs);
            this.groupInfoFornec.Controls.Add(this.txtFornecObs);
            this.groupInfoFornec.Controls.Add(this.lblFornecCnpj);
            this.groupInfoFornec.Controls.Add(this.txtFornecRazao);
            this.groupInfoFornec.Controls.Add(this.txtFornecNomeFantasia);
            this.groupInfoFornec.Controls.Add(this.txtFornecCnpj);
            this.groupInfoFornec.Controls.Add(this.lblFornecNomeFantasia);
            this.groupInfoFornec.Controls.Add(this.lblFornecRazao);
            this.groupInfoFornec.Controls.Add(this.txtFornecInscricao);
            this.groupInfoFornec.Controls.Add(this.lblFornecInscricao);
            this.groupInfoFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInfoFornec.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupInfoFornec.ForeColor = System.Drawing.Color.White;
            this.groupInfoFornec.Location = new System.Drawing.Point(11, 10);
            this.groupInfoFornec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoFornec.Name = "groupInfoFornec";
            this.groupInfoFornec.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupInfoFornec.Size = new System.Drawing.Size(601, 332);
            this.groupInfoFornec.TabIndex = 14;
            this.groupInfoFornec.TabStop = false;
            this.groupInfoFornec.Text = "Informações empresariais";
            // 
            // lblFornecObs
            // 
            this.lblFornecObs.AutoSize = true;
            this.lblFornecObs.ForeColor = System.Drawing.Color.White;
            this.lblFornecObs.Location = new System.Drawing.Point(18, 170);
            this.lblFornecObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecObs.Name = "lblFornecObs";
            this.lblFornecObs.Size = new System.Drawing.Size(228, 28);
            this.lblFornecObs.TabIndex = 11;
            this.lblFornecObs.Text = "Observações e endereço:";
            // 
            // txtFornecObs
            // 
            this.txtFornecObs.Location = new System.Drawing.Point(17, 198);
            this.txtFornecObs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecObs.Name = "txtFornecObs";
            this.txtFornecObs.Size = new System.Drawing.Size(570, 116);
            this.txtFornecObs.TabIndex = 10;
            this.txtFornecObs.Text = "";
            // 
            // lblFornecCnpj
            // 
            this.lblFornecCnpj.AutoSize = true;
            this.lblFornecCnpj.ForeColor = System.Drawing.Color.White;
            this.lblFornecCnpj.Location = new System.Drawing.Point(18, 44);
            this.lblFornecCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecCnpj.Name = "lblFornecCnpj";
            this.lblFornecCnpj.Size = new System.Drawing.Size(56, 28);
            this.lblFornecCnpj.TabIndex = 0;
            this.lblFornecCnpj.Text = "CNPJ";
            // 
            // txtFornecRazao
            // 
            this.txtFornecRazao.Location = new System.Drawing.Point(247, 72);
            this.txtFornecRazao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecRazao.Name = "txtFornecRazao";
            this.txtFornecRazao.Size = new System.Drawing.Size(340, 34);
            this.txtFornecRazao.TabIndex = 3;
            // 
            // txtFornecNomeFantasia
            // 
            this.txtFornecNomeFantasia.Location = new System.Drawing.Point(247, 135);
            this.txtFornecNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecNomeFantasia.Name = "txtFornecNomeFantasia";
            this.txtFornecNomeFantasia.Size = new System.Drawing.Size(340, 34);
            this.txtFornecNomeFantasia.TabIndex = 9;
            // 
            // txtFornecCnpj
            // 
            this.txtFornecCnpj.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFornecCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornecCnpj.Location = new System.Drawing.Point(17, 73);
            this.txtFornecCnpj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecCnpj.Name = "txtFornecCnpj";
            this.txtFornecCnpj.Size = new System.Drawing.Size(212, 34);
            this.txtFornecCnpj.TabIndex = 1;
            // 
            // lblFornecNomeFantasia
            // 
            this.lblFornecNomeFantasia.AutoSize = true;
            this.lblFornecNomeFantasia.ForeColor = System.Drawing.Color.White;
            this.lblFornecNomeFantasia.Location = new System.Drawing.Point(248, 106);
            this.lblFornecNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecNomeFantasia.Name = "lblFornecNomeFantasia";
            this.lblFornecNomeFantasia.Size = new System.Drawing.Size(141, 28);
            this.lblFornecNomeFantasia.TabIndex = 8;
            this.lblFornecNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblFornecRazao
            // 
            this.lblFornecRazao.AutoSize = true;
            this.lblFornecRazao.ForeColor = System.Drawing.Color.White;
            this.lblFornecRazao.Location = new System.Drawing.Point(248, 44);
            this.lblFornecRazao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecRazao.Name = "lblFornecRazao";
            this.lblFornecRazao.Size = new System.Drawing.Size(122, 28);
            this.lblFornecRazao.TabIndex = 2;
            this.lblFornecRazao.Text = "Razão Social";
            // 
            // txtFornecInscricao
            // 
            this.txtFornecInscricao.Location = new System.Drawing.Point(17, 135);
            this.txtFornecInscricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecInscricao.Name = "txtFornecInscricao";
            this.txtFornecInscricao.Size = new System.Drawing.Size(212, 34);
            this.txtFornecInscricao.TabIndex = 7;
            // 
            // lblFornecInscricao
            // 
            this.lblFornecInscricao.AutoSize = true;
            this.lblFornecInscricao.ForeColor = System.Drawing.Color.White;
            this.lblFornecInscricao.Location = new System.Drawing.Point(18, 106);
            this.lblFornecInscricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecInscricao.Name = "lblFornecInscricao";
            this.lblFornecInscricao.Size = new System.Drawing.Size(166, 28);
            this.lblFornecInscricao.TabIndex = 6;
            this.lblFornecInscricao.Text = "Inscrição Estadual";
            // 
            // btnFornecAdicionar
            // 
            this.btnFornecAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecAdicionar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFornecAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnFornecAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnFornecAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecAdicionar.Location = new System.Drawing.Point(620, 267);
            this.btnFornecAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFornecAdicionar.Name = "btnFornecAdicionar";
            this.btnFornecAdicionar.Size = new System.Drawing.Size(159, 34);
            this.btnFornecAdicionar.TabIndex = 17;
            this.btnFornecAdicionar.Text = "Adicionar";
            this.btnFornecAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnFornecEditar
            // 
            this.btnFornecEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecEditar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFornecEditar.ForeColor = System.Drawing.Color.White;
            this.btnFornecEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecEditar.IconColor = System.Drawing.Color.Black;
            this.btnFornecEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecEditar.Location = new System.Drawing.Point(620, 308);
            this.btnFornecEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFornecEditar.Name = "btnFornecEditar";
            this.btnFornecEditar.Size = new System.Drawing.Size(159, 34);
            this.btnFornecEditar.TabIndex = 18;
            this.btnFornecEditar.Text = "Editar";
            this.btnFornecEditar.UseVisualStyleBackColor = false;
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
            this.dataFornec.TabIndex = 16;
            // 
            // btnFornecCancelar
            // 
            this.btnFornecCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFornecCancelar.ForeColor = System.Drawing.Color.White;
            this.btnFornecCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecCancelar.IconColor = System.Drawing.Color.Black;
            this.btnFornecCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecCancelar.Location = new System.Drawing.Point(789, 267);
            this.btnFornecCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFornecCancelar.Name = "btnFornecCancelar";
            this.btnFornecCancelar.Size = new System.Drawing.Size(159, 34);
            this.btnFornecCancelar.TabIndex = 19;
            this.btnFornecCancelar.Text = "Cancelar";
            this.btnFornecCancelar.UseVisualStyleBackColor = false;
            // 
            // groupContatoFornec
            // 
            this.groupContatoFornec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoTelefone);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoTelefone);
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoEmail);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoEmail);
            this.groupContatoFornec.Controls.Add(this.lblFornecContatoNome);
            this.groupContatoFornec.Controls.Add(this.txtFornecContatoNome);
            this.groupContatoFornec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupContatoFornec.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupContatoFornec.ForeColor = System.Drawing.Color.White;
            this.groupContatoFornec.Location = new System.Drawing.Point(620, 10);
            this.groupContatoFornec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoFornec.Name = "groupContatoFornec";
            this.groupContatoFornec.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupContatoFornec.Size = new System.Drawing.Size(329, 251);
            this.groupContatoFornec.TabIndex = 15;
            this.groupContatoFornec.TabStop = false;
            this.groupContatoFornec.Text = "Contatos";
            // 
            // lblFornecContatoTelefone
            // 
            this.lblFornecContatoTelefone.AutoSize = true;
            this.lblFornecContatoTelefone.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoTelefone.Location = new System.Drawing.Point(16, 170);
            this.lblFornecContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecContatoTelefone.Name = "lblFornecContatoTelefone";
            this.lblFornecContatoTelefone.Size = new System.Drawing.Size(164, 28);
            this.lblFornecContatoTelefone.TabIndex = 16;
            this.lblFornecContatoTelefone.Text = "Telefone Principal";
            // 
            // txtFornecContatoTelefone
            // 
            this.txtFornecContatoTelefone.Location = new System.Drawing.Point(15, 198);
            this.txtFornecContatoTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecContatoTelefone.Name = "txtFornecContatoTelefone";
            this.txtFornecContatoTelefone.Size = new System.Drawing.Size(296, 34);
            this.txtFornecContatoTelefone.TabIndex = 17;
            // 
            // lblFornecContatoEmail
            // 
            this.lblFornecContatoEmail.AutoSize = true;
            this.lblFornecContatoEmail.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoEmail.Location = new System.Drawing.Point(16, 106);
            this.lblFornecContatoEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecContatoEmail.Name = "lblFornecContatoEmail";
            this.lblFornecContatoEmail.Size = new System.Drawing.Size(67, 28);
            this.lblFornecContatoEmail.TabIndex = 14;
            this.lblFornecContatoEmail.Text = "E-mail";
            // 
            // txtFornecContatoEmail
            // 
            this.txtFornecContatoEmail.Location = new System.Drawing.Point(15, 135);
            this.txtFornecContatoEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecContatoEmail.Name = "txtFornecContatoEmail";
            this.txtFornecContatoEmail.Size = new System.Drawing.Size(296, 34);
            this.txtFornecContatoEmail.TabIndex = 15;
            // 
            // lblFornecContatoNome
            // 
            this.lblFornecContatoNome.AutoSize = true;
            this.lblFornecContatoNome.ForeColor = System.Drawing.Color.White;
            this.lblFornecContatoNome.Location = new System.Drawing.Point(16, 44);
            this.lblFornecContatoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornecContatoNome.Name = "lblFornecContatoNome";
            this.lblFornecContatoNome.Size = new System.Drawing.Size(171, 28);
            this.lblFornecContatoNome.TabIndex = 12;
            this.lblFornecContatoNome.Text = "Nome do Contato";
            // 
            // txtFornecContatoNome
            // 
            this.txtFornecContatoNome.Location = new System.Drawing.Point(15, 72);
            this.txtFornecContatoNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFornecContatoNome.Name = "txtFornecContatoNome";
            this.txtFornecContatoNome.Size = new System.Drawing.Size(296, 34);
            this.txtFornecContatoNome.TabIndex = 13;
            // 
            // btnFornecExcluir
            // 
            this.btnFornecExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnFornecExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecExcluir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFornecExcluir.ForeColor = System.Drawing.Color.White;
            this.btnFornecExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFornecExcluir.IconColor = System.Drawing.Color.Black;
            this.btnFornecExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFornecExcluir.Location = new System.Drawing.Point(789, 308);
            this.btnFornecExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFornecExcluir.Name = "btnFornecExcluir";
            this.btnFornecExcluir.Size = new System.Drawing.Size(159, 34);
            this.btnFornecExcluir.TabIndex = 20;
            this.btnFornecExcluir.Text = "Excluir";
            this.btnFornecExcluir.UseVisualStyleBackColor = false;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.groupInfoFornec);
            this.Controls.Add(this.btnFornecAdicionar);
            this.Controls.Add(this.btnFornecEditar);
            this.Controls.Add(this.dataFornec);
            this.Controls.Add(this.btnFornecCancelar);
            this.Controls.Add(this.groupContatoFornec);
            this.Controls.Add(this.btnFornecExcluir);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            this.groupInfoFornec.ResumeLayout(false);
            this.groupInfoFornec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornec)).EndInit();
            this.groupContatoFornec.ResumeLayout(false);
            this.groupContatoFornec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoFornec;
        private System.Windows.Forms.Label lblFornecObs;
        private System.Windows.Forms.RichTextBox txtFornecObs;
        private System.Windows.Forms.Label lblFornecCnpj;
        private System.Windows.Forms.TextBox txtFornecRazao;
        private System.Windows.Forms.TextBox txtFornecNomeFantasia;
        private System.Windows.Forms.TextBox txtFornecCnpj;
        private System.Windows.Forms.Label lblFornecNomeFantasia;
        private System.Windows.Forms.Label lblFornecRazao;
        private System.Windows.Forms.TextBox txtFornecInscricao;
        private System.Windows.Forms.Label lblFornecInscricao;
        private FontAwesome.Sharp.IconButton btnFornecAdicionar;
        private FontAwesome.Sharp.IconButton btnFornecEditar;
        private System.Windows.Forms.DataGridView dataFornec;
        private FontAwesome.Sharp.IconButton btnFornecCancelar;
        private System.Windows.Forms.GroupBox groupContatoFornec;
        private System.Windows.Forms.Label lblFornecContatoTelefone;
        private System.Windows.Forms.TextBox txtFornecContatoTelefone;
        private System.Windows.Forms.Label lblFornecContatoEmail;
        private System.Windows.Forms.TextBox txtFornecContatoEmail;
        private System.Windows.Forms.Label lblFornecContatoNome;
        private System.Windows.Forms.TextBox txtFornecContatoNome;
        private FontAwesome.Sharp.IconButton btnFornecExcluir;
    }
}