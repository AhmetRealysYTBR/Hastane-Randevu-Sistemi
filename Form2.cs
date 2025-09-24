using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullaniciAdi == "Doktor Serkan Koca" && sifre == "12345")
            {
                this.DialogResult = DialogResult.OK;
                müzikçalanzımbırtıv2.URL = "D:\\Ticari c# uygulaması\\Hastane Randevusu\\WinFormsApp3\\Hoşgeldiniz Doktor S.mp3";
                this.Close();
            }
            else
            {
                müzikçalanzımbırtıv2.URL = "D:\\Ticari c# uygulaması\\Hastane Randevusu\\WinFormsApp3\\Hatalı kullanıcı adı.m4a";
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
        }
    }
}
