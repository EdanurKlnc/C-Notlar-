namespace StatikNesneler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 5;
            double kareAlan = kare.AlanHesapla();

           // kareAlan = Kare.AlanHesapla(5);

            // Geometri geometri = new Geometri(); //static sýnýf olduðu için bu þekilde kullanýlmýyor.

            Geometri.AlanHesapla(5);

        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<10; i++)
            {
                SingletonDeneme singletonDeneme =  SingletonDeneme.GetInstance();
                Console.WriteLine(singletonDeneme.Id);
            }
            MessageBox.Show("tüm sýnýflar üretildi");
        }
    }
}