using AracTakip.Data;
using AracTakip.Helpers;

namespace AracTakip.Forms
{
    public partial class MarkaForm : Form
    {
        public MarkaForm()
        {
            InitializeComponent();
        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
            lstList.DataSource = DataContext.Markalar;
        }
        public EnvanterContext DataContext { get; set; }
        //public List<Marka> Liste { get; set; } = new();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Marka marka = new Marka()
                {
                    Ad = txtAd.Text,

                };
                if (pbResim.Image != null)
                {
                    marka.Logo = (byte[])(new ImageConverter().ConvertTo(pbResim.Image, typeof(byte[])));
                }
                DataContext.Markalar.Add(marka);
                lstList.DataSource = null;
                lstList.DataSource = DataContext.Markalar;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştur: {ex.Message}");
            }
        }
        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            dosyaAc.Title = "resim seciniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "JPG Dosyaları (*.jpg)|*.jpg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(dosyaAc.FileName);
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null)
            {
                return;
            }
            Marka seciliMarka = (Marka)lstList.SelectedItem;
            txtAd.Text = seciliMarka.Ad;

            if (seciliMarka.Logo != null)
            {
                pbResim.Image = (Image)(new ImageConverter().ConvertFrom(seciliMarka.Logo));
            }

        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null)
            {
                return;
            }
            Marka seciliMarka = (Marka)lstList.SelectedItem;
            try
            {
                seciliMarka.Ad = txtAd.Text;
                if (pbResim.Image != null)
                {
                    pbResim.Image = (Image)(new ImageConverter().ConvertFrom(seciliMarka.Logo));

                }
                lstList.DataSource = null;
                lstList.DataSource = DataContext.Markalar;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştur: {ex.Message}");
            }
        }
    }
}
