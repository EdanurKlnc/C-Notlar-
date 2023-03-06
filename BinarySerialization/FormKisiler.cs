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
            if (_seciliKisi == null)
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
                    //lstKisiler.Items.Add(kisi);
                    _kisiler.Remove(kisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }

                catch (Exception ex)
                {
                    // $=iki string birleştirirken + yerine kullanılır
                    MessageBox.Show($"Bir hata oluştu!!!! {ex.Message}");

                }
            }
            else
            {
                try
                {
                    //Güncelleme işlemi
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tel = txtTelefonNo.Text;
                    _seciliKisi.Tc = txtTc.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    FormuTemizle();
                    btnKayit.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu!!!! {ex.Message}");

                }
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
                    _seciliKisi = null;
                }
            }
        }
        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi? _seciliKisi;
        //Çıktıya(listeye) tıkladığında bilgileri doldurma
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                _seciliKisi = null;
                return;
            }

            _seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = _seciliKisi.Ad;
            txtSoyad.Text = _seciliKisi.Soyad;
            txtTc.Text = _seciliKisi.Tc;
            txtTelefonNo.Text = _seciliKisi.Tel;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;

            btnKayit.Text = "Güncelle";
        }

        // Kişiyi düzenle/sil
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            var seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} {seciliKisi.Soyad} kişisini silmek istiyor musunuz ", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //  lstKisiler.Items.Remove(seciliKisi);
                _kisiler.Remove(seciliKisi);
                lstKisiler.DataSource = _kisiler;
                FormuTemizle();
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama= txtAra.Text.ToLower();
            /*
            List<Kisi> souc = new List<Kisi>();
            foreach( Kisi item in _kisiler)
            {
                if (item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) )
                    sonuc.add(item);
            }
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc; */

          
            

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
