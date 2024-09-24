namespace _231282.Views
{
    partial class FrmCidades
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexcluirbtnexcluirbtnexcluir = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnexcluirp = new System.Windows.Forms.Button();
            this.dgvcidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(132, 66);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(129, 28);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(39, 13);
            this.codigo.TabIndex = 1;
            this.codigo.Text = "codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cidades";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(132, 146);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 3;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(132, 197);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(266, 197);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 5;
            this.btnalterar.Text = "alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(394, 197);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnexcluirbtnexcluirbtnexcluir
            // 
            this.btnexcluirbtnexcluirbtnexcluir.Location = new System.Drawing.Point(495, 197);
            this.btnexcluirbtnexcluirbtnexcluir.Name = "btnexcluirbtnexcluirbtnexcluir";
            this.btnexcluirbtnexcluirbtnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirbtnexcluirbtnexcluir.TabIndex = 7;
            this.btnexcluirbtnexcluirbtnexcluir.Text = "excluir";
            this.btnexcluirbtnexcluirbtnexcluir.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(606, 197);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 8;
            this.btnfechar.Text = "fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // pesquisa
            // 
            this.pesquisa.AutoSize = true;
            this.pesquisa.Location = new System.Drawing.Point(129, 267);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(191, 13);
            this.pesquisa.TabIndex = 9;
            this.pesquisa.Text = "Digite o nome da cidade para pesquisa";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(132, 294);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(438, 20);
            this.txtpesquisa.TabIndex = 10;
            // 
            // btnexcluirp
            // 
            this.btnexcluirp.Location = new System.Drawing.Point(616, 294);
            this.btnexcluirp.Name = "btnexcluirp";
            this.btnexcluirp.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirp.TabIndex = 11;
            this.btnexcluirp.Text = "excluir";
            this.btnexcluirp.UseVisualStyleBackColor = true;
            // 
            // dgvcidade
            // 
            this.dgvcidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcidade.Location = new System.Drawing.Point(132, 330);
            this.dgvcidade.Name = "dgvcidade";
            this.dgvcidade.Size = new System.Drawing.Size(438, 108);
            this.dgvcidade.TabIndex = 12;
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvcidade);
            this.Controls.Add(this.btnexcluirp);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnexcluirbtnexcluirbtnexcluir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.txtid);
            this.Name = "FrmCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro de cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexcluirbtnexcluirbtnexcluir;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label pesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnexcluirp;
        private System.Windows.Forms.DataGridView dgvcidade;
    }
}