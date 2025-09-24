namespace WinFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 loginForm = new Form2();
            DialogResult result = loginForm.ShowDialog(); // Giri� ekran�

            if (result == DialogResult.OK)
            {
                Application.Run(new Form1()); // Giri� do�ruysa form1 �al���r
            }
            else
            {
                Application.Exit(); // Yanl��sa program kapan�r
            }
        }
    }
}