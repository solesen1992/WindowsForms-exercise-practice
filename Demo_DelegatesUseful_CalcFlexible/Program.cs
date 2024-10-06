/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
*/

namespace Demo_DelegatesUseful_CalcFlexible
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}