namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            listBox4 = new ListBox();
            button2 = new Button();
            listBox5 = new ListBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label11 = new Label();
            müzikcalanzımbırtı = new AxWMPLib.AxWindowsMediaPlayer();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)müzikcalanzımbırtı).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(183, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(183, 84);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 391);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.untitled;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(91, 235);
            button1.Name = "button1";
            button1.Size = new Size(243, 66);
            button1.TabIndex = 13;
            button1.Text = "RANDEVUYU KAYDET";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.MediumPurple;
            label5.Location = new Point(6, 165);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 12;
            label5.Text = "RANDEVU TARİHİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(0, 87);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 11;
            label1.Text = "TC KİMLİK NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.MediumPurple;
            label4.Location = new Point(0, 203);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 10;
            label4.Text = "RANDEVU SAATİ";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(183, 195);
            maskedTextBox2.Mask = "90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kardiyoloji", "Göğüs Hastalıkları", "Kalp", "Beyin Cerrahisi", "Diksiyon", "Kadın Doğum Hastalıkları" });
            comboBox1.Location = new Point(183, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.MediumPurple;
            label3.Location = new Point(0, 130);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = " POLİKİNLİK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(0, 43);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 5;
            label2.Text = "HASTANIN ADI SOYADI";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(listBox4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox5);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(438, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 397);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.imagesGZJBUZ5D;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(312, 331);
            button3.Name = "button3";
            button3.Size = new Size(290, 53);
            button3.TabIndex = 16;
            button3.Text = "TÜM RANDEVULARI SİL";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(510, 36);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(98, 289);
            listBox4.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = Properties.Resources.untitled11;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(16, 331);
            button2.Name = "button2";
            button2.Size = new Size(290, 53);
            button2.TabIndex = 15;
            button2.Text = "RANDEVUYU SİL";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(365, 36);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(150, 289);
            listBox5.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(511, 12);
            label10.Name = "label10";
            label10.Size = new Size(95, 21);
            label10.TabIndex = 7;
            label10.Text = "RAN. SAATİ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(365, 12);
            label9.Name = "label9";
            label9.Size = new Size(103, 21);
            label9.TabIndex = 6;
            label9.Text = "RAN. TARİHİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(226, 12);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 5;
            label8.Text = "POLİKİNLİK";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(133, 12);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 4;
            label7.Text = "TC KİMLİK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(16, 12);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 3;
            label6.Text = "AD SOYAD";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(226, 36);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(141, 289);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(133, 36);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(98, 289);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 289);
            listBox1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(250, 18);
            label11.Name = "label11";
            label11.Size = new Size(449, 36);
            label11.TabIndex = 5;
            label11.Text = "AKSARAY HASTANESİ RANDEVU SİSTEMİ";
            // 
            // müzikcalanzımbırtı
            // 
            müzikcalanzımbırtı.Enabled = true;
            müzikcalanzımbırtı.Location = new Point(1058, -1);
            müzikcalanzımbırtı.Name = "müzikcalanzımbırtı";
            müzikcalanzımbırtı.OcxState = (AxHost.State)resources.GetObject("müzikcalanzımbırtı.OcxState");
            müzikcalanzımbırtı.Size = new Size(16, 10);
            müzikcalanzımbırtı.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 513);
            Controls.Add(müzikcalanzımbırtı);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)müzikcalanzımbırtı).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private Label label1;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private ListBox listBox4;
        private ListBox listBox5;
        private Label label11;
        private Button button3;
        private Button button2;
        private AxWMPLib.AxWindowsMediaPlayer müzikcalanzımbırtı;
    }
}
