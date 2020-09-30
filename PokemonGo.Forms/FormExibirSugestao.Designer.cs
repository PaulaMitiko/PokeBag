namespace PokemonGo.Forms
{
    partial class FormExibirSugestao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Transf = new System.Windows.Forms.Button();
            this.btn_Troca = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(775, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // btn_Transf
            // 
            this.btn_Transf.Location = new System.Drawing.Point(256, 404);
            this.btn_Transf.Name = "btn_Transf";
            this.btn_Transf.Size = new System.Drawing.Size(262, 34);
            this.btn_Transf.TabIndex = 2;
            this.btn_Transf.Text = "Sugestões de Transferência";
            this.btn_Transf.UseVisualStyleBackColor = true;
            this.btn_Transf.Click += new System.EventHandler(this.btn_Transf_Click);
            // 
            // btn_Troca
            // 
            this.btn_Troca.Location = new System.Drawing.Point(256, 364);
            this.btn_Troca.Name = "btn_Troca";
            this.btn_Troca.Size = new System.Drawing.Size(262, 34);
            this.btn_Troca.TabIndex = 1;
            this.btn_Troca.Text = "Sugestões de Troca";
            this.btn_Troca.UseVisualStyleBackColor = true;
            this.btn_Troca.Click += new System.EventHandler(this.btn_Troca_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(13, 404);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(13, 364);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(598, 404);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(190, 34);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir um pokémon";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // FormExibirSugestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Troca);
            this.Controls.Add(this.btn_Transf);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormExibirSugestao";
            this.Text = "FormExibirSugestao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Transf;
        private System.Windows.Forms.Button btn_Troca;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Excluir;
    }
}