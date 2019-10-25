using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form_RegisztracioAlkalmazas : Form
    {
        public Form_RegisztracioAlkalmazas()
        {

            InitializeComponent();
            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(textBox_nev.Text);
                        sw.WriteLine(dateTimePicker_szuletesi_datum.Text);
                        string nem;
                        if (radioButton_ferfi.Checked)
                        {
                            nem = "férfi";
                        }
                        else
                        {
                            nem = "nő";
                        }
                        sw.WriteLine(nem);
                        sw.WriteLine(listBox_kedvenc_hobbi.SelectedItem);
                        sw.Close();
                    }
                    
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a kiírás");
                }
            };

            openFileDialog1.FileOk += (senderFile, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    textBox_nev.Text = sorok[0];
                    dateTimePicker_szuletesi_datum.Text = sorok[1];
                    if (sorok[2] == "férfi")
                    {
                        radioButton_ferfi.Checked = true;
                        radioButton_no.Checked = false;
                    }
                    else
                    {
                        radioButton_no.Checked = true;
                        radioButton_ferfi.Checked = false;
                    }

                    if (!listBox_kedvenc_hobbi.Items.Contains(sorok[3]))
                    {
                        listBox_kedvenc_hobbi.Items.Add(sorok[3]);
                        listBox_kedvenc_hobbi.SelectedItem = sorok[3];
                    }
                    else
                    {
                        foreach (var item in sorok)
                        {
                            if (item == sorok[3])
                            {
                                listBox_kedvenc_hobbi.SelectedItem.Equals(item);
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Sikertelen betöltés");
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            listBox_kedvenc_hobbi.Items.Add(textBox_uj_hobbi.Text);
            textBox_uj_hobbi.Text = "";
        }

        private void label_kedvenc_hobbi_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_egyeb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_szuletesi_datum_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            if (textBox_nev.Text != "" && dateTimePicker_szuletesi_datum.Text != "" && listBox_kedvenc_hobbi.SelectedIndex != -1 && (radioButton_ferfi.Checked || radioButton_no.Checked))
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Valami nincs kitöltve!");
            }
            saveFileDialog1.ShowDialog();
        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void textBox_uj_hobbi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_uj_hobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox_kedvenc_hobbi.Items.Add(textBox_uj_hobbi.Text);
                textBox_uj_hobbi.Text = "";
            }
        }
    }
}
