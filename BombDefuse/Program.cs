namespace BombDefuse
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
            File.Delete("SaveFileSwitches.txt");
            File.Delete("SaveFileBattleship.txt");
            File.Delete("ticState.txt");
            File.Delete("ticKeys.txt");
            File.Delete("gflState.txt");
            File.Delete("SaveFileDTP.txt");
            File.Delete("SaveFileMM.txt");
            File.Delete("equationsSaved.txt");
            File.Delete("wordSaved.txt");
            File.Delete("curr.txt");
            ApplicationConfiguration.Initialize();
            Application.Run(new Difficulty());
            
            
        }
    }
}