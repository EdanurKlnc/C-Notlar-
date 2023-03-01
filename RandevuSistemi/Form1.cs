namespace RandevuSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            flw1.Controls.Clear();
            for (int saat = 9; saat < 18; saat++)
            {
                if (saat == 12)
                {
                    continue;
                }
                for (int dakika = 0; dakika < 46; dakika += 15)
                {
                    int sonrakiSaat = saat;
                    int sonrakiDakika = dakika + 15;
                    if (sonrakiDakika == 60)
                    {
                        sonrakiDakika = 0;
                        sonrakiSaat++;
                    }
                    // Console.WriteLine($"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika:00}");
                    string btnText = $"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika:00}";
                    Button yeniButon = ButonUret(btnText);
                    flw1.Controls.Add(yeniButon);
                }
            }
        }

        private Button ButonUret(string btnText)
        {
            Button btn = new Button() //Buton oluþtur
            {
                Text = btnText,
                Size = new Size(66, 60),
            };

            btn.Click += BtnMesaiSaat_Click; // () olmadýðý zaman metotu tanýmlamýþ oluyorsun.() eklersek                                        metotu çaðýrmýþ oluyorsun 
            return btn;
        }

        private void BtnMesaiSaat_Click(object? sender, EventArgs e) //Metot
        {
            Button basilanButon = (Button)sender;
            this.Text = basilanButon.Text;

        }
    }
}