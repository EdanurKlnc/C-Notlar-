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
            this.Text = $"Karenin alan�: {yeniKare.AlanHesapla()}";

            Sekil yeniDikd�rtgen = new Dikd�rtgen
            {
                X = 5,
                Y = 12
            }
           // yeniDikd�rtgen.X = 5;
           // yeniDikd�rtgen.Y = 1;
            this.Text = $"Dikd�rtgenin alan�: {yeniDikd�rtgen.AlanHesapla()}";

            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikd�rtgen);
            //sekiller.Add(yeniSekil);

        }
    }
}