﻿namespace PokemonGo.Forms
{
    partial class FormAlterarPokeBag
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
            this.lbl_NoPokemon = new System.Windows.Forms.Label();
            this.lbl_NewCP = new System.Windows.Forms.Label();
            this.lbl_NewHP = new System.Windows.Forms.Label();
            this.txt_NoPokemon = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.txt_HP = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Consultar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(222, 9);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(403, 38);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Alterar Stats de um Pokémon";
            // 
            // lbl_NoPokemon
            // 
            this.lbl_NoPokemon.AutoSize = true;
            this.lbl_NoPokemon.Location = new System.Drawing.Point(108, 94);
            this.lbl_NoPokemon.Name = "lbl_NoPokemon";
            this.lbl_NoPokemon.Size = new System.Drawing.Size(223, 25);
            this.lbl_NoPokemon.TabIndex = 2;
            this.lbl_NoPokemon.Text = "Informe o ID do pokémon";
            // 
            // lbl_NewCP
            // 
            this.lbl_NewCP.AutoSize = true;
            this.lbl_NewCP.Location = new System.Drawing.Point(108, 140);
            this.lbl_NewCP.Name = "lbl_NewCP";
            this.lbl_NewCP.Size = new System.Drawing.Size(163, 25);
            this.lbl_NewCP.TabIndex = 2;
            this.lbl_NewCP.Text = "Informe o novo CP";
            // 
            // lbl_NewHP
            // 
            this.lbl_NewHP.AutoSize = true;
            this.lbl_NewHP.Location = new System.Drawing.Point(108, 190);
            this.lbl_NewHP.Name = "lbl_NewHP";
            this.lbl_NewHP.Size = new System.Drawing.Size(165, 25);
            this.lbl_NewHP.TabIndex = 2;
            this.lbl_NewHP.Text = "Informe o novo HP";
            // 
            // txt_NoPokemon
            // 
            this.txt_NoPokemon.Location = new System.Drawing.Point(337, 97);
            this.txt_NoPokemon.Name = "txt_NoPokemon";
            this.txt_NoPokemon.Size = new System.Drawing.Size(276, 31);
            this.txt_NoPokemon.TabIndex = 3;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(337, 140);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(276, 31);
            this.txt_CP.TabIndex = 4;
            // 
            // txt_HP
            // 
            this.txt_HP.Location = new System.Drawing.Point(337, 184);
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(276, 31);
            this.txt_HP.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(279, 257);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 34);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Salvar Alterações";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(609, 358);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(179, 34);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(609, 404);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(179, 34);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Consultar
            // 
            this.lbl_Consultar.AutoSize = true;
            this.lbl_Consultar.Location = new System.Drawing.Point(12, 416);
            this.lbl_Consultar.Name = "lbl_Consultar";
            this.lbl_Consultar.Size = new System.Drawing.Size(435, 25);
            this.lbl_Consultar.TabIndex = 2;
            this.lbl_Consultar.Text = "Não sei o Id do pokémon. Clique aqui para consultar.";
            this.lbl_Consultar.Click += new System.EventHandler(this.lbl_Consultar_Click);
            // 
            // FormAlterarPokeBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Consultar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_HP);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.txt_NoPokemon);
            this.Controls.Add(this.lbl_NewHP);
            this.Controls.Add(this.lbl_NewCP);
            this.Controls.Add(this.lbl_NoPokemon);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormAlterarPokeBag";
            this.Text = "FormAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_NoPokemon;
        private System.Windows.Forms.Label lbl_NewCP;
        private System.Windows.Forms.Label lbl_NewHP;
        private System.Windows.Forms.TextBox txt_NoPokemon;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_HP;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Consultar;
    }
}