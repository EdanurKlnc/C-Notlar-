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
            if(_arac == null)
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

        private void pctBoxAracFoto_Click(object sender, EventArgs e)
        {

        }
    }
}