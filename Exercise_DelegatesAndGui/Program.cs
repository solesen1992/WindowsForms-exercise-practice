/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
*/

namespace Exercise_DelegatesAndGui
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
            Application.Run(new SubscriberForm());
        }
    }
}