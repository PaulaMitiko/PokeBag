namespace PokemonGo.Forms
{
    partial class FormExibirPokeDex
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.btn_Id = new System.Windows.Forms.Button();
            this.btn_Tipo = new System.Windows.Forms.Button();
            this.box_Tipo = new System.Windows.Forms.ComboBox();
            this.btn_Todos = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.box_Id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(983, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o Tipo desejado";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(12, 380);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(306, 25);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Informe o No do pokémon desejado";
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(325, 9);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(398, 38);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Exibir Pokémons da PokeDex";
            // 
            // btn_Id
            // 
            this.btn_Id.Location = new System.Drawing.Point(522, 380);
            this.btn_Id.Name = "btn_Id";
            this.btn_Id.Size = new System.Drawing.Size(190, 34);
            this.btn_Id.TabIndex = 2;
            this.btn_Id.Text = "Consultar por Id";
            this.btn_Id.UseVisualStyleBackColor = true;
            this.btn_Id.Click += new System.EventHandler(this.btn_Id_Click);
            // 
            // btn_Tipo
            // 
            this.btn_Tipo.Location = new System.Drawing.Point(522, 418);
            this.btn_Tipo.Name = "btn_Tipo";
            this.btn_Tipo.Size = new System.Drawing.Size(190, 34);
            this.btn_Tipo.TabIndex = 2;
            this.btn_Tipo.Text = "Consultar por Tipo";
            this.btn_Tipo.UseVisualStyleBackColor = true;
            this.btn_Tipo.Click += new System.EventHandler(this.btn_Tipo_Click);
            // 
            // box_Tipo
            // 
            this.box_Tipo.FormattingEnabled = true;
            this.box_Tipo.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fight",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.box_Tipo.Location = new System.Drawing.Point(325, 418);
            this.box_Tipo.Name = "box_Tipo";
            this.box_Tipo.Size = new System.Drawing.Size(182, 33);
            this.box_Tipo.TabIndex = 4;
            // 
            // btn_Todos
            // 
            this.btn_Todos.Location = new System.Drawing.Point(522, 340);
            this.btn_Todos.Name = "btn_Todos";
            this.btn_Todos.Size = new System.Drawing.Size(190, 34);
            this.btn_Todos.TabIndex = 2;
            this.btn_Todos.Text = "Consultar Todos";
            this.btn_Todos.UseVisualStyleBackColor = true;
            this.btn_Todos.Click += new System.EventHandler(this.btn_Todos_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(882, 416);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(882, 380);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 5;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // box_Id
            // 
            this.box_Id.FormattingEnabled = true;
            this.box_Id.Location = new System.Drawing.Point(325, 377);
            this.box_Id.Name = "box_Id";
            this.box_Id.Size = new System.Drawing.Size(182, 33);
            this.box_Id.TabIndex = 6;
            // 
            // FormExibirPokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 471);
            this.Controls.Add(this.box_Id);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Todos);
            this.Controls.Add(this.box_Tipo);
            this.Controls.Add(this.btn_Tipo);
            this.Controls.Add(this.btn_Id);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormExibirPokeDex";
            this.Text = "FormExibirPokeDex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Button btn_Id;
        private System.Windows.Forms.Button btn_Tipo;
        private System.Windows.Forms.ComboBox box_Tipo;
        private System.Windows.Forms.Button btn_Todos;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.ComboBox box_Id;
    }
}