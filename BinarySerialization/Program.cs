namespace WFormGiris
{

    //Birden fazla form oldu�unda �al��t�rmak istedi�imiz formun ad�n� Application.Run(�all��t�rmak�stedi�imizForm) i�erisinde belirtiyoruz
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