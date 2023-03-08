
using AracTakip.Data;
using AracTakip.Helpers;

namespace AracTakip.Forms
{
    public partial class ModelForm : Form
    {
        public ModelForm()
        {
            InitializeComponent();
        }

        public EnvanterContext DataContext { get; set; }

       // public List<Marka> Markalar { get; set; } = new();

        // public List<Model> Liste { get; set; } = new();
        private void ModelForm_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Enum.GetNames(typeof(KasaTipleri));
            cmbMarka.DataSource = DataContext.Markalar;
            lstList.DataSource = DataContext.Modeller;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Model model = new()
                {
                    Ad = txtAd.Text,
                    KasaTipleri = (KasaTipleri)Enum.Parse(typeof(KasaTipleri),
                    cmbKasaTipi.SelectedItem.ToString()),
                    Marka = (Marka)cmbKasaTipi.SelectedItem
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show($"hata : {ex.Message}");
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null) return;
            Model model = (Model)lstList.SelectedItem;
            txtAd.Text = model.Ad;
            cmbKasaTipi.SelectedItem = Enum.Parse(typeof(KasaTipleri), model.KasaTipleri.ToString());
            cmbKasaTipi.SelectedItem = model.Marka;
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null) return;
            Model model = (Model)lstList.SelectedItem;
            model.Ad = txtAd.Text;
            model.KasaTipleri = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), model.KasaTipleri.ToString());
            model.Marka = (Marka)cmbMarka.SelectedItem;
            lstList.DataSource = null;
            lstList.DataSource = DataContext.Modeller;
            DataHelper.Save(DataContext);

        }
    }
}
