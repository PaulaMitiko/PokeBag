namespace PokeBagForm
{
    partial class FormCapturar
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
            this.lbl_CP = new System.Windows.Forms.Label();
            this.lbl_HP = new System.Windows.Forms.Label();
            this.lbl_Attack = new System.Windows.Forms.Label();
            this.lbl_Defense = new System.Windows.Forms.Label();
            this.lbl_Stamina = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_Evento = new System.Windows.Forms.Label();
            this.lbl_Sombroso = new System.Windows.Forms.Label();
            this.lbl_Fast = new System.Windows.Forms.Label();
            this.lbl_Charge = new System.Windows.Forms.Label();
            this.box_NoPokemon = new System.Windows.Forms.ComboBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.txt_HP = new System.Windows.Forms.TextBox();
            this.txt_Attack = new System.Windows.Forms.TextBox();
            this.txt_Defense = new System.Windows.Forms.TextBox();
            this.txt_Stamina = new System.Windows.Forms.TextBox();
            this.txt_Fast = new System.Windows.Forms.TextBox();
            this.txt_Charge = new System.Windows.Forms.TextBox();
            this.txt_Evento = new System.Windows.Forms.TextBox();
            this.txt_Sombroso = new System.Windows.Forms.TextBox();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_ShinySim = new System.Windows.Forms.RadioButton();
            this.btn_ShinyNao = new System.Windows.Forms.RadioButton();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.box_Cidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.Location = new System.Drawing.Point(207, 28);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(385, 32);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "Inserir Pokémon Capturado";
            // 
            // lbl_NoPokemon
            // 
            this.lbl_NoPokemon.AutoSize = true;
            this.lbl_NoPokemon.Location = new System.Drawing.Point(27, 83);
            this.lbl_NoPokemon.Name = "lbl_NoPokemon";
            this.lbl_NoPokemon.Size = new System.Drawing.Size(96, 20);
            this.lbl_NoPokemon.TabIndex = 1;
            this.lbl_NoPokemon.Text = "NoPokemon";
            // 
            // lbl_CP
            // 
            this.lbl_CP.AutoSize = true;
            this.lbl_CP.Location = new System.Drawing.Point(27, 119);
            this.lbl_CP.Name = "lbl_CP";
            this.lbl_CP.Size = new System.Drawing.Size(113, 20);
            this.lbl_CP.TabIndex = 2;
            this.lbl_CP.Text = "Combat Points";
            // 
            // lbl_HP
            // 
            this.lbl_HP.AutoSize = true;
            this.lbl_HP.Location = new System.Drawing.Point(27, 156);
            this.lbl_HP.Name = "lbl_HP";
            this.lbl_HP.Size = new System.Drawing.Size(104, 20);
            this.lbl_HP.TabIndex = 3;
            this.lbl_HP.Text = "Health Points";
            // 
            // lbl_Attack
            // 
            this.lbl_Attack.AutoSize = true;
            this.lbl_Attack.Location = new System.Drawing.Point(412, 83);
            this.lbl_Attack.Name = "lbl_Attack";
            this.lbl_Attack.Size = new System.Drawing.Size(55, 20);
            this.lbl_Attack.TabIndex = 4;
            this.lbl_Attack.Text = "Attack";
            // 
            // lbl_Defense
            // 
            this.lbl_Defense.AutoSize = true;
            this.lbl_Defense.Location = new System.Drawing.Point(410, 119);
            this.lbl_Defense.Name = "lbl_Defense";
            this.lbl_Defense.Size = new System.Drawing.Size(70, 20);
            this.lbl_Defense.TabIndex = 5;
            this.lbl_Defense.Text = "Defense";
            // 
            // lbl_Stamina
            // 
            this.lbl_Stamina.AutoSize = true;
            this.lbl_Stamina.Location = new System.Drawing.Point(412, 156);
            this.lbl_Stamina.Name = "lbl_Stamina";
            this.lbl_Stamina.Size = new System.Drawing.Size(68, 20);
            this.lbl_Stamina.TabIndex = 6;
            this.lbl_Stamina.Text = "Stamina";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(27, 212);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(59, 20);
            this.lbl_Cidade.TabIndex = 7;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(27, 247);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(105, 20);
            this.lbl_Data.TabIndex = 8;
            this.lbl_Data.Text = "Data Captura";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 297);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 20);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Shiny";
            // 
            // lbl_Evento
            // 
            this.lbl_Evento.AutoSize = true;
            this.lbl_Evento.Location = new System.Drawing.Point(27, 327);
            this.lbl_Evento.Name = "lbl_Evento";
            this.lbl_Evento.Size = new System.Drawing.Size(59, 20);
            this.lbl_Evento.TabIndex = 10;
            this.lbl_Evento.Text = "Evento";
            // 
            // lbl_Sombroso
            // 
            this.lbl_Sombroso.AutoSize = true;
            this.lbl_Sombroso.Location = new System.Drawing.Point(27, 361);
            this.lbl_Sombroso.Name = "lbl_Sombroso";
            this.lbl_Sombroso.Size = new System.Drawing.Size(82, 20);
            this.lbl_Sombroso.TabIndex = 11;
            this.lbl_Sombroso.Text = "Sombroso";
            // 
            // lbl_Fast
            // 
            this.lbl_Fast.AutoSize = true;
            this.lbl_Fast.Location = new System.Drawing.Point(412, 215);
            this.lbl_Fast.Name = "lbl_Fast";
            this.lbl_Fast.Size = new System.Drawing.Size(91, 20);
            this.lbl_Fast.TabIndex = 13;
            this.lbl_Fast.Text = "Fast Attack";
            // 
            // lbl_Charge
            // 
            this.lbl_Charge.AutoSize = true;
            this.lbl_Charge.Location = new System.Drawing.Point(412, 244);
            this.lbl_Charge.Name = "lbl_Charge";
            this.lbl_Charge.Size = new System.Drawing.Size(111, 20);
            this.lbl_Charge.TabIndex = 14;
            this.lbl_Charge.Text = "Charge Attack";
            // 
            // box_NoPokemon
            // 
            this.box_NoPokemon.FormattingEnabled = true;
            this.box_NoPokemon.Items.AddRange(new object[] {
            "1           Bulbasaur",
            "2           Ivysaur",
            "3           Vanusaur",
            "4           Charmander",
            "5           Charmeleon",
            "6           Charizard",
            "7           Squirtle",
            "8           Wartortle",
            "9           Blastoise",
            "10          Caterpie",
            "11          Metapod",
            "12          Butterfree",
            "13          Weedle",
            "14          Kakuna",
            "15          Beedrill",
            "16          Pidgey",
            "17          Pidgeotto",
            "18          Pidgeot",
            "19          Rattata",
            "20          Raticate",
            "21          Spearow",
            "22          Fearow",
            "23          Ekans",
            "24          Arbok",
            "25          Pikachu",
            "26          Raichu",
            "27          Sandshrew",
            "28          Sandslash",
            "29          Nidoran(F)",
            "30          Nidorina",
            "31          Nidoqueen",
            "32          Nidoran(M)",
            "33          Nidorino",
            "34          Nidoking",
            "35          Clefairy",
            "36          Clefable",
            "37          Vulpix",
            "38          Ninetales",
            "39          Jigglypuff",
            "40          Wigglytuff",
            "41          Zubat",
            "42          Golbat",
            "43          Oddish",
            "44          Gloom",
            "45          Vileplume"});
            this.box_NoPokemon.Location = new System.Drawing.Point(150, 83);
            this.box_NoPokemon.Name = "box_NoPokemon";
            this.box_NoPokemon.Size = new System.Drawing.Size(238, 28);
            this.box_NoPokemon.TabIndex = 15;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(150, 119);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(238, 26);
            this.txt_CP.TabIndex = 16;
            // 
            // txt_HP
            // 
            this.txt_HP.Location = new System.Drawing.Point(150, 151);
            this.txt_HP.Name = "txt_HP";
            this.txt_HP.Size = new System.Drawing.Size(238, 26);
            this.txt_HP.TabIndex = 17;
            // 
            // txt_Attack
            // 
            this.txt_Attack.Location = new System.Drawing.Point(529, 85);
            this.txt_Attack.Name = "txt_Attack";
            this.txt_Attack.Size = new System.Drawing.Size(238, 26);
            this.txt_Attack.TabIndex = 18;
            // 
            // txt_Defense
            // 
            this.txt_Defense.Location = new System.Drawing.Point(529, 121);
            this.txt_Defense.Name = "txt_Defense";
            this.txt_Defense.Size = new System.Drawing.Size(238, 26);
            this.txt_Defense.TabIndex = 19;
            // 
            // txt_Stamina
            // 
            this.txt_Stamina.Location = new System.Drawing.Point(529, 153);
            this.txt_Stamina.Name = "txt_Stamina";
            this.txt_Stamina.Size = new System.Drawing.Size(238, 26);
            this.txt_Stamina.TabIndex = 20;
            // 
            // txt_Fast
            // 
            this.txt_Fast.Location = new System.Drawing.Point(529, 212);
            this.txt_Fast.Name = "txt_Fast";
            this.txt_Fast.Size = new System.Drawing.Size(238, 26);
            this.txt_Fast.TabIndex = 21;
            // 
            // txt_Charge
            // 
            this.txt_Charge.Location = new System.Drawing.Point(529, 241);
            this.txt_Charge.Name = "txt_Charge";
            this.txt_Charge.Size = new System.Drawing.Size(238, 26);
            this.txt_Charge.TabIndex = 22;
            // 
            // txt_Evento
            // 
            this.txt_Evento.Location = new System.Drawing.Point(150, 321);
            this.txt_Evento.Name = "txt_Evento";
            this.txt_Evento.Size = new System.Drawing.Size(238, 26);
            this.txt_Evento.TabIndex = 24;
            // 
            // txt_Sombroso
            // 
            this.txt_Sombroso.Location = new System.Drawing.Point(150, 353);
            this.txt_Sombroso.Name = "txt_Sombroso";
            this.txt_Sombroso.Size = new System.Drawing.Size(238, 26);
            this.txt_Sombroso.TabIndex = 25;
            // 
            // dt_Data
            // 
            this.dt_Data.Location = new System.Drawing.Point(150, 239);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(238, 26);
            this.dt_Data.TabIndex = 26;
            // 
            // btn_ShinySim
            // 
            this.btn_ShinySim.AutoSize = true;
            this.btn_ShinySim.Location = new System.Drawing.Point(150, 291);
            this.btn_ShinySim.Name = "btn_ShinySim";
            this.btn_ShinySim.Size = new System.Drawing.Size(61, 24);
            this.btn_ShinySim.TabIndex = 27;
            this.btn_ShinySim.TabStop = true;
            this.btn_ShinySim.Text = "Sim";
            this.btn_ShinySim.UseVisualStyleBackColor = true;
            // 
            // btn_ShinyNao
            // 
            this.btn_ShinyNao.AutoSize = true;
            this.btn_ShinyNao.Location = new System.Drawing.Point(279, 291);
            this.btn_ShinyNao.Name = "btn_ShinyNao";
            this.btn_ShinyNao.Size = new System.Drawing.Size(63, 24);
            this.btn_ShinyNao.TabIndex = 28;
            this.btn_ShinyNao.TabStop = true;
            this.btn_ShinyNao.Text = "Não";
            this.btn_ShinyNao.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(279, 417);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(234, 43);
            this.btn_Salvar.TabIndex = 31;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // box_Cidade
            // 
            this.box_Cidade.FormattingEnabled = true;
            this.box_Cidade.Location = new System.Drawing.Point(150, 204);
            this.box_Cidade.Name = "box_Cidade";
            this.box_Cidade.Size = new System.Drawing.Size(238, 28);
            this.box_Cidade.TabIndex = 32;
            // 
            // FormCapturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.box_Cidade);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_ShinyNao);
            this.Controls.Add(this.btn_ShinySim);
            this.Controls.Add(this.dt_Data);
            this.Controls.Add(this.txt_Sombroso);
            this.Controls.Add(this.txt_Evento);
            this.Controls.Add(this.txt_Charge);
            this.Controls.Add(this.txt_Fast);
            this.Controls.Add(this.txt_Stamina);
            this.Controls.Add(this.txt_Defense);
            this.Controls.Add(this.txt_Attack);
            this.Controls.Add(this.txt_HP);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.box_NoPokemon);
            this.Controls.Add(this.lbl_Charge);
            this.Controls.Add(this.lbl_Fast);
            this.Controls.Add(this.lbl_Sombroso);
            this.Controls.Add(this.lbl_Evento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Stamina);
            this.Controls.Add(this.lbl_Defense);
            this.Controls.Add(this.lbl_Attack);
            this.Controls.Add(this.lbl_HP);
            this.Controls.Add(this.lbl_CP);
            this.Controls.Add(this.lbl_NoPokemon);
            this.Controls.Add(this.lbl_Título);
            this.Name = "FormCapturar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_NoPokemon;
        private System.Windows.Forms.Label lbl_CP;
        private System.Windows.Forms.Label lbl_HP;
        private System.Windows.Forms.Label lbl_Attack;
        private System.Windows.Forms.Label lbl_Defense;
        private System.Windows.Forms.Label lbl_Stamina;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_Evento;
        private System.Windows.Forms.Label lbl_Sombroso;
        private System.Windows.Forms.Label lbl_Fast;
        private System.Windows.Forms.Label lbl_Charge;
        private System.Windows.Forms.ComboBox box_NoPokemon;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_HP;
        private System.Windows.Forms.TextBox txt_Attack;
        private System.Windows.Forms.TextBox txt_Defense;
        private System.Windows.Forms.TextBox txt_Stamina;
        private System.Windows.Forms.TextBox txt_Fast;
        private System.Windows.Forms.TextBox txt_Charge;
        private System.Windows.Forms.TextBox txt_Evento;
        private System.Windows.Forms.TextBox txt_Sombroso;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.RadioButton btn_ShinySim;
        private System.Windows.Forms.RadioButton btn_ShinyNao;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.ComboBox box_Cidade;
    }
}

