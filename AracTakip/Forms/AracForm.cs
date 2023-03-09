using AracTakip.Data;
using AracTakip.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip.Forms
{
    public partial class AracForm : Form
    {
        public AracForm()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }
        private void AracForm_Load(object sender, EventArgs e)
        {
            cmbMarka.DataSource = DataContext.Markalar; //markaları gösteriyoruz
            lstListe.DataSource = DataContext.Araclar;

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedIndex == -1) return;
            Marka seciliMarka = (Marka)cmbMarka.SelectedItem;
            cmbModel.DataSource = DataContext.Modeller
                .Where(x => x.Marka.Id == seciliMarka.Id) //sadece secili markanı modellerini getiriyoruz
                .ToList();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                Arac arac = new Arac() //Arac sınıfına ToString ile ekrana yazdırma işlemini yapmamız gerekiyor
                {
                    Plaka = txtPlaka.Text,
                    Model = (Model)cmbModel.SelectedItem
                };
                DataContext.Araclar.Add(arac);
                lstListe.DataSource = null;
                lstListe.DataSource = DataContext.Araclar;
                DataHelper.Save(DataContext);
                this.FormCleaner(Controls); //extention methot oluşturup burada kullanıyoruz.


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hataa : {ex.Message}");
            }
        }
        private void Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return;
            Arac seciliArac = (Arac)lstListe.SelectedItem;
            txtPlaka.Text = seciliArac.Plaka;


            //Find bulamadığı zaman null döndürür. Var olduğuna emin olmadığımız kayıtlarda kullanırız
            //First bulamazsa hata verir. Mutlaka olan kayıtlarda kullanıyoruz. 
            cmbMarka.SelectedItem =DataContext.Markalar.First(x => x.Id == seciliArac.Model.Marka.Id);

            cmbModel.SelectedItem = DataContext.Modeller.First(x => x.Id == seciliArac.Model.Id);
        }

        private void btnGuncele_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return;
            Arac seciliArac = (Arac)lstListe.SelectedItem;
            seciliArac.Plaka = txtPlaka.Text;
            seciliArac.Model = (Model)cmbModel.SelectedItem;

            lstListe.DataSource = null;
            lstListe.DataSource = DataContext.Araclar;
            DataHelper.Save(DataContext);
            this.FormCleaner(Controls);




        }
    }
}
