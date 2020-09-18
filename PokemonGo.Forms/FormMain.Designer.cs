namespace PokemonGo.Forms
{
    partial class FormMain
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
            this.btn_PokeBag = new System.Windows.Forms.Button();
            this.btn_PokeDex = new System.Windows.Forms.Button();
            this.btn_Cidade = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(233, 28);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(338, 38);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "O que você deseja fazer?";
            // 
            // btn_PokeBag
            // 
            this.btn_PokeBag.Location = new System.Drawing.Point(251, 118);
            this.btn_PokeBag.Name = "btn_PokeBag";
            this.btn_PokeBag.Size = new System.Drawing.Size(299, 34);
            this.btn_PokeBag.TabIndex = 1;
            this.btn_PokeBag.Text = "Utilizar minha PokeBag";
            this.btn_PokeBag.UseVisualStyleBackColor = true;
            this.btn_PokeBag.Click += new System.EventHandler(this.btn_PokeBag_Click);
            // 
            // btn_PokeDex
            // 
            this.btn_PokeDex.Location = new System.Drawing.Point(251, 188);
            this.btn_PokeDex.Name = "btn_PokeDex";
            this.btn_PokeDex.Size = new System.Drawing.Size(299, 34);
            this.btn_PokeDex.TabIndex = 1;
            this.btn_PokeDex.Text = "Utilizar a PokeDex";
            this.btn_PokeDex.UseVisualStyleBackColor = true;
            this.btn_PokeDex.Click += new System.EventHandler(this.btn_PokeDex_Click);
            // 
            // btn_Cidade
            // 
            this.btn_Cidade.Location = new System.Drawing.Point(251, 249);
            this.btn_Cidade.Name = "btn_Cidade";
            this.btn_Cidade.Size = new System.Drawing.Size(299, 34);
            this.btn_Cidade.TabIndex = 1;
            this.btn_Cidade.Text = "Utilizar minha lista de Cidades";
            this.btn_Cidade.UseVisualStyleBackColor = true;
            this.btn_Cidade.Click += new System.EventHandler(this.btn_Cidade_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(344, 350);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Cidade);
            this.Controls.Add(this.btn_PokeDex);
            this.Controls.Add(this.btn_PokeBag);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Button btn_PokeBag;
        private System.Windows.Forms.Button btn_PokeDex;
        private System.Windows.Forms.Button btn_Cidade;
        private System.Windows.Forms.Button btn_Sair;
    }
}