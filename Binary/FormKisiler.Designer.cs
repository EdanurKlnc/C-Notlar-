namespace WFormGiris
{
    partial class FormKisiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAd = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblTc = new Label();
            lblTelefon = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTc = new TextBox();
            txtTelefonNo = new TextBox();
            btnKayit = new Button();
            lstKisiler = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem1 = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            dtpDogumTarihi = new DateTimePicker();
            txtAra = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dosyaAc = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            dosyaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            dışarıAktarToolStripMenuItem = new ToolStripMenuItem();
            içeriAktarToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydet = new SaveFileDialog();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(58, 76);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad :";
            lblAd.Click += label1_Click;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Location = new Point(44, 132);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(84, 15);
            lblDogumTarihi.TabIndex = 6;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            lblDogumTarihi.Click += label2_Click;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(58, 105);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(45, 15);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad :";
            lblSoyad.Click += label3_Click;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(58, 163);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(26, 15);
            lblTc.TabIndex = 8;
            lblTc.Text = "TC :";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(58, 192);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(70, 15);
            lblTelefon.TabIndex = 12;
            lblTelefon.Text = "Telefon No :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(130, 68);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(145, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(130, 97);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(145, 23);
            txtSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(130, 155);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(145, 23);
            txtTc.TabIndex = 9;
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Location = new Point(130, 184);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(145, 23);
            txtTelefonNo.TabIndex = 13;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(130, 318);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(145, 46);
            btnKayit.TabIndex = 3;
            btnKayit.Text = "Kaydet";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // lstKisiler
            // 
            lstKisiler.ContextMenuStrip = contextMenuStrip1;
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(332, 105);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(157, 259);
            lstKisiler.TabIndex = 4;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silToolStripMenuItem1, güncelleToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(180, 22);
            düzenleToolStripMenuItem.Text = "Düzenle";
            düzenleToolStripMenuItem.Click += düzenleToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem1
            // 
            silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            silToolStripMenuItem1.Size = new Size(180, 22);
            silToolStripMenuItem1.Text = "Sil";
            silToolStripMenuItem1.Click += silToolStripMenuItem1_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(180, 22);
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(130, 126);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(145, 23);
            dtpDogumTarihi.TabIndex = 7;
            dtpDogumTarihi.ValueChanged += dtpDogumTarihi_ValueChanged;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(332, 68);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(157, 23);
            txtAra.TabIndex = 14;
            txtAra.TextChanged += txtAra_TextChanged;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(129, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 272);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 17;
            label1.Text = "Fotoğraf :";
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosya";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(595, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem });
            dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            dosyaİşlemleriToolStripMenuItem.Size = new Size(98, 20);
            dosyaİşlemleriToolStripMenuItem.Text = "&Dosya İşlemleri";
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dışarıAktarToolStripMenuItem, içeriAktarToolStripMenuItem });
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(98, 22);
            xMLToolStripMenuItem.Text = "XML";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            dışarıAktarToolStripMenuItem.Size = new Size(134, 22);
            dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            dışarıAktarToolStripMenuItem.Click += dışarıAktarToolStripMenuItem_Click;
            // 
            // içeriAktarToolStripMenuItem
            // 
            içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            içeriAktarToolStripMenuItem.Size = new Size(134, 22);
            içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            // 
            // FormKisiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(595, 450);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtAra);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lstKisiler);
            Controls.Add(btnKayit);
            Controls.Add(txtTelefonNo);
            Controls.Add(txtTc);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblTelefon);
            Controls.Add(lblTc);
            Controls.Add(lblSoyad);
            Controls.Add(lblDogumTarihi);
            Controls.Add(lblAd);
            MainMenuStrip = menuStrip1;
            Name = "FormKisiler";
            Text = "FormKisiler";
            Load += FormKisiler_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblTc;
        private Label lblTelefon;
        private Label lblMail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTc;
        private TextBox txtTelefonNo;
        private TextBox txtMail;
        private Button btnKayit;
        private ListBox lstKisiler;
        private DateTimePicker dtpDogumTarihi;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem1;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private TextBox txtAra;
        private PictureBox pictureBox2;
        private Label label1;
        private OpenFileDialog dosyaAc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private ToolStripMenuItem içeriAktarToolStripMenuItem;
        private SaveFileDialog dosyaKaydet;
    }
}