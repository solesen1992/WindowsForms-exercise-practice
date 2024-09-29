namespace WindowsForms_exercise_practice
{
    /*
     * A main purpose with this exercise is to practice propagating errors from a lower level to 
     * the presentation layer (GuiLayer) – where the user are shown an error message. Another purpose 
     * is of course to get acquainted with error handling in C#.
     */
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
            Application.Run(new Form1());
        }
    }
}