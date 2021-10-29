
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
            this.btnClienteAdicionar = new FontAwesome.Sharp.IconButton();
            this.btnClienteEditar = new FontAwesome.Sharp.IconButton();
            this.btnClienteCancelar = new FontAwesome.Sharp.IconButton();
            this.btnClienteExcluir = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClienteContatoTelefone = new System.Windows.Forms.Label();
            this.txtClienteContatoTelefone = new System.Windows.Forms.TextBox();
            this.lblClienteContatoEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblClienteContatoNome = new System.Windows.Forms.Label();
            this.txtClienteContatoNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClienteAdicionar
            // 
            this.btnClienteAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnClienteAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteAdicionar.Location = new System.Drawing.Point(602, 243);
            this.btnClienteAdicionar.Name = "btnClienteAdicionar";
            this.btnClienteAdicionar.Size = new System.Drawing.Size(170, 37);
            this.btnClienteAdicionar.TabIndex = 17;
            this.btnClienteAdicionar.Text = "Adicionar";
            this.btnClienteAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteEditar.IconColor = System.Drawing.Color.Black;
            this.btnClienteEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteEditar.Location = new System.Drawing.Point(602, 286);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(170, 37);
            this.btnClienteEditar.TabIndex = 18;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = true;
            // 
            // btnClienteCancelar
            // 
            this.btnClienteCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteCancelar.IconColor = System.Drawing.Color.Black;
            this.btnClienteCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteCancelar.Location = new System.Drawing.Point(778, 243);
            this.btnClienteCancelar.Name = "btnClienteCancelar";
            this.btnClienteCancelar.Size = new System.Drawing.Size(172, 37);
            this.btnClienteCancelar.TabIndex = 19;
            this.btnClienteCancelar.Text = "Cancelar";
            this.btnClienteCancelar.UseVisualStyleBackColor = true;
            // 
            // btnClienteExcluir
            // 
            this.btnClienteExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClienteExcluir.IconColor = System.Drawing.Color.Black;
            this.btnClienteExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClienteExcluir.Location = new System.Drawing.Point(778, 286);
            this.btnClienteExcluir.Name = "btnClienteExcluir";
            this.btnClienteExcluir.Size = new System.Drawing.Size(172, 37);
            this.btnClienteExcluir.TabIndex = 20;
            this.btnClienteExcluir.Text = "Excluir";
            this.btnClienteExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(940, 199);
            this.dataGridView1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClienteContatoTelefone);
            this.groupBox2.Controls.Add(this.txtClienteContatoTelefone);
            this.groupBox2.Controls.Add(this.lblClienteContatoEmail);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lblClienteContatoNome);
            this.groupBox2.Controls.Add(this.txtClienteContatoNome);
            this.groupBox2.Location = new System.Drawing.Point(602, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 225);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contatos";
            // 
            // lblClienteContatoTelefone
            // 
            this.lblClienteContatoTelefone.AutoSize = true;
            this.lblClienteContatoTelefone.Location = new System.Drawing.Point(52, 150);
            this.lblClienteContatoTelefone.Name = "lblClienteContatoTelefone";
            this.lblClienteContatoTelefone.Size = new System.Drawing.Size(99, 15);
            this.lblClienteContatoTelefone.TabIndex = 16;
            this.lblClienteContatoTelefone.Text = "telefone principal";
            // 
            // txtClienteContatoTelefone
            // 
            this.txtClienteContatoTelefone.Location = new System.Drawing.Point(52, 168);
            this.txtClienteContatoTelefone.Name = "txtClienteContatoTelefone";
            this.txtClienteContatoTelefone.Size = new System.Drawing.Size(255, 23);
            this.txtClienteContatoTelefone.TabIndex = 17;
            // 
            // lblClienteContatoEmail
            // 
            this.lblClienteContatoEmail.AutoSize = true;
            this.lblClienteContatoEmail.Location = new System.Drawing.Point(52, 92);
            this.lblClienteContatoEmail.Name = "lblClienteContatoEmail";
            this.lblClienteContatoEmail.Size = new System.Drawing.Size(36, 15);
            this.lblClienteContatoEmail.TabIndex = 14;
            this.lblClienteContatoEmail.Text = "email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 23);
            this.textBox2.TabIndex = 15;
            // 
            // lblClienteContatoNome
            // 
            this.lblClienteContatoNome.AutoSize = true;
            this.lblClienteContatoNome.Location = new System.Drawing.Point(52, 26);
            this.lblClienteContatoNome.Name = "lblClienteContatoNome";
            this.lblClienteContatoNome.Size = new System.Drawing.Size(99, 15);
            this.lblClienteContatoNome.TabIndex = 12;
            this.lblClienteContatoNome.Text = "nome do contato";
            // 
            // txtClienteContatoNome
            // 
            this.txtClienteContatoNome.Location = new System.Drawing.Point(52, 44);
            this.txtClienteContatoNome.Name = "txtClienteContatoNome";
            this.txtClienteContatoNome.Size = new System.Drawing.Size(255, 23);
            this.txtClienteContatoNome.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClienteObs);
            this.groupBox1.Controls.Add(this.txtClienteObs);
            this.groupBox1.Controls.Add(this.lblClienteCnpj);
            this.groupBox1.Controls.Add(this.txtClienteRazao);
            this.groupBox1.Controls.Add(this.txtClienteNomeFantasia);
            this.groupBox1.Controls.Add(this.txtClienteCnpj);
            this.groupBox1.Controls.Add(this.lblClienteNomeFantasia);
            this.groupBox1.Controls.Add(this.lblClienteRazao);
            this.groupBox1.Controls.Add(this.txtClienteInscricao);
            this.groupBox1.Controls.Add(this.lblClienteInscricao);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 311);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações empresariais";
            // 
            // lblClienteObs
            // 
            this.lblClienteObs.AutoSize = true;
            this.lblClienteObs.Location = new System.Drawing.Point(29, 150);
            this.lblClienteObs.Name = "lblClienteObs";
            this.lblClienteObs.Size = new System.Drawing.Size(77, 15);
            this.lblClienteObs.TabIndex = 11;
            this.lblClienteObs.Text = "Observações:";
            // 
            // txtClienteObs
            // 
            this.txtClienteObs.Location = new System.Drawing.Point(29, 168);
            this.txtClienteObs.Name = "txtClienteObs";
            this.txtClienteObs.Size = new System.Drawing.Size(530, 116);
            this.txtClienteObs.TabIndex = 10;
            this.txtClienteObs.Text = "";
            // 
            // lblClienteCnpj
            // 
            this.lblClienteCnpj.AutoSize = true;
            this.lblClienteCnpj.Location = new System.Drawing.Point(29, 26);
            this.lblClienteCnpj.Name = "lblClienteCnpj";
            this.lblClienteCnpj.Size = new System.Drawing.Size(30, 15);
            this.lblClienteCnpj.TabIndex = 0;
            this.lblClienteCnpj.Text = "cnpj";
            // 
            // txtClienteRazao
            // 
            this.txtClienteRazao.Location = new System.Drawing.Point(251, 44);
            this.txtClienteRazao.Name = "txtClienteRazao";
            this.txtClienteRazao.Size = new System.Drawing.Size(308, 23);
            this.txtClienteRazao.TabIndex = 3;
            // 
            // txtClienteNomeFantasia
            // 
            this.txtClienteNomeFantasia.Location = new System.Drawing.Point(251, 110);
            this.txtClienteNomeFantasia.Name = "txtClienteNomeFantasia";
            this.txtClienteNomeFantasia.Size = new System.Drawing.Size(308, 23);
            this.txtClienteNomeFantasia.TabIndex = 9;
            // 
            // txtClienteCnpj
            // 
            this.txtClienteCnpj.Location = new System.Drawing.Point(29, 44);
            this.txtClienteCnpj.Name = "txtClienteCnpj";
            this.txtClienteCnpj.Size = new System.Drawing.Size(201, 23);
            this.txtClienteCnpj.TabIndex = 1;
            // 
            // lblClienteNomeFantasia
            // 
            this.lblClienteNomeFantasia.AutoSize = true;
            this.lblClienteNomeFantasia.Location = new System.Drawing.Point(251, 92);
            this.lblClienteNomeFantasia.Name = "lblClienteNomeFantasia";
            this.lblClienteNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.lblClienteNomeFantasia.TabIndex = 8;
            this.lblClienteNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblClienteRazao
            // 
            this.lblClienteRazao.AutoSize = true;
            this.lblClienteRazao.Location = new System.Drawing.Point(251, 26);
            this.lblClienteRazao.Name = "lblClienteRazao";
            this.lblClienteRazao.Size = new System.Drawing.Size(72, 15);
            this.lblClienteRazao.TabIndex = 2;
            this.lblClienteRazao.Text = "Razão Social";
            // 
            // txtClienteInscricao
            // 
            this.txtClienteInscricao.Location = new System.Drawing.Point(29, 110);
            this.txtClienteInscricao.Name = "txtClienteInscricao";
            this.txtClienteInscricao.Size = new System.Drawing.Size(201, 23);
            this.txtClienteInscricao.TabIndex = 7;
            // 
            // lblClienteInscricao
            // 
            this.lblClienteInscricao.AutoSize = true;
            this.lblClienteInscricao.Location = new System.Drawing.Point(29, 92);
            this.lblClienteInscricao.Name = "lblClienteInscricao";
            this.lblClienteInscricao.Size = new System.Drawing.Size(101, 15);
            this.lblClienteInscricao.TabIndex = 6;
            this.lblClienteInscricao.Text = "inscrição estadual";
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.btnClienteAdicionar);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.btnClienteCancelar);
            this.Controls.Add(this.btnClienteExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClienteAdicionar;
        private FontAwesome.Sharp.IconButton btnClienteEditar;
        private FontAwesome.Sharp.IconButton btnClienteCancelar;
        private FontAwesome.Sharp.IconButton btnClienteExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblClienteContatoTelefone;
        private System.Windows.Forms.TextBox txtClienteContatoTelefone;
        private System.Windows.Forms.Label lblClienteContatoEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblClienteContatoNome;
        private System.Windows.Forms.TextBox txtClienteContatoNome;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}