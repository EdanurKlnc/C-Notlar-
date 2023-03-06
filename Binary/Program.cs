namespace WFormGiris
{

    //Birden fazla form olduðunda çalýþtýrmak istediðimiz formun adýný Application.Run(ÇallýþtýrmakÝstediðimizForm) içerisinde belirtiyoruz
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
            Application.Run(new FormKisiler());
        }
    }
}