namespace RegisztracioAlkalmazas
{
    partial class Form_RegisztracioAlkalmazas
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_szuletesi_datum = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.label_kedvenc_hobbi = new System.Windows.Forms.Label();
            this.label_uj_hobbi = new System.Windows.Forms.Label();
            this.radioButton_ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.textBox_uj_hobbi = new System.Windows.Forms.TextBox();
            this.listBox_kedvenc_hobbi = new System.Windows.Forms.ListBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker_szuletesi_datum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(102, 8);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(132, 20);
            this.textBox_nev.TabIndex = 0;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(12, 9);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 2;
            this.label_nev.Text = "Név:";
            this.label_nev.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_szuletesi_datum
            // 
            this.label_szuletesi_datum.AutoSize = true;
            this.label_szuletesi_datum.Location = new System.Drawing.Point(12, 35);
            this.label_szuletesi_datum.Name = "label_szuletesi_datum";
            this.label_szuletesi_datum.Size = new System.Drawing.Size(84, 13);
            this.label_szuletesi_datum.TabIndex = 3;
            this.label_szuletesi_datum.Text = "Születési dátum:";
            this.label_szuletesi_datum.Click += new System.EventHandler(this.label_szuletesi_datum_Click);
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Location = new System.Drawing.Point(12, 60);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(32, 13);
            this.label_nem.TabIndex = 4;
            this.label_nem.Text = "Nem:";
            // 
            // label_kedvenc_hobbi
            // 
            this.label_kedvenc_hobbi.AutoSize = true;
            this.label_kedvenc_hobbi.Location = new System.Drawing.Point(240, 11);
            this.label_kedvenc_hobbi.Name = "label_kedvenc_hobbi";
            this.label_kedvenc_hobbi.Size = new System.Drawing.Size(82, 13);
            this.label_kedvenc_hobbi.TabIndex = 5;
            this.label_kedvenc_hobbi.Text = "Kedvenc hobbi:";
            this.label_kedvenc_hobbi.Click += new System.EventHandler(this.label_kedvenc_hobbi_Click);
            // 
            // label_uj_hobbi
            // 
            this.label_uj_hobbi.AutoSize = true;
            this.label_uj_hobbi.Location = new System.Drawing.Point(187, 136);
            this.label_uj_hobbi.Name = "label_uj_hobbi";
            this.label_uj_hobbi.Size = new System.Drawing.Size(47, 13);
            this.label_uj_hobbi.TabIndex = 6;
            this.label_uj_hobbi.Text = "Új hobb:";
            // 
            // radioButton_ferfi
            // 
            this.radioButton_ferfi.AutoSize = true;
            this.radioButton_ferfi.Location = new System.Drawing.Point(102, 58);
            this.radioButton_ferfi.Name = "radioButton_ferfi";
            this.radioButton_ferfi.Size = new System.Drawing.Size(45, 17);
            this.radioButton_ferfi.TabIndex = 7;
            this.radioButton_ferfi.TabStop = true;
            this.radioButton_ferfi.Text = "Férfi";
            this.radioButton_ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(195, 58);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(39, 17);
            this.radioButton_no.TabIndex = 8;
            this.radioButton_no.TabStop = true;
            this.radioButton_no.Text = "Nő";
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // textBox_uj_hobbi
            // 
            this.textBox_uj_hobbi.Location = new System.Drawing.Point(240, 133);
            this.textBox_uj_hobbi.Name = "textBox_uj_hobbi";
            this.textBox_uj_hobbi.Size = new System.Drawing.Size(120, 20);
            this.textBox_uj_hobbi.TabIndex = 9;
            this.textBox_uj_hobbi.TextChanged += new System.EventHandler(this.textBox_uj_hobbi_TextChanged);
            this.textBox_uj_hobbi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_uj_hobbi_KeyDown);
            // 
            // listBox_kedvenc_hobbi
            // 
            this.listBox_kedvenc_hobbi.FormattingEnabled = true;
            this.listBox_kedvenc_hobbi.Items.AddRange(new object[] {
            "Zenehallgatás"});
            this.listBox_kedvenc_hobbi.Location = new System.Drawing.Point(240, 32);
            this.listBox_kedvenc_hobbi.Name = "listBox_kedvenc_hobbi";
            this.listBox_kedvenc_hobbi.Size = new System.Drawing.Size(120, 95);
            this.listBox_kedvenc_hobbi.TabIndex = 10;
            this.listBox_kedvenc_hobbi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(285, 159);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaad.TabIndex = 11;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(102, 202);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(75, 23);
            this.button_mentes.TabIndex = 12;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // button_betoltes
            // 
            this.button_betoltes.Location = new System.Drawing.Point(190, 202);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_betoltes.TabIndex = 13;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker_szuletesi_datum
            // 
            this.dateTimePicker_szuletesi_datum.Location = new System.Drawing.Point(102, 32);
            this.dateTimePicker_szuletesi_datum.Name = "dateTimePicker_szuletesi_datum";
            this.dateTimePicker_szuletesi_datum.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker_szuletesi_datum.TabIndex = 14;
            // 
            // Form_RegisztracioAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 260);
            this.Controls.Add(this.dateTimePicker_szuletesi_datum);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.listBox_kedvenc_hobbi);
            this.Controls.Add(this.textBox_uj_hobbi);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_ferfi);
            this.Controls.Add(this.label_uj_hobbi);
            this.Controls.Add(this.label_kedvenc_hobbi);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_szuletesi_datum);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox_nev);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_RegisztracioAlkalmazas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_szuletesi_datum;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label_kedvenc_hobbi;
        private System.Windows.Forms.Label label_uj_hobbi;
        private System.Windows.Forms.RadioButton radioButton_ferfi;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.TextBox textBox_uj_hobbi;
        private System.Windows.Forms.ListBox listBox_kedvenc_hobbi;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szuletesi_datum;
    }
}

