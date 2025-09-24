using System.IO;
using System.Windows.Forms;

namespace WinFormsApp3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaYolu = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "randevular.txt"
        );
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)

        {
            string ad = textBox1.Text.Trim();
            string tc = maskedTextBox1.Text.Trim();
            string tarih = dateTimePicker1.Text.Trim();
            string bolum = comboBox1.Text.Trim();
            string saat = maskedTextBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(ad) &&
                !string.IsNullOrWhiteSpace(tc) &&
                !string.IsNullOrWhiteSpace(tarih) &&
                !string.IsNullOrWhiteSpace(bolum) &&
                !string.IsNullOrWhiteSpace(saat))
            {
                
                listBox1.Items.Add(ad);
                listBox2.Items.Add(tc);
                listBox3.Items.Add(bolum);
                listBox5.Items.Add(tarih);
                listBox4.Items.Add(saat);

                
                string satir = $"{ad}|{tc}|{tarih}|{bolum}|{saat}";
                using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
                {
                    sw.WriteLine(satir);
                }

                
                textBox1.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            if (File.Exists(dosyaYolu))
            {
                File.Delete(dosyaYolu);
            }
        }
        int a = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            listBox2.Items.RemoveAt(a);
            listBox3.Items.RemoveAt(a);
            listBox4.Items.RemoveAt(a);
            listBox5.Items.RemoveAt(a);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split('|');
                    if (parcalar.Length == 5)
                    {
                        listBox1.Items.Add(parcalar[0]);
                        listBox2.Items.Add(parcalar[1]);
                        listBox3.Items.Add(parcalar[2]);
                        listBox5.Items.Add(parcalar[3]);
                        listBox4.Items.Add(parcalar[4]);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
