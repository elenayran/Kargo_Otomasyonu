using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace KargoTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kontrol = 0;
        
       public static string girismail;
        string girisifre;
        private static void button3_ClickExtracted()
        {
          
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();


        }
        public void kaydet()
        {
            string baglantiyolu = "provider=microsoft.ace.oledb.12.0;data source=" + Application.StartupPath + "\\kargotakip.accdb";
            OleDbConnection baglanti = new OleDbConnection(baglantiyolu);
            baglanti.Open();
            string eklemekomutu = "insert into personel (mail,adsoyad,tcno,dogum_yili,sifre) values ('" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
            OleDbCommand komut = new OleDbCommand(eklemekomutu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("PERSONEL KAYIT  Başarılı !");

        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Contains("@") && textBox6.Text.Contains(".com"))
            {

                if (textBox6.Text == textBox7.Text && textBox11.Text == textBox12.Text)
                {
                    kaydet();
                }
                else
                {
                    MessageBox.Show("lütfen şifre ve mail tekrarı alanlarını birbiriyle eşit yapınız");
                }
            }
            else {
                MessageBox.Show("lütfen mail adresini doğru giriniz");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox11.PasswordChar = '\0'; textBox12.PasswordChar = '\0';
            }
            else
            {
                textBox11.PasswordChar = '*'; textBox12.PasswordChar = '*';
            }

        }
