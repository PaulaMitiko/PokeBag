namespace PokemonGo.Forms
{
    partial class FormAlterarPokeDex
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_CP = new System.Windows.Forms.Label();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_Lvl35 = new System.Windows.Forms.Label();
            this.txt_Lvl35 = new System.Windows.Forms.TextBox();
            this.lbl_Consulta = new System.Windows.Forms.Label();
            this.lbl_Egg = new System.Windows.Forms.Label();
            this.box_Egg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(457, 95);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(182, 31);
            this.txt_Id.TabIndex = 0;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(181, 95);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(227, 25);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Informe o No do Pokémon";
            // 
            // lbl_CP
            // 
            this.lbl_CP.AutoSize = true;
            this.lbl_CP.Location = new System.Drawing.Point(181, 137);
            this.lbl_CP.Name = "lbl_CP";
            this.lbl_CP.Size = new System.Drawing.Size(232, 25);
            this.lbl_CP.TabIndex = 1;
            this.lbl_CP.Text = "Informe o novo CP Máximo";
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(139, 24);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(514, 38);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Alterar o CP Máximo de um Pokémon";
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(457, 137);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(182, 31);
            this.txt_CP.TabIndex = 0;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(287, 282);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(190, 34);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar alteração";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(676, 404);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(676, 364);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_Lvl35
            // 
            this.lbl_Lvl35.AutoSize = true;
            this.lbl_Lvl35.Location = new System.Drawing.Point(181, 183);
            this.lbl_Lvl35.Name = "lbl_Lvl35";
            this.lbl_Lvl35.Size = new System.Drawing.Size(258, 25);
            this.lbl_Lvl35.TabIndex = 1;
            this.lbl_Lvl35.Text = "Informe o novo CP no Level 35";
            // 
            // txt_Lvl35
            // 
            this.txt_Lvl35.Location = new System.Drawing.Point(457, 177);
            this.txt_Lvl35.Name = "txt_Lvl35";
            this.txt_Lvl35.Size = new System.Drawing.Size(182, 31);
            this.txt_Lvl35.TabIndex = 0;
            // 
            // lbl_Consulta
            // 
            this.lbl_Consulta.AutoSize = true;
            this.lbl_Consulta.Location = new System.Drawing.Point(13, 403);
            this.lbl_Consulta.Name = "lbl_Consulta";
            this.lbl_Consulta.Size = new System.Drawing.Size(485, 25);
            this.lbl_Consulta.TabIndex = 3;
            this.lbl_Consulta.Text = "Não sei o número do pokémon. Cliquei aqui para consultar.";
            this.lbl_Consulta.Click += new System.EventHandler(this.lbl_Consulta_Click);
            // 
            // lbl_Egg
            // 
            this.lbl_Egg.AutoSize = true;
            this.lbl_Egg.Location = new System.Drawing.Point(181, 227);
            this.lbl_Egg.Name = "lbl_Egg";
            this.lbl_Egg.Size = new System.Drawing.Size(235, 25);
            this.lbl_Egg.TabIndex = 1;
            this.lbl_Egg.Text = "Informe o novo tipo de egg";
            // 
            // box_Egg
            // 
            this.box_Egg.FormattingEnabled = true;
            this.box_Egg.Items.AddRange(new object[] {
            "2 km",
            "5 km",
            "7 km",
            "10 km",
            "Não possui egg"});
            this.box_Egg.Location = new System.Drawing.Point(457, 227);
            this.box_Egg.Name = "box_Egg";
            this.box_Egg.Size = new System.Drawing.Size(182, 33);
            this.box_Egg.TabIndex = 4;
            // 
            // FormAlterarPokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_Egg);
            this.Controls.Add(this.lbl_Egg);
            this.Controls.Add(this.lbl_Consulta);
            this.Controls.Add(this.txt_Lvl35);
            this.Controls.Add(this.lbl_Lvl35);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Id);
            this.Name = "FormAlterarPokeDex";
            this.Text = "FormAlterarPokeDex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_Lvl35;
        private System.Windows.Forms.TextBox txt_Lvl35;
        private System.Windows.Forms.Label lbl_Consulta;
        private System.Windows.Forms.Label lbl_Egg;
        private System.Windows.Forms.ComboBox box_Egg;
    }
}