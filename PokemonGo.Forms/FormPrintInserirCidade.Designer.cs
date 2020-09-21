namespace PokemonGo.Forms
{
    partial class FormPrintInserirCidade
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
            this.pnl_Inserir = new System.Windows.Forms.Panel();
            this.txt_Pais = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.pnl_Excluir = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.pnl_Inserir.SuspendLayout();
            this.pnl_Excluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Inserir
            // 
            this.pnl_Inserir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Inserir.Controls.Add(this.txt_Pais);
            this.pnl_Inserir.Controls.Add(this.btn_Inserir);
            this.pnl_Inserir.Controls.Add(this.txt_Cidade);
            this.pnl_Inserir.Controls.Add(this.lbl_Cidade);
            this.pnl_Inserir.Controls.Add(this.lbl_Pais);
            this.pnl_Inserir.Location = new System.Drawing.Point(12, 12);
            this.pnl_Inserir.Name = "pnl_Inserir";
            this.pnl_Inserir.Size = new System.Drawing.Size(343, 120);
            this.pnl_Inserir.TabIndex = 0;
            // 
            // txt_Pais
            // 
            this.txt_Pais.Location = new System.Drawing.Point(84, 42);
            this.txt_Pais.Name = "txt_Pais";
            this.txt_Pais.Size = new System.Drawing.Size(202, 31);
            this.txt_Pais.TabIndex = 3;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Inserir.Location = new System.Drawing.Point(84, 79);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(112, 34);
            this.btn_Inserir.TabIndex = 4;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(84, 8);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(202, 31);
            this.txt_Cidade.TabIndex = 2;
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(11, 11);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(67, 25);
            this.lbl_Cidade.TabIndex = 1;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(11, 45);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(42, 25);
            this.lbl_Pais.TabIndex = 1;
            this.lbl_Pais.Text = "País";
            // 
            // pnl_Excluir
            // 
            this.pnl_Excluir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Excluir.Controls.Add(this.btn_Excluir);
            this.pnl_Excluir.Controls.Add(this.txt_Id);
            this.pnl_Excluir.Controls.Add(this.lbl_Id);
            this.pnl_Excluir.Location = new System.Drawing.Point(361, 12);
            this.pnl_Excluir.Name = "pnl_Excluir";
            this.pnl_Excluir.Size = new System.Drawing.Size(335, 120);
            this.pnl_Excluir.TabIndex = 0;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(105, 79);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(112, 34);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(105, 12);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(202, 31);
            this.txt_Id.TabIndex = 5;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(11, 12);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(88, 25);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id Cidade";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(584, 404);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(466, 404);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 138);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.Size = new System.Drawing.Size(684, 260);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.Text = "dataGridView1";
            // 
            // FormPrintInserirCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.pnl_Excluir);
            this.Controls.Add(this.pnl_Inserir);
            this.Name = "FormPrintInserirCidade";
            this.Text = "FormPrintAlterarCidade";
            this.pnl_Inserir.ResumeLayout(false);
            this.pnl_Inserir.PerformLayout();
            this.pnl_Excluir.ResumeLayout(false);
            this.pnl_Excluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Inserir;
        private System.Windows.Forms.TextBox txt_Pais;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Pais;
        private System.Windows.Forms.Panel pnl_Excluir;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}