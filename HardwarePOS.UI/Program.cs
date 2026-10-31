using HardwarePOS.UI.Forms;

namespace HardwarePOS.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Unhandled exception එකක් ආවොත් crash නොවී පෙන්නන්න
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception)args.ExceptionObject;
                MessageBox.Show($"Global Error: {ex.Message}\n\nDetails:\n{ex.StackTrace}", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show($"UI Thread Error: {args.Exception.Message}\n\nDetails:\n{args.Exception.StackTrace}", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            ApplicationConfiguration.Initialize();

            try
            {
                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Startup Error: {ex.Message}\n\nDetails:\n{ex.StackTrace}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

