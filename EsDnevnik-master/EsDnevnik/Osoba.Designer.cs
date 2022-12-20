
namespace EsDnevnik
{
    partial class Osoba
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_ime = new System.Windows.Forms.Label();
            this.label_prezime = new System.Windows.Forms.Label();
            this.label_adresa = new System.Windows.Forms.Label();
            this.label_jmbg = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_uloga = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_prezime = new System.Windows.Forms.TextBox();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.textBox_jmbg = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_zvanje = new System.Windows.Forms.TextBox();
            this.button_prvi = new System.Windows.Forms.Button();
            this.button_prosli = new System.Windows.Forms.Button();
            this.button_sledeci = new System.Windows.Forms.Button();
            this.button_poslednji = new System.Windows.Forms.Button();
            this.button_izmeni = new System.Windows.Forms.Button();
            this.button_obrisi = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.label_poruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(20, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Location = new System.Drawing.Point(20, 53);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(26, 13);
            this.label_ime.TabIndex = 1;
            this.label_ime.Text = "IME";
            // 
            // label_prezime
            // 
            this.label_prezime.AutoSize = true;
            this.label_prezime.Location = new System.Drawing.Point(15, 83);
            this.label_prezime.Name = "label_prezime";
            this.label_prezime.Size = new System.Drawing.Size(55, 13);
            this.label_prezime.TabIndex = 2;
            this.label_prezime.Text = "PREZIME";
            // 
            // label_adresa
            // 
            this.label_adresa.AutoSize = true;
            this.label_adresa.Location = new System.Drawing.Point(15, 117);
            this.label_adresa.Name = "label_adresa";
            this.label_adresa.Size = new System.Drawing.Size(51, 13);
            this.label_adresa.TabIndex = 3;
            this.label_adresa.Text = "ADRESA";
            this.label_adresa.Click += new System.EventHandler(this.label_adresa_Click);
            // 
            // label_jmbg
            // 
            this.label_jmbg.AutoSize = true;
            this.label_jmbg.Location = new System.Drawing.Point(15, 147);
            this.label_jmbg.Name = "label_jmbg";
            this.label_jmbg.Size = new System.Drawing.Size(36, 13);
            this.label_jmbg.TabIndex = 4;
            this.label_jmbg.Text = "JMBG";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(15, 177);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(39, 13);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "EMAIL";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(20, 207);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(35, 13);
            this.label_pass.TabIndex = 6;
            this.label_pass.Text = "PASS";
            // 
            // label_uloga
            // 
            this.label_uloga.AutoSize = true;
            this.label_uloga.Location = new System.Drawing.Point(18, 237);
            this.label_uloga.Name = "label_uloga";
            this.label_uloga.Size = new System.Drawing.Size(48, 13);
            this.label_uloga.TabIndex = 7;
            this.label_uloga.Text = "ZVANJE";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(100, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 8;
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(100, 50);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(100, 20);
            this.textBox_ime.TabIndex = 9;
            // 
            // textBox_prezime
            // 
            this.textBox_prezime.Location = new System.Drawing.Point(100, 80);
            this.textBox_prezime.Name = "textBox_prezime";
            this.textBox_prezime.Size = new System.Drawing.Size(100, 20);
            this.textBox_prezime.TabIndex = 10;
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Location = new System.Drawing.Point(100, 110);
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(100, 20);
            this.textBox_adresa.TabIndex = 11;
            // 
            // textBox_jmbg
            // 
            this.textBox_jmbg.Location = new System.Drawing.Point(100, 140);
            this.textBox_jmbg.Name = "textBox_jmbg";
            this.textBox_jmbg.Size = new System.Drawing.Size(100, 20);
            this.textBox_jmbg.TabIndex = 12;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(100, 170);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 13;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(100, 200);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass.TabIndex = 14;
            // 
            // textBox_zvanje
            // 
            this.textBox_zvanje.Location = new System.Drawing.Point(100, 230);
            this.textBox_zvanje.Name = "textBox_zvanje";
            this.textBox_zvanje.Size = new System.Drawing.Size(100, 20);
            this.textBox_zvanje.TabIndex = 15;
            // 
            // button_prvi
            // 
            this.button_prvi.Location = new System.Drawing.Point(100, 293);
            this.button_prvi.Name = "button_prvi";
            this.button_prvi.Size = new System.Drawing.Size(50, 27);
            this.button_prvi.TabIndex = 16;
            this.button_prvi.Text = "<<";
            this.button_prvi.UseVisualStyleBackColor = true;
            this.button_prvi.Click += new System.EventHandler(this.button_prvi_Click);
            // 
            // button_prosli
            // 
            this.button_prosli.Location = new System.Drawing.Point(156, 293);
            this.button_prosli.Name = "button_prosli";
            this.button_prosli.Size = new System.Drawing.Size(50, 27);
            this.button_prosli.TabIndex = 17;
            this.button_prosli.Text = "<";
            this.button_prosli.UseVisualStyleBackColor = true;
            this.button_prosli.Click += new System.EventHandler(this.button_prosli_Click);
            // 
            // button_sledeci
            // 
            this.button_sledeci.Location = new System.Drawing.Point(230, 293);
            this.button_sledeci.Name = "button_sledeci";
            this.button_sledeci.Size = new System.Drawing.Size(50, 27);
            this.button_sledeci.TabIndex = 18;
            this.button_sledeci.Text = ">";
            this.button_sledeci.UseVisualStyleBackColor = true;
            this.button_sledeci.Click += new System.EventHandler(this.button_sledeci_Click);
            // 
            // button_poslednji
            // 
            this.button_poslednji.Location = new System.Drawing.Point(286, 293);
            this.button_poslednji.Name = "button_poslednji";
            this.button_poslednji.Size = new System.Drawing.Size(50, 27);
            this.button_poslednji.TabIndex = 19;
            this.button_poslednji.Text = ">>";
            this.button_poslednji.UseVisualStyleBackColor = true;
            this.button_poslednji.Click += new System.EventHandler(this.button_poslednji_Click);
            // 
            // button_izmeni
            // 
            this.button_izmeni.Location = new System.Drawing.Point(220, 50);
            this.button_izmeni.Name = "button_izmeni";
            this.button_izmeni.Size = new System.Drawing.Size(149, 50);
            this.button_izmeni.TabIndex = 20;
            this.button_izmeni.Text = "IZMENI";
            this.button_izmeni.UseVisualStyleBackColor = true;
            this.button_izmeni.Click += new System.EventHandler(this.button_izmeni_Click);
            // 
            // button_obrisi
            // 
            this.button_obrisi.Location = new System.Drawing.Point(220, 117);
            this.button_obrisi.Name = "button_obrisi";
            this.button_obrisi.Size = new System.Drawing.Size(149, 50);
            this.button_obrisi.TabIndex = 21;
            this.button_obrisi.Text = "OBRISI";
            this.button_obrisi.UseVisualStyleBackColor = true;
            this.button_obrisi.Click += new System.EventHandler(this.button_obrisi_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(220, 184);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(149, 50);
            this.button_dodaj.TabIndex = 22;
            this.button_dodaj.Text = "DODAJ";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // label_poruka
            // 
            this.label_poruka.AutoSize = true;
            this.label_poruka.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poruka.Location = new System.Drawing.Point(371, 282);
            this.label_poruka.Name = "label_poruka";
            this.label_poruka.Size = new System.Drawing.Size(237, 36);
            this.label_poruka.TabIndex = 23;
            this.label_poruka.Text = "Uspesna izmena";
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1075, 468);
            this.Controls.Add(this.label_poruka);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_obrisi);
            this.Controls.Add(this.button_izmeni);
            this.Controls.Add(this.button_poslednji);
            this.Controls.Add(this.button_sledeci);
            this.Controls.Add(this.button_prosli);
            this.Controls.Add(this.button_prvi);
            this.Controls.Add(this.textBox_zvanje);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_jmbg);
            this.Controls.Add(this.textBox_adresa);
            this.Controls.Add(this.textBox_prezime);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_uloga);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_jmbg);
            this.Controls.Add(this.label_adresa);
            this.Controls.Add(this.label_prezime);
            this.Controls.Add(this.label_ime);
            this.Controls.Add(this.label_id);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label label_prezime;
        private System.Windows.Forms.Label label_adresa;
        private System.Windows.Forms.Label label_jmbg;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_uloga;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_prezime;
        private System.Windows.Forms.TextBox textBox_adresa;
        private System.Windows.Forms.TextBox textBox_jmbg;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_zvanje;
        private System.Windows.Forms.Button button_prvi;
        private System.Windows.Forms.Button button_prosli;
        private System.Windows.Forms.Button button_sledeci;
        private System.Windows.Forms.Button button_poslednji;
        private System.Windows.Forms.Button button_izmeni;
        private System.Windows.Forms.Button button_obrisi;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Label label_poruka;
    }
}