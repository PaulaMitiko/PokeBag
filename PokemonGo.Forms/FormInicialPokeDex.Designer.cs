namespace PokemonGo.Forms
{
    partial class FormInicialPokeDex
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
            this.lbl_Título = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Exibir = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(103, 36);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(617, 38);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "O que você gostaria de fazer na sua PokeDex?";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(211, 102);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(379, 34);
            this.btn_Inserir.TabIndex = 1;
            this.btn_Inserir.Text = "Cadastrar uma nova espécie de Pokémon";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(211, 158);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(379, 34);
            this.btn_Alterar.TabIndex = 2;
            this.btn_Alterar.Text = "Alterardados de um Pokémon";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Exibir
            // 
            this.btn_Exibir.Location = new System.Drawing.Point(211, 214);
            this.btn_Exibir.Name = "btn_Exibir";
            this.btn_Exibir.Size = new System.Drawing.Size(379, 34);
            this.btn_Exibir.TabIndex = 3;
            this.btn_Exibir.Text = "Consultar Pokémons da PokeDex";
            this.btn_Exibir.UseVisualStyleBackColor = true;
            this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(211, 328);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(379, 34);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(211, 378);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(379, 34);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // FormInicialPokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Exibir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormInicialPokeDex";
            this.Text = "FormInicialPokeDex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Exibir;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
    }
}