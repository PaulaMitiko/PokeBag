namespace PokemonGo.Forms
{
    partial class FormAlterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NoPokemon = new System.Windows.Forms.Label();
            this.lbl_NewCP = new System.Windows.Forms.Label();
            this.lbl_NewHP = new System.Windows.Forms.Label();
            this.txt_NoPokemon = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.txt_HP = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exibir Pokémons da Bag";
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
            this.txt_CP.TabIndex = 3;
            // 
            // txt_HP
            // 
            this.txt_HP.Location = new System.Drawing.Point(337, 184);
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(276, 31);
            this.txt_HP.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(275, 334);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 34);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Salvar Alterações";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FormAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_HP);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.txt_NoPokemon);
            this.Controls.Add(this.lbl_NewHP);
            this.Controls.Add(this.lbl_NewCP);
            this.Controls.Add(this.lbl_NoPokemon);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterar";
            this.Text = "FormAlterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NoPokemon;
        private System.Windows.Forms.Label lbl_NewCP;
        private System.Windows.Forms.Label lbl_NewHP;
        private System.Windows.Forms.TextBox txt_NoPokemon;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_HP;
        private System.Windows.Forms.Button btn_Save;
    }
}