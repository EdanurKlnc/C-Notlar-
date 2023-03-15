namespace AracTakipUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Arac> _araclar = new List<Arac>();
        private Arac? _arac;

        private void btnKayit_Click(object sender, EventArgs e)
        {

            try
            {
                Arac arac = new Arac()
                {
                    Marka = textBoxMarka.Text,
                    Model = textBoxModel.Text,
                    ModelYili = textBoxModelyili.Text,
                    SaseNo = textBoxSaseNo.Text,
                    YakitTipi = textBoxYakitTipi.Text,
                    VitesTipi = textBoxVites.Text,
                    MotorHacmi = textBoxMotorHacmi.Text
                };

                _araclar.Add(arac);
                lstBoxListe.DataSource = null; //birden fazla kaydý sýralama için kontrol ediyoruz
                lstBoxListe.DataSource = _araclar;
                FormuTemizle();
            }
            catch (Exception ex)
            {
                // $=iki string birleþtirirken + yerine kullanýlýr
                MessageBox.Show($"Bir hata oluþtu!!!! {ex.Message}");

            }
        }


        /*
        try
        {
            //Güncelleme iþlemi
            _arac.Marka = textBoxMarka.Text;
            _arac.Model = textBoxModel.Text;
            _arac.ModelYili = textBoxModelyili.Text;
            _arac.YakitTipi = textBoxYakitTipi.Text;
            _arac.MotorHacmi = textBoxMotorHacmi.Text;
            _arac.VitesTipi = textBoxVites.Text;
            _arac.SaseNo = textBoxSaseNo.Text;
            if (_memoryStream.Length > 0)
            {
                _arac.Fotograf = _memoryStream.ToArray();

            }
            FormuTemizle();
            btnKayit.Text = "Kaydet";
            _arac = null;
            lstBoxListe.DataSource = null;
            lstBoxListe.DataSource = _araclar;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir hata oluþtu!!!! {ex.Message}");

        }*/
        /*
        try
        {
            _arac.Marka = textBoxMarka.Text;
            _arac.Model = textBoxModel.Text;
            _arac.ModelYili = textBoxModelyili.Text;
            _arac.YakitTipi = textBoxYakitTipi.Text;
            _arac.MotorHacmi = textBoxMotorHacmi.Text;
            _arac.VitesTipi = textBoxVites.Text;
            _arac.SaseNo = textBoxSaseNo.Text;


        }
        catch
        {

        }*/


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
                    dPicker.Value = DateTime.Now; //Yukarýdaki gibi dönüþtürmek yerine bu þekilde yapabiliriz.
                }
                else if (item is CheckBox cBox)
                {
                    cBox.Checked = false;
                }
                else if (item is ComboBox combox)
                {
                    combox.SelectedIndex = -1;
                }
                /* else if (item is ListBox listBox)
                 {
                     listBox.SelectedIndex = -1;
                     _araclar = null;
                 }*/
            }
        }

        private MemoryStream _memoryStream = new MemoryStream(); //Ram
        private int _bufeerSize = 64;
        private byte[] _photoBytes = new byte[64];

        private void pctBoxAracFoto_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoðraf dosyasý seçiniz";
            dosyaAc.Filter = "JPG Dosyalarý (*.jpg)|*.jpg";
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //bilgisayardaki yere eriþim

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(_photoBytes, 0, _bufeerSize) != 0)
                {
                    _memoryStream.Write(_photoBytes, 0, _bufeerSize);
                }
                fileStream.Close();
                fileStream.Dispose(); //temizle

                // pictureBox2.Image = Image.FromStream(_memoryStream);
                pctBoxAracFoto.Image = new Bitmap(_memoryStream); //Yukarýdak ile ayný iþlevde 


            }
        }


        private void lstBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxListe.SelectedItem == null)
            {
                _arac = null;
                return;
            }

            _arac = lstBoxListe.SelectedItem as Arac;

            textBoxModel.Text = _arac.Model;
            textBoxMarka.Text = _arac.Marka;
            textBoxModelyili.Text = _arac.ModelYili;
            textBoxMotorHacmi.Text = _arac.MotorHacmi;
            textBoxSaseNo.Text = _arac.SaseNo;
            textBoxVites.Text = _arac.VitesTipi;
            textBoxYakitTipi.Text = _arac.YakitTipi;

            pctBoxAracFoto.Image = _arac.Fotograf != null ? Image.FromStream(new MemoryStream(_arac.Fotograf)) : null;

        }



        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstBoxListe.SelectedItem == null) return;

            var seciliArac = lstBoxListe.SelectedItem as Arac;
            DialogResult result = MessageBox.Show($"{seciliArac.Model} aracýný silmek istiyor musunuz ", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //  lstKisiler.Items.Remove(seciliKisi);
                _araclar.Remove(seciliArac);
                lstBoxListe.DataSource = null;
                lstBoxListe.DataSource = _araclar;
                FormuTemizle();
            }
        }

        private void güncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Güncelleme iþlemi
                _arac.Marka = textBoxMarka.Text;
                _arac.Model = textBoxModel.Text;
                _arac.ModelYili = textBoxModelyili.Text;
                _arac.YakitTipi = textBoxYakitTipi.Text;
                _arac.MotorHacmi = textBoxMotorHacmi.Text;
                _arac.VitesTipi = textBoxVites.Text;
                _arac.SaseNo = textBoxSaseNo.Text;

                if (_memoryStream.Length > 0)
                {
                    _arac.Fotograf = _memoryStream.ToArray();

                }
                FormuTemizle();
                btnKayit.Text = "Kaydet";
                _arac = null;
                lstBoxListe.DataSource = null;
                lstBoxListe.DataSource = _araclar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu!!!! {ex.Message}");

            }
        }
    }
}