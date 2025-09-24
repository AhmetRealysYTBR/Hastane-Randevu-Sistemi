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
            DialogResult result = loginForm.ShowDialog(); // Giriþ ekraný

            if (result == DialogResult.OK)
            {
                Application.Run(new Form1()); // Giriþ doðruysa form1 çalýþýr
            }
            else
            {
                Application.Exit(); // Yanlýþsa program kapanýr
            }
        }
    }
}