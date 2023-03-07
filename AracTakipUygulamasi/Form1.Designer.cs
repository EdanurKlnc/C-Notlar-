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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSase = new System.Windows.Forms.Label();
            this.lblYakitTipi = new System.Windows.Forms.Label();
            this.lblVitesTipi = new System.Windows.Forms.Label();
            this.lblMotorHacmi = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYakitTipi = new System.Windows.Forms.TextBox();
            this.textBoxVites = new System.Windows.Forms.TextBox();
            this.textBoxMotorHacmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFotograf = new System.Windows.Forms.Label();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstBoxListe = new System.Windows.Forms.ListBox();
            this.lblModelYili = new System.Windows.Forms.Label();
            this.textBoxModelyili = new System.Windows.Forms.TextBox();
            this.textBoxSaseNo = new System.Windows.Forms.TextBox();
            this.pctBoxAracFoto = new System.Windows.Forms.PictureBox();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAracFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.White;
            this.btnKayit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayit.Location = new System.Drawing.Point(381, 330);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(159, 42);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.Color.White;
            this.lblMarka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarka.ForeColor = System.Drawing.Color.Black;
            this.lblMarka.Location = new System.Drawing.Point(75, 101);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(65, 19);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Marka :";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(78, 143);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(62, 19);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model :";
            // 
            // lblSase
            // 
            this.lblSase.AutoSize = true;
            this.lblSase.BackColor = System.Drawing.Color.White;
            this.lblSase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSase.ForeColor = System.Drawing.Color.Black;
            this.lblSase.Location = new System.Drawing.Point(66, 227);
            this.lblSase.Name = "lblSase";
            this.lblSase.Size = new System.Drawing.Size(74, 19);
            this.lblSase.TabIndex = 3;
            this.lblSase.Text = "Şase No :";
            // 
            // lblYakitTipi
            // 
            this.lblYakitTipi.AutoSize = true;
            this.lblYakitTipi.BackColor = System.Drawing.Color.White;
            this.lblYakitTipi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYakitTipi.ForeColor = System.Drawing.Color.Black;
            this.lblYakitTipi.Location = new System.Drawing.Point(58, 269);
            this.lblYakitTipi.Name = "lblYakitTipi";
            this.lblYakitTipi.Size = new System.Drawing.Size(82, 19);
            this.lblYakitTipi.TabIndex = 4;
            this.lblYakitTipi.Text = "Yakıt Tipi :";
            // 
            // lblVitesTipi
            // 
            this.lblVitesTipi.AutoSize = true;
            this.lblVitesTipi.BackColor = System.Drawing.Color.White;
            this.lblVitesTipi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVitesTipi.ForeColor = System.Drawing.Color.Black;
            this.lblVitesTipi.Location = new System.Drawing.Point(58, 311);
            this.lblVitesTipi.Name = "lblVitesTipi";
            this.lblVitesTipi.Size = new System.Drawing.Size(82, 19);
            this.lblVitesTipi.TabIndex = 5;
            this.lblVitesTipi.Text = "Vites Tipi :";
            // 
            // lblMotorHacmi
            // 
            this.lblMotorHacmi.AutoSize = true;
            this.lblMotorHacmi.BackColor = System.Drawing.Color.White;
            this.lblMotorHacmi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotorHacmi.ForeColor = System.Drawing.Color.Black;
            this.lblMotorHacmi.Location = new System.Drawing.Point(32, 353);
            this.lblMotorHacmi.Name = "lblMotorHacmi";
            this.lblMotorHacmi.Size = new System.Drawing.Size(108, 19);
            this.lblMotorHacmi.TabIndex = 6;
            this.lblMotorHacmi.Text = "Motor Hacmi :";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(157, 101);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(159, 23);
            this.textBoxMarka.TabIndex = 7;
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(157, 143);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(159, 23);
            this.textBoxModel.TabIndex = 8;
            // 
            // textBoxYakitTipi
            // 
            this.textBoxYakitTipi.Location = new System.Drawing.Point(157, 265);
            this.textBoxYakitTipi.Name = "textBoxYakitTipi";
            this.textBoxYakitTipi.Size = new System.Drawing.Size(159, 23);
            this.textBoxYakitTipi.TabIndex = 9;
            // 
            // textBoxVites
            // 
            this.textBoxVites.Location = new System.Drawing.Point(157, 307);
            this.textBoxVites.Name = "textBoxVites";
            this.textBoxVites.Size = new System.Drawing.Size(159, 23);
            this.textBoxVites.TabIndex = 10;
            // 
            // textBoxMotorHacmi
            // 
            this.textBoxMotorHacmi.Location = new System.Drawing.Point(157, 349);
            this.textBoxMotorHacmi.Name = "textBoxMotorHacmi";
            this.textBoxMotorHacmi.Size = new System.Drawing.Size(159, 23);
            this.textBoxMotorHacmi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "ARAÇ TAKİP";
            // 
            // lblFotograf
            // 
            this.lblFotograf.AutoSize = true;
            this.lblFotograf.BackColor = System.Drawing.Color.White;
            this.lblFotograf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFotograf.Location = new System.Drawing.Point(358, 174);
            this.lblFotograf.Name = "lblFotograf";
            this.lblFotograf.Size = new System.Drawing.Size(240, 17);
            this.lblFotograf.TabIndex = 14;
            this.lblFotograf.Text = "Araç Fotoğrafı Eklemek İçin Tıklayınız";
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.cmsSil.Name = "contextMenuStrip1";
            this.cmsSil.Size = new System.Drawing.Size(181, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click_1);
            // 
            // lstBoxListe
            // 
            this.lstBoxListe.BackColor = System.Drawing.Color.White;
            this.lstBoxListe.ContextMenuStrip = this.cmsSil;
            this.lstBoxListe.FormattingEnabled = true;
            this.lstBoxListe.ItemHeight = 15;
            this.lstBoxListe.Location = new System.Drawing.Point(633, 101);
            this.lstBoxListe.Name = "lstBoxListe";
            this.lstBoxListe.Size = new System.Drawing.Size(257, 169);
            this.lstBoxListe.TabIndex = 15;
            this.lstBoxListe.SelectedIndexChanged += new System.EventHandler(this.lstBoxListe_SelectedIndexChanged);
            // 
            // lblModelYili
            // 
            this.lblModelYili.AutoSize = true;
            this.lblModelYili.BackColor = System.Drawing.Color.White;
            this.lblModelYili.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelYili.Location = new System.Drawing.Point(58, 185);
            this.lblModelYili.Name = "lblModelYili";
            this.lblModelYili.Size = new System.Drawing.Size(87, 19);
            this.lblModelYili.TabIndex = 16;
            this.lblModelYili.Text = "Model Yılı :";
            // 
            // textBoxModelyili
            // 
            this.textBoxModelyili.Location = new System.Drawing.Point(157, 185);
            this.textBoxModelyili.Name = "textBoxModelyili";
            this.textBoxModelyili.Size = new System.Drawing.Size(159, 23);
            this.textBoxModelyili.TabIndex = 17;
            // 
            // textBoxSaseNo
            // 
            this.textBoxSaseNo.Location = new System.Drawing.Point(157, 223);
            this.textBoxSaseNo.Name = "textBoxSaseNo";
            this.textBoxSaseNo.Size = new System.Drawing.Size(159, 23);
            this.textBoxSaseNo.TabIndex = 18;
            // 
            // pctBoxAracFoto
            // 
            this.pctBoxAracFoto.BackColor = System.Drawing.Color.White;
            this.pctBoxAracFoto.Location = new System.Drawing.Point(348, 101);
            this.pctBoxAracFoto.Name = "pctBoxAracFoto";
            this.pctBoxAracFoto.Size = new System.Drawing.Size(267, 167);
            this.pctBoxAracFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAracFoto.TabIndex = 12;
            this.pctBoxAracFoto.TabStop = false;
            this.pctBoxAracFoto.Click += new System.EventHandler(this.pctBoxAracFoto_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "dosya";
            // 
            // dosyaKaydet
            // 
            this.dosyaKaydet.FileName = "dosyaKaydet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.textBoxSaseNo);
            this.Controls.Add(this.textBoxModelyili);
            this.Controls.Add(this.lblModelYili);
            this.Controls.Add(this.lstBoxListe);
            this.Controls.Add(this.lblFotograf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBoxAracFoto);
            this.Controls.Add(this.textBoxMotorHacmi);
            this.Controls.Add(this.textBoxVites);
            this.Controls.Add(this.textBoxYakitTipi);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.lblMotorHacmi);
            this.Controls.Add(this.lblVitesTipi);
            this.Controls.Add(this.lblYakitTipi);
            this.Controls.Add(this.lblSase);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.btnKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAracFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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