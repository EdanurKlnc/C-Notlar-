using InterfaceOdemeSistemi.Entities;
using InterfaceOrnek_Odeme.Entities;

namespace InterfaceOdemeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKrediKartiOde_Click(object sender, EventArgs e)
        {
            KrediKartiylaOdeme odeme = new KrediKartiylaOdeme();

            odeme.OdenecekTutar = Convert.ToDecimal(lblTutar.Text);
            odeme.KartSahibi = txtKartSahibi.Text;
            odeme.KartNumarasi = maskedtxtKartNo.Text;
            odeme.SonKullanimYil = Convert.ToByte(kartSonYil.Text);
            odeme.SonKullanimAy = Convert.ToByte(kartSonAy.Text);
            odeme.CVC = Convert.ToInt32(txtCvc.Text);


            MessageBox.Show(odeme.OdemeYap());
            groupBoxKrediKartiTemizle();

        }

        private void checkBoxKapidaOdeme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKapidaOdeme.Checked)

            {
                checkBoxCuzdan.Checked = false;
                checkBoxKK.Checked = false;
                checkBoxCuzdan.Enabled = false;
                checkBoxKK.Enabled = false;

            }
            else
            {
                checkBoxKK.Enabled = true;
                checkBoxCuzdan.Enabled = true;
            }
        }

        private void checkBoxKK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKK.Checked)

            {
                groupBoxKrediKarti.Visible = true;
                checkBoxCuzdan.Checked = false;
                checkBoxKapidaOdeme.Checked = false;
                checkBoxCuzdan.Enabled = false;
                checkBoxKapidaOdeme.Enabled = false;

            }
            else
            {
                groupBoxKrediKarti.Visible = false;
                checkBoxKapidaOdeme.Enabled = true;
                checkBoxCuzdan.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTutar.Text = rnd.Next(1000, 5000).ToString();
            groupBoxKrediKarti.Visible = false;
            kartSonAy.Minimum = 1;
            kartSonAy.Maximum = 12;
        }
        private void groupBoxKrediKartiTemizle()
        {
            txtKartSahibi.Clear();
            txtCvc.Clear();
            kartSonAy.Value = kartSonAy.Minimum;
            kartSonYil.Clear();
            maskedtxtKartNo.Clear();


        }
    }
}