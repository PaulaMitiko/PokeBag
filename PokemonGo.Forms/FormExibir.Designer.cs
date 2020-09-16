namespace PokemonGo.Forms
{
    partial class FormExibir
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
            this.lbl_Título = new System.Windows.Forms.Label();
            this.txt_Especie = new System.Windows.Forms.TextBox();
            this.btn_ExibirTodos = new System.Windows.Forms.Button();
            this.btn_ExibirTipo = new System.Windows.Forms.Button();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(217, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 50);
            this.panel1.TabIndex = 7;
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
            // txt_Especie
            // 
            this.txt_Especie.Location = new System.Drawing.Point(447, 407);
            this.txt_Especie.Name = "txt_Especie";
            this.txt_Especie.Size = new System.Drawing.Size(150, 31);
            this.txt_Especie.TabIndex = 3;
            // 
            // btn_ExibirTodos
            // 
            this.btn_ExibirTodos.Location = new System.Drawing.Point(612, 361);
            this.btn_ExibirTodos.Name = "btn_ExibirTodos";
            this.btn_ExibirTodos.Size = new System.Drawing.Size(176, 34);
            this.btn_ExibirTodos.TabIndex = 0;
            this.btn_ExibirTodos.Text = "Exibir Todos";
            this.btn_ExibirTodos.UseVisualStyleBackColor = true;
            this.btn_ExibirTodos.Click += new System.EventHandler(this.btn_ExibirTodos_Click);
            // 
            // btn_ExibirTipo
            // 
            this.btn_ExibirTipo.Location = new System.Drawing.Point(612, 401);
            this.btn_ExibirTipo.Name = "btn_ExibirTipo";
            this.btn_ExibirTipo.Size = new System.Drawing.Size(176, 34);
            this.btn_ExibirTipo.TabIndex = 0;
            this.btn_ExibirTipo.Text = "Exibir Um Tipo";
            this.btn_ExibirTipo.UseVisualStyleBackColor = true;
            this.btn_ExibirTipo.Click += new System.EventHandler(this.btn_ExibirTipo_Click);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(229, 410);
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
            // FormExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.btn_ExibirTipo);
            this.Controls.Add(this.btn_ExibirTodos);
            this.Controls.Add(this.txt_Especie);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.panel1);
            this.Name = "FormExibir";
            this.Text = "FormExibir";
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
    }
}