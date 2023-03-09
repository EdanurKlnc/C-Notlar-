
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
                    KasaTipleri = (KasaTipleri)Enum.Parse(typeof(KasaTipleri), cmbKasaTipi.SelectedItem.ToString()),
                    Marka = (Marka)cmbMarka.SelectedItem
                };

                DataContext.Modeller.Add(model);
                lstList.DataSource = null;
                lstList.DataSource = DataContext.Modeller;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstList.SelectedItem == null) return;
            Model model = (Model)lstList.SelectedItem;
            txtAd.Text = model.Ad;
            cmbKasaTipi.SelectedItem = Enum.GetName(typeof(KasaTipleri), model.KasaTipleri);
            cmbMarka.SelectedItem = DataContext.Markalar.Find(x => x.Id == model.Marka.Id);
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
            this.FormCleaner(Controls);


        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
