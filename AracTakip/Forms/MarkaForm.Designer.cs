namespace AracTakip.Forms
{
    partial class MarkaForm
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtGuncelle = new System.Windows.Forms.Button();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(85, 57);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Marka Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(168, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 23);
            this.txtAd.TabIndex = 0;
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbResim.Location = new System.Drawing.Point(168, 98);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(204, 230);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 15;
            this.lstList.Location = new System.Drawing.Point(439, 54);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(242, 379);
            this.lstList.TabIndex = 3;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKaydet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(168, 361);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 32);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.txtGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGuncelle.Location = new System.Drawing.Point(287, 361);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(86, 32);
            this.txtGuncelle.TabIndex = 2;
            this.txtGuncelle.Text = "Güncelle";
            this.txtGuncelle.UseVisualStyleBackColor = false;
            this.txtGuncelle.Click += new System.EventHandler(this.txtGuncelle_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "dosyaAc";
            // 
            // MarkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lbl);
            this.Name = "MarkaForm";
            this.Text = "MarkaForm";
            this.Load += new System.EventHandler(this.MarkaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl;
        private TextBox txtAd;
        private PictureBox pbResim;
        private ListBox lstList;
        private Button btnKaydet;
        private Button txtGuncelle;
        private OpenFileDialog dosyaAc;
    }
}