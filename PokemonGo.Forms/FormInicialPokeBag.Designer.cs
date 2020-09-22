namespace PokemonGo.Forms
{
    partial class FormInicialPokeBag
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
            this.bnt_Inserir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Exibir = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Sugestao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(90, 38);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(616, 38);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "O que você gostaria de fazer na sua PokeBag?";
            // 
            // bnt_Inserir
            // 
            this.bnt_Inserir.Location = new System.Drawing.Point(250, 104);
            this.bnt_Inserir.Name = "bnt_Inserir";
            this.bnt_Inserir.Size = new System.Drawing.Size(293, 56);
            this.bnt_Inserir.TabIndex = 1;
            this.bnt_Inserir.Text = "Inserir um pokémon capturado";
            this.bnt_Inserir.UseVisualStyleBackColor = true;
            this.bnt_Inserir.Click += new System.EventHandler(this.bnt_Inserir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(250, 290);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(293, 56);
            this.btn_Excluir.TabIndex = 1;
            this.btn_Excluir.Text = "Excluir um pokémon transferido";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(250, 228);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(293, 56);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar os stats de um pokémon";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Exibir
            // 
            this.btn_Exibir.Location = new System.Drawing.Point(250, 166);
            this.btn_Exibir.Name = "btn_Exibir";
            this.btn_Exibir.Size = new System.Drawing.Size(293, 56);
            this.btn_Exibir.TabIndex = 1;
            this.btn_Exibir.Text = "Consultar pokémons capturados";
            this.btn_Exibir.UseVisualStyleBackColor = true;
            this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(12, 450);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(109, 41);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(138, 450);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(109, 40);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Sugestao
            // 
            this.btn_Sugestao.Location = new System.Drawing.Point(250, 352);
            this.btn_Sugestao.Name = "btn_Sugestao";
            this.btn_Sugestao.Size = new System.Drawing.Size(293, 56);
            this.btn_Sugestao.TabIndex = 2;
            this.btn_Sugestao.Text = "Sugestões de troca e transferência";
            this.btn_Sugestao.UseVisualStyleBackColor = true;
            this.btn_Sugestao.Click += new System.EventHandler(this.btn_Sugestao_Click);
            // 
            // FormInicialPokeBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btn_Sugestao);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Exibir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.bnt_Inserir);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormInicialPokeBag";
            this.Text = "FormInicialPokeBag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Button bnt_Inserir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Exibir;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Sugestao;
    }
}