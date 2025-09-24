namespace WinFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            müzikçalanzımbırtıv2 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)müzikçalanzımbırtıv2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 228);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 2;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 3;
            label1.Text = "İsim";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // müzikçalanzımbırtıv2
            // 
            müzikçalanzımbırtıv2.Enabled = true;
            müzikçalanzımbırtıv2.Location = new Point(343, 289);
            müzikçalanzımbırtıv2.Name = "müzikçalanzımbırtıv2";
            müzikçalanzımbırtıv2.OcxState = (AxHost.State)resources.GetObject("müzikçalanzımbırtıv2.OcxState");
            müzikçalanzımbırtıv2.Size = new Size(13, 16);
            müzikçalanzımbırtıv2.TabIndex = 7;
            // 
            // Form2
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 306);
            ControlBox = false;
            Controls.Add(müzikçalanzımbırtıv2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Cursor = Cursors.No;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)müzikçalanzımbırtıv2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private AxWMPLib.AxWindowsMediaPlayer müzikçalanzımbırtıv2;
    }
}