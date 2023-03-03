using Urunler.Lib;


    namespace KitapciUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       //List<Urun> urunler= new List<Urun>();

        public void Form1_Load(object sender, EventArgs e)
        {
            Urun yeniKitap = new Kitap
            {
                YazarAdi = "sss",
                urunIsmý = "Merhaba"

            };

            // yeniKare.X = 5;
            this.Text = $"Kitabýn adý: {yeniKitap.urunIsmý}";


        }
    }
}