namespace ERPSharp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            StartApp();
        }

        static void StartApp()
        {
            LoginForm loginForm = new LoginForm();
            DialogResult loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                Application.Run(new Menu());
            }
        }
    }
}
