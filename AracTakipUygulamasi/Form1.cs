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
            if (_arac == null)
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
                    lstBoxListe.DataSource = _araclar;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    // $=iki string birleþtirirken + yerine kullanýlýr
                    MessageBox.Show($"Bir hata oluþtu!!!! {ex.Message}");

                }
            }
            else
            {
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
                else if (item is ListBox listBox)
                {
                    listBox.SelectedIndex = -1;
                    _araclar = null;
                }
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

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
                lstBoxListe.DataSource = _araclar;
                FormuTemizle();
            }
        }
    }
}