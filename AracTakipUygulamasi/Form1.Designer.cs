namespace AracTakipUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnKayit = new Button();
            lblMarka = new Label();
            lblModel = new Label();
            lblSase = new Label();
            lblYakitTipi = new Label();
            lblVitesTipi = new Label();
            lblMotorHacmi = new Label();
            textBoxMarka = new TextBox();
            textBoxModel = new TextBox();
            textBoxYakitTipi = new TextBox();
            textBoxVites = new TextBox();
            textBoxMotorHacmi = new TextBox();
            label1 = new Label();
            lblFotograf = new Label();
            cmsSil = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            lstBoxListe = new ListBox();
            lblModelYili = new Label();
            textBoxModelyili = new TextBox();
            textBoxSaseNo = new TextBox();
            pctBoxAracFoto = new PictureBox();
            dosyaAc = new OpenFileDialog();
            dosyaKaydet = new SaveFileDialog();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBoxAracFoto).BeginInit();
            SuspendLayout();
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.White;
            btnKayit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayit.Location = new Point(381, 330);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(159, 42);
            btnKayit.TabIndex = 0;
            btnKayit.Text = "Kaydet";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.BackColor = Color.White;
            lblMarka.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMarka.ForeColor = Color.Black;
            lblMarka.Location = new Point(75, 101);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(65, 19);
            lblMarka.TabIndex = 1;
            lblMarka.Text = "Marka :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = Color.White;
            lblModel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.ForeColor = Color.Black;
            lblModel.Location = new Point(78, 143);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(62, 19);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model :";
            // 
            // lblSase
            // 
            lblSase.AutoSize = true;
            lblSase.BackColor = Color.White;
            lblSase.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSase.ForeColor = Color.Black;
            lblSase.Location = new Point(66, 227);
            lblSase.Name = "lblSase";
            lblSase.Size = new Size(74, 19);
            lblSase.TabIndex = 3;
            lblSase.Text = "Şase No :";
            // 
            // lblYakitTipi
            // 
            lblYakitTipi.AutoSize = true;
            lblYakitTipi.BackColor = Color.White;
            lblYakitTipi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYakitTipi.ForeColor = Color.Black;
            lblYakitTipi.Location = new Point(58, 269);
            lblYakitTipi.Name = "lblYakitTipi";
            lblYakitTipi.Size = new Size(82, 19);
            lblYakitTipi.TabIndex = 4;
            lblYakitTipi.Text = "Yakıt Tipi :";
            // 
            // lblVitesTipi
            // 
            lblVitesTipi.AutoSize = true;
            lblVitesTipi.BackColor = Color.White;
            lblVitesTipi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVitesTipi.ForeColor = Color.Black;
            lblVitesTipi.Location = new Point(58, 311);
            lblVitesTipi.Name = "lblVitesTipi";
            lblVitesTipi.Size = new Size(82, 19);
            lblVitesTipi.TabIndex = 5;
            lblVitesTipi.Text = "Vites Tipi :";
            // 
            // lblMotorHacmi
            // 
            lblMotorHacmi.AutoSize = true;
            lblMotorHacmi.BackColor = Color.White;
            lblMotorHacmi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMotorHacmi.ForeColor = Color.Black;
            lblMotorHacmi.Location = new Point(32, 353);
            lblMotorHacmi.Name = "lblMotorHacmi";
            lblMotorHacmi.Size = new Size(108, 19);
            lblMotorHacmi.TabIndex = 6;
            lblMotorHacmi.Text = "Motor Hacmi :";
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(157, 101);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(159, 23);
            textBoxMarka.TabIndex = 7;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(157, 143);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(159, 23);
            textBoxModel.TabIndex = 8;
            // 
            // textBoxYakitTipi
            // 
            textBoxYakitTipi.Location = new Point(157, 265);
            textBoxYakitTipi.Name = "textBoxYakitTipi";
            textBoxYakitTipi.Size = new Size(159, 23);
            textBoxYakitTipi.TabIndex = 9;
            // 
            // textBoxVites
            // 
            textBoxVites.Location = new Point(157, 307);
            textBoxVites.Name = "textBoxVites";
            textBoxVites.Size = new Size(159, 23);
            textBoxVites.TabIndex = 10;
            // 
            // textBoxMotorHacmi
            // 
            textBoxMotorHacmi.Location = new Point(157, 349);
            textBoxMotorHacmi.Name = "textBoxMotorHacmi";
            textBoxMotorHacmi.Size = new Size(159, 23);
            textBoxMotorHacmi.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(370, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 13;
            label1.Text = "ARAÇ TAKİP";
            // 
            // lblFotograf
            // 
            lblFotograf.AutoSize = true;
            lblFotograf.BackColor = Color.White;
            lblFotograf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFotograf.Location = new Point(358, 174);
            lblFotograf.Name = "lblFotograf";
            lblFotograf.Size = new Size(240, 17);
            lblFotograf.TabIndex = 14;
            lblFotograf.Text = "Araç Fotoğrafı Eklemek İçin Tıklayınız";
            // 
            // cmsSil
            // 
            cmsSil.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            cmsSil.Name = "contextMenuStrip1";
            cmsSil.Size = new Size(181, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ekleToolStripMenuItem, silToolStripMenuItem, güncelleToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(180, 22);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(180, 22);
            ekleToolStripMenuItem.Text = "Ekle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(180, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click_1;
            // 
            // lstBoxListe
            // 
            lstBoxListe.BackColor = Color.White;
            lstBoxListe.ContextMenuStrip = cmsSil;
            lstBoxListe.FormattingEnabled = true;
            lstBoxListe.ItemHeight = 15;
            lstBoxListe.Location = new Point(633, 101);
            lstBoxListe.Name = "lstBoxListe";
            lstBoxListe.Size = new Size(257, 169);
            lstBoxListe.TabIndex = 15;
            lstBoxListe.SelectedIndexChanged += lstBoxListe_SelectedIndexChanged;
            // 
            // lblModelYili
            // 
            lblModelYili.AutoSize = true;
            lblModelYili.BackColor = Color.White;
            lblModelYili.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelYili.Location = new Point(58, 185);
            lblModelYili.Name = "lblModelYili";
            lblModelYili.Size = new Size(87, 19);
            lblModelYili.TabIndex = 16;
            lblModelYili.Text = "Model Yılı :";
            // 
            // textBoxModelyili
            // 
            textBoxModelyili.Location = new Point(157, 185);
            textBoxModelyili.Name = "textBoxModelyili";
            textBoxModelyili.Size = new Size(159, 23);
            textBoxModelyili.TabIndex = 17;
            // 
            // textBoxSaseNo
            // 
            textBoxSaseNo.Location = new Point(157, 223);
            textBoxSaseNo.Name = "textBoxSaseNo";
            textBoxSaseNo.Size = new Size(159, 23);
            textBoxSaseNo.TabIndex = 18;
            // 
            // pctBoxAracFoto
            // 
            pctBoxAracFoto.BackColor = Color.White;
            pctBoxAracFoto.Location = new Point(348, 101);
            pctBoxAracFoto.Name = "pctBoxAracFoto";
            pctBoxAracFoto.Size = new Size(267, 167);
            pctBoxAracFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBoxAracFoto.TabIndex = 12;
            pctBoxAracFoto.TabStop = false;
            pctBoxAracFoto.Click += pctBoxAracFoto_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosya";
            // 
            // dosyaKaydet
            // 
            dosyaKaydet.FileName = "dosyaKaydet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(140, 15, 30);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(913, 450);
            Controls.Add(textBoxSaseNo);
            Controls.Add(textBoxModelyili);
            Controls.Add(lblModelYili);
            Controls.Add(lstBoxListe);
            Controls.Add(lblFotograf);
            Controls.Add(label1);
            Controls.Add(pctBoxAracFoto);
            Controls.Add(textBoxMotorHacmi);
            Controls.Add(textBoxVites);
            Controls.Add(textBoxYakitTipi);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxMarka);
            Controls.Add(lblMotorHacmi);
            Controls.Add(lblVitesTipi);
            Controls.Add(lblYakitTipi);
            Controls.Add(lblSase);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Controls.Add(btnKayit);
            Name = "Form1";
            Text = "Form1";
            cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBoxAracFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayit;
        private Label lblMarka;
        private Label lblModel;
        private Label lblSase;
        private Label lblYakitTipi;
        private Label lblVitesTipi;
        private Label lblMotorHacmi;
        private TextBox textBoxMarka;
        private TextBox textBoxModel;
        private TextBox textBoxYakitTipi;
        private TextBox textBoxVites;
        private TextBox textBoxMotorHacmi;
        private Label label1;
        private Label lblFotograf;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ListBox lstBoxListe;
        private Label lblModelYili;
        private TextBox textBoxModelyili;
        private TextBox textBoxSaseNo;
        private PictureBox pctBoxAracFoto;
        private OpenFileDialog dosyaAc;
        private SaveFileDialog dosyaKaydet;
    }
}