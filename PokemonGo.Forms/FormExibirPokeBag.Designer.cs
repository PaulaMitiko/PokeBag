namespace PokemonGo.Forms
{
    partial class FormExibirPokeBag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Especie = new System.Windows.Forms.TextBox();
            this.btn_ExibirTipo = new System.Windows.Forms.Button();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.btn_ExibirTodos = new System.Windows.Forms.Button();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.txt_Especie);
            this.panel1.Controls.Add(this.btn_ExibirTipo);
            this.panel1.Location = new System.Drawing.Point(3, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 50);
            this.panel1.TabIndex = 7;
            // 
            // txt_Especie
            // 
            this.txt_Especie.Location = new System.Drawing.Point(220, 13);
            this.txt_Especie.Name = "txt_Especie";
            this.txt_Especie.Size = new System.Drawing.Size(150, 31);
            this.txt_Especie.TabIndex = 3;
            // 
            // btn_ExibirTipo
            // 
            this.btn_ExibirTipo.Location = new System.Drawing.Point(407, 13);
            this.btn_ExibirTipo.Name = "btn_ExibirTipo";
            this.btn_ExibirTipo.Size = new System.Drawing.Size(176, 34);
            this.btn_ExibirTipo.TabIndex = 0;
            this.btn_ExibirTipo.Text = "Exibir Um Tipo";
            this.btn_ExibirTipo.UseVisualStyleBackColor = true;
            this.btn_ExibirTipo.Click += new System.EventHandler(this.btn_ExibirTipo_Click);
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(229, 11);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(333, 38);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Exibir Pokémons da Bag";
            // 
            // btn_ExibirTodos
            // 
            this.btn_ExibirTodos.Location = new System.Drawing.Point(410, 374);
            this.btn_ExibirTodos.Name = "btn_ExibirTodos";
            this.btn_ExibirTodos.Size = new System.Drawing.Size(176, 34);
            this.btn_ExibirTodos.TabIndex = 0;
            this.btn_ExibirTodos.Text = "Exibir Todos";
            this.btn_ExibirTodos.UseVisualStyleBackColor = true;
            this.btn_ExibirTodos.Click += new System.EventHandler(this.btn_ExibirTodos_Click);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(12, 416);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(205, 25);
            this.lbl_Tipo.TabIndex = 2;
            this.lbl_Tipo.Text = "Informe o tipo desejado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(785, 303);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(592, 374);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(176, 34);
            this.btn_Voltar.TabIndex = 0;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(592, 414);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(176, 34);
            this.btn_Sair.TabIndex = 0;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // FormExibirPokeBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.btn_ExibirTodos);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.panel1);
            this.Name = "FormExibirPokeBag";
            this.Text = "FormExibir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.TextBox txt_Especie;
        private System.Windows.Forms.Button btn_ExibirTodos;
        private System.Windows.Forms.Button btn_ExibirTipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
    }
}