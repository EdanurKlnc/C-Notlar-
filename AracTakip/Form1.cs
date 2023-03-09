using AracTakip.Data;
using AracTakip.Forms;
using AracTakip.Helpers;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private MarkaForm _markaForm;
        private ModelForm _modelForm;
        private EnvanterContext _dataContext;
        private AracForm _aracForm;
        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_markaForm == null || _markaForm.IsDisposed)
            {
                _markaForm = new MarkaForm();
                _markaForm.MdiParent = this;
                _markaForm.Text = "Marka";
                _markaForm.DataContext = _dataContext;
                _markaForm.Show();
            }

        }


        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_modelForm == null || _modelForm.IsDisposed)
            {
                _modelForm = new ModelForm();
                _modelForm.MdiParent = this;
                _modelForm.Text = "Model Formu";
                _modelForm.DataContext = _dataContext;
                _modelForm.Show();
            }
        }
        private void aracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_aracForm == null || _aracForm.IsDisposed)
            {
                _aracForm = new AracForm();
                _aracForm.MdiParent = this;
                _aracForm.Text = "Araç Formu";
                _aracForm.DataContext = _dataContext;
                _aracForm.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelper.Load();
            _dataContext = data ?? new(); //data katmanýndan sonra JSON dan okuyacaðýz.
        }


    }
}