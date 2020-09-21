namespace PokemonGo.Forms
{
    partial class FormInserirPokeDex
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Tipo1 = new System.Windows.Forms.Label();
            this.lbl_Tipo2 = new System.Windows.Forms.Label();
            this.lbl_Evolution = new System.Windows.Forms.Label();
            this.lbl_Buddy = new System.Windows.Forms.Label();
            this.lbl_Egg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_CPMax = new System.Windows.Forms.TextBox();
            this.box_Tipo1 = new System.Windows.Forms.ComboBox();
            this.box_Tipo2 = new System.Windows.Forms.ComboBox();
            this.box_Evol = new System.Windows.Forms.ComboBox();
            this.box_Buddy = new System.Windows.Forms.ComboBox();
            this.box_Egg = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.txt_Lvl35 = new System.Windows.Forms.TextBox();
            this.lbl_Lvl35 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Título.Location = new System.Drawing.Point(180, 9);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(447, 38);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Inserir nova espécie de Pokemon";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(21, 71);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(116, 25);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "No Pokémon";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(21, 105);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 25);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nome";
            // 
            // lbl_Tipo1
            // 
            this.lbl_Tipo1.AutoSize = true;
            this.lbl_Tipo1.Location = new System.Drawing.Point(23, 142);
            this.lbl_Tipo1.Name = "lbl_Tipo1";
            this.lbl_Tipo1.Size = new System.Drawing.Size(62, 25);
            this.lbl_Tipo1.TabIndex = 2;
            this.lbl_Tipo1.Text = "Tipo 1";
            // 
            // lbl_Tipo2
            // 
            this.lbl_Tipo2.AutoSize = true;
            this.lbl_Tipo2.Location = new System.Drawing.Point(21, 177);
            this.lbl_Tipo2.Name = "lbl_Tipo2";
            this.lbl_Tipo2.Size = new System.Drawing.Size(62, 25);
            this.lbl_Tipo2.TabIndex = 2;
            this.lbl_Tipo2.Text = "Tipo 2";
            // 
            // lbl_Evolution
            // 
            this.lbl_Evolution.AutoSize = true;
            this.lbl_Evolution.Location = new System.Drawing.Point(21, 227);
            this.lbl_Evolution.Name = "lbl_Evolution";
            this.lbl_Evolution.Size = new System.Drawing.Size(476, 25);
            this.lbl_Evolution.TabIndex = 2;
            this.lbl_Evolution.Text = "Quantos candys são necessários para a próxima evolução?";
            // 
            // lbl_Buddy
            // 
            this.lbl_Buddy.AutoSize = true;
            this.lbl_Buddy.Location = new System.Drawing.Point(21, 262);
            this.lbl_Buddy.Name = "lbl_Buddy";
            this.lbl_Buddy.Size = new System.Drawing.Size(429, 25);
            this.lbl_Buddy.TabIndex = 2;
            this.lbl_Buddy.Text = "Quantos km são necessários para ganhar um candy?";
            // 
            // lbl_Egg
            // 
            this.lbl_Egg.AutoSize = true;
            this.lbl_Egg.Location = new System.Drawing.Point(21, 291);
            this.lbl_Egg.Name = "lbl_Egg";
            this.lbl_Egg.Size = new System.Drawing.Size(306, 25);
            this.lbl_Egg.TabIndex = 2;
            this.lbl_Egg.Text = "Que tipo de egg esse Pokémon tem?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qual é o CP máximo deste Pokémon?";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(143, 71);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(307, 31);
            this.txt_Id.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(143, 108);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(307, 31);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_CPMax
            // 
            this.txt_CPMax.Location = new System.Drawing.Point(503, 336);
            this.txt_CPMax.Name = "txt_CPMax";
            this.txt_CPMax.Size = new System.Drawing.Size(285, 31);
            this.txt_CPMax.TabIndex = 10;
            // 
            // box_Tipo1
            // 
            this.box_Tipo1.FormattingEnabled = true;
            this.box_Tipo1.Items.AddRange(new object[] {
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
            this.box_Tipo1.Location = new System.Drawing.Point(143, 142);
            this.box_Tipo1.Name = "box_Tipo1";
            this.box_Tipo1.Size = new System.Drawing.Size(307, 33);
            this.box_Tipo1.TabIndex = 5;
            // 
            // box_Tipo2
            // 
            this.box_Tipo2.FormattingEnabled = true;
            this.box_Tipo2.Items.AddRange(new object[] {
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
            this.box_Tipo2.Location = new System.Drawing.Point(143, 181);
            this.box_Tipo2.Name = "box_Tipo2";
            this.box_Tipo2.Size = new System.Drawing.Size(307, 33);
            this.box_Tipo2.TabIndex = 6;
            // 
            // box_Evol
            // 
            this.box_Evol.FormattingEnabled = true;
            this.box_Evol.Items.AddRange(new object[] {
            "Não possui evolução",
            "12",
            "25",
            "50",
            "100",
            "400"});
            this.box_Evol.Location = new System.Drawing.Point(503, 219);
            this.box_Evol.Name = "box_Evol";
            this.box_Evol.Size = new System.Drawing.Size(285, 33);
            this.box_Evol.TabIndex = 7;
            // 
            // box_Buddy
            // 
            this.box_Buddy.FormattingEnabled = true;
            this.box_Buddy.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "20"});
            this.box_Buddy.Location = new System.Drawing.Point(503, 258);
            this.box_Buddy.Name = "box_Buddy";
            this.box_Buddy.Size = new System.Drawing.Size(285, 33);
            this.box_Buddy.TabIndex = 8;
            // 
            // box_Egg
            // 
            this.box_Egg.FormattingEnabled = true;
            this.box_Egg.Items.AddRange(new object[] {
            "Não possui egg",
            "2 km",
            "5 km",
            "7 km",
            "10 km"});
            this.box_Egg.Location = new System.Drawing.Point(503, 297);
            this.box_Egg.Name = "box_Egg";
            this.box_Egg.Size = new System.Drawing.Size(285, 33);
            this.box_Egg.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(503, 409);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(285, 34);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(158, 409);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(112, 34);
            this.btn_Sair.TabIndex = 14;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(25, 409);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(112, 34);
            this.btn_Voltar.TabIndex = 13;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // txt_Lvl35
            // 
            this.txt_Lvl35.Location = new System.Drawing.Point(503, 373);
            this.txt_Lvl35.Name = "txt_Lvl35";
            this.txt_Lvl35.Size = new System.Drawing.Size(285, 31);
            this.txt_Lvl35.TabIndex = 11;
            // 
            // lbl_Lvl35
            // 
            this.lbl_Lvl35.AutoSize = true;
            this.lbl_Lvl35.Location = new System.Drawing.Point(23, 373);
            this.lbl_Lvl35.Name = "lbl_Lvl35";
            this.lbl_Lvl35.Size = new System.Drawing.Size(336, 25);
            this.lbl_Lvl35.TabIndex = 2;
            this.lbl_Lvl35.Text = "Qual é o CP deste Pokémon no Level 35?";
            // 
            // FormInserirPokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Lvl35);
            this.Controls.Add(this.txt_Lvl35);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.box_Egg);
            this.Controls.Add(this.box_Buddy);
            this.Controls.Add(this.box_Evol);
            this.Controls.Add(this.box_Tipo2);
            this.Controls.Add(this.box_Tipo1);
            this.Controls.Add(this.txt_CPMax);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Egg);
            this.Controls.Add(this.lbl_Buddy);
            this.Controls.Add(this.lbl_Evolution);
            this.Controls.Add(this.lbl_Tipo2);
            this.Controls.Add(this.lbl_Tipo1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormInserirPokeDex";
            this.Text = "FormInserirPokeDex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Tipo1;
        private System.Windows.Forms.Label lbl_Tipo2;
        private System.Windows.Forms.Label lbl_Evolution;
        private System.Windows.Forms.Label lbl_Buddy;
        private System.Windows.Forms.Label lbl_Egg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_CPMax;
        private System.Windows.Forms.ComboBox box_Tipo1;
        private System.Windows.Forms.ComboBox box_Tipo2;
        private System.Windows.Forms.ComboBox box_Evol;
        private System.Windows.Forms.ComboBox box_Buddy;
        private System.Windows.Forms.ComboBox box_Egg;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.TextBox txt_Lvl35;
        private System.Windows.Forms.Label lbl_Lvl35;
    }
}