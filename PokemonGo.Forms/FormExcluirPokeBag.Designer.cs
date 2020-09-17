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
            this.btn_Excluir.Location = new System.Drawing.Point(320, 243);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(112, 34);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // FormExcluirPokeBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
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
    }
}