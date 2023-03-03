using RentACar.Lib;

namespace RentACarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tasit> Tasitlar = new List<Tasit>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Motor yeniMotor = new Motor();
            yeniMotor.KoltukSayisi = 2;
            yeniMotor.Model = "Yamaha";
            yeniMotor.Km = 265;
            yeniMotor.Fiyat = 250;
            yeniMotor.Renk = "Kýrmýzý";
            yeniMotor.TekerlekSayisi = 2;



            Otomobil yeniOtomobil = new Otomobil();
            yeniOtomobil.Fiyat = 3.500;
            yeniOtomobil.Km = 140;
            yeniOtomobil.Renk = "Siyah";
            yeniOtomobil.Model = "BMW";
            yeniOtomobil.TekerlekSayisi = 4;
            yeniOtomobil.KoltukSayisi = 2;

            Tasitlar.Add(yeniMotor);
            Tasitlar.Add(yeniOtomobil);
            this.Text = $"Motorun rengi : {yeniMotor.Renk}";



        }
    }
}