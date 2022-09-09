using AbcYazilim.OgrenciTakip.UI.Win.Forms.GeneralForms;

namespace AbcYazilim.OgrenciTakip.UI.Win
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}