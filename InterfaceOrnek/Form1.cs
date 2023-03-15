using InterfaceOrnek.Entities;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpBoxIslemler.Enabled = false;
            radioBtnDikdortgen.Checked = false;
            radioBtnKare.Checked = true;
            //radio biri utlaka secili geldiði için secili gelen sekle göre groupboxý ayarladýk
            grpBoxIslemler.Enabled = true;
            lblKenar2.Visible = false;
            txtKenar2.Visible = false;
            lblKenar1.Text = "Kare Ýsim :";


            btnAlanHesapla.Click += new EventHandler(Hesapla); //eventlar += ile tetiklenir
            btnCevreHesapla.Click += new EventHandler(Hesapla);
        } //form load metot bitti

        private void Hesapla(object? sender, EventArgs e)
        {
            //gönderici(sender) kim? bun belirleyip iþleme devam edeceðiz
            string islemAdi = "";
            if (((Button)sender).Name.Contains("cevre"))
                islemAdi = "cevre";
            if (((Button)sender).Name == "btnAlanHesapla")
                islemAdi = "Alan";

            //kimin alaný yada cevresi ?
            if (radioBtnDikdortgen.Checked)
            {
                Dikdortgen dikdortgen = new Dikdortgen()
                {
                    SekilAdi = txtSekilAdi.Text,
                    KisaKenar = Convert.ToInt32(txtKenar1.Text),
                    UzunKenar = Convert.ToInt32(txtKenar2.Text)
                };
                double sonuc = 0;
                switch (islemAdi)
                {
                    case "cevre":
                        sonuc = dikdortgen.CevreHesapla();
                        break;
                    case "Alan ":
                        sonuc = dikdortgen.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{dikdortgen.SekilAdi} seklin {islemAdi} iþlem sonucu {sonuc}");

            }
            else if (radioBtnKare.Checked)
            {
                Kare kare = new Kare()
                {
                    SekilAdi = txtSekilAdi.Text,
                    Kenar = Convert.ToInt32(txtKenar1.Text)
                };
                double sonuc = 0;

                switch (islemAdi)
                {
                    case "cevre":
                        sonuc = kare.CevreHesapla();
                        break;
                    case "Alan ":
                        sonuc = kare.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{kare.SekilAdi} seklin {islemAdi} iþlem sonucu {sonuc}");

            }
        }
        private void Temizle()
        {
            foreach (var item in grpBoxIslemler.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                grpBoxIslemler.Enabled = false;
            }
        }

        private void radioBtnKare_CheckedChanged(object sender, EventArgs e)
        {
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;
            lblKenar1.Text = "kare isim:";

        }

        private void radioBtnDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Visible = true;
            txtKenar2.Visible = true;

            lblKenar1.Text = "kenar isim:";

        }
    }
}