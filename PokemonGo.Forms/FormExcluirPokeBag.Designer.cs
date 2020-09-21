namespace PokemonGo.Forms
{
    partial class FormExcluirPokeBag
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdPokemon = new System.Windows.Forms.TextBox();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Consultar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(167, 29);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(443, 38);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "Excluir um Pokémon Transferido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o ID do pokémon que será excluido";
            // 
            // txt_IdPokemon
            // 
            this.txt_IdPokemon.Location = new System.Drawing.Point(300, 156);
            this.txt_IdPokemon.Name = "txt_IdPokemon";
            this.txt_IdPokemon.Size = new System.Drawing.Size(150, 31);
            this.txt_IdPokemon.TabIndex = 2;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(320, 203);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(112, 34);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(676, 277);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(558, 277);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Consultar
            // 
            this.lbl_Consultar.AutoSize = true;
            this.lbl_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Consultar.Location = new System.Drawing.Point(12, 289);
            this.lbl_Consultar.Name = "lbl_Consultar";
            this.lbl_Consultar.Size = new System.Drawing.Size(433, 25);
            this.lbl_Consultar.TabIndex = 5;
            this.lbl_Consultar.Text = "Não sei o Id do Pokémon. Clique aqui para consultar.";
            this.lbl_Consultar.Click += new System.EventHandler(this.lbl_Consultar_Click);
            // 
            // FormExcluirPokeBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.lbl_Consultar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.txt_IdPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormExcluirPokeBag";
            this.Text = "FormExcluirPokeBag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdPokemon;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Consultar;
    }
}