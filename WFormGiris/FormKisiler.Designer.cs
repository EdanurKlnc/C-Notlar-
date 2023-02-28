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
            this.components = new System.ComponentModel.Container();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(26, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(28, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            this.lblAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 84);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(84, 15);
            this.lblDogumTarihi.TabIndex = 6;
            this.lblDogumTarihi.Text = "Doğum Tarihi :";
            this.lblDogumTarihi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(26, 57);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(45, 15);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad :";
            this.lblSoyad.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(26, 115);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(26, 15);
            this.lblTc.TabIndex = 8;
            this.lblTc.Text = "TC :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(26, 144);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(70, 15);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Telefon No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(98, 107);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 9;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(98, 136);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(100, 23);
            this.txtTelefonNo.TabIndex = 13;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(84, 270);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(127, 46);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lstKisiler
            // 
            this.lstKisiler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 15;
            this.lstKisiler.Location = new System.Drawing.Point(300, 57);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(157, 259);
            this.lstKisiler.TabIndex = 4;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.güncelleToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(98, 78);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(100, 23);
            this.dtpDogumTarihi.TabIndex = 7;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(300, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(157, 23);
            this.txtAra.TabIndex = 14;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // FormKisiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblAd);
            this.Name = "FormKisiler";
            this.Text = "FormKisiler";
            this.Load += new System.EventHandler(this.FormKisiler_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}