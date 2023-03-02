using Kalitim.Lib;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {

            //  Sekil yeniSekil = new Sekil();
            // yeniSekil.X = 4;

            Sekil yeniKare = new Kare
            {
                X = 5
            };
            // yeniKare.X = 5;
            this.Text = $"Karenin alaný: {yeniKare.AlanHesapla()}";

            Sekil yeniDikdörtgen = new Dikdörtgen
            {
                X = 5,
                Y = 12
            }
           // yeniDikdörtgen.X = 5;
           // yeniDikdörtgen.Y = 1;
            this.Text = $"Dikdörtgenin alaný: {yeniDikdörtgen.AlanHesapla()}";

            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikdörtgen);
            //sekiller.Add(yeniSekil);

        }
    }
}