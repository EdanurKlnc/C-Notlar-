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

        private void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = String.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    // (item as DateTimePicker).Value = DateTime.Now;
                    //((DateTimePicker)item).Value = DateTime.Now;
                    dPicker.Value = DateTime.Now; //Yukarıdaki gibi dönüştürmek yerine bu şekilde yapabiliriz.
                }
                else if (item is CheckBox cBox)
                {
                    cBox.Checked = false;
                }
                else if (item is ComboBox combox)
                {
                    combox.SelectedIndex = -1;
                }
                else if (item is ListBox listBox)
                {
                    listBox.SelectedIndex = -1;
                }
            }
        }

        //Çıktıya(listeye) tıkladığında bilgileri doldurma
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            var seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTc.Text = seciliKisi.Tc;
            txtTelefonNo.Text = seciliKisi.Tel;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;


        }

        // Kişiyi düzenle/sil
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            var seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} kişisini silmek istiyor musunuz ", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstKisiler.Items.Remove(seciliKisi);
                FormuTemizle();
            }
        }
    }
}
