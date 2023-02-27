namespace WFormGiris
{
    public partial class FormKisiler : Form
    {

        public FormKisiler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKisiler_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                //1.Yöntem
                /*
                Kisi kisi = new Kisi();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Tc = txtTc.Text;
                kisi.DogumTarihi = dtpDogumTarihi.Value;
                kisi.Tel = txtTelefonNo.Text;
                kisi.Email = txtMail.Text; */


                //2.Yöntem Object Initializer
                Kisi kisi = new Kisi()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    //Email = txtMail.Text,
                    Tel = txtTelefonNo.Text,
                    Tc = txtTc.Text
                };

                kisi.ToString();
                //lstKisiler.DisplayMember = "Ad"; //Girilen adı ekrana yazdırma
                lstKisiler.Items.Add(kisi);
                FormuTemizle();
            }

            catch (Exception ex)
            {
                // $=iki string birleştirirken + yerine kullanılır
                MessageBox.Show($"Bir hata oluştu!!!! {ex.Message}");

            }


        }

        private void FormuTemizle(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                item.Text = String.Empty;
            }
        }
    }
}
