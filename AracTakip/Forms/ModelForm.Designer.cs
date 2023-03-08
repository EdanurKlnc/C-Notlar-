namespace AracTakip.Forms
{
    partial class ModelForm
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
            this.txtGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.txtGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGuncelle.Location = new System.Drawing.Point(304, 343);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(86, 32);
            this.txtGuncelle.TabIndex = 7;
            this.txtGuncelle.Text = "Güncelle";
            this.txtGuncelle.UseVisualStyleBackColor = false;
            this.txtGuncelle.Click += new System.EventHandler(this.txtGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKaydet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(185, 343);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 32);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 15;
            this.lstList.Location = new System.Drawing.Point(456, 36);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(242, 379);
            this.lstList.TabIndex = 9;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(99, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 17);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Marka :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(74, 97);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(86, 17);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Model Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(185, 88);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 23);
            this.txtAd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kasa Tipi :";
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Location = new System.Drawing.Point(185, 140);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(205, 23);
            this.cmbKasaTipi.TabIndex = 15;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(185, 39);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(205, 23);
            this.cmbMarka.TabIndex = 16;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.cmbKasaTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.lbl);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.Load += new System.EventHandler(this.ModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button txtGuncelle;
        private Button btnKaydet;
        private ListBox lstList;
        private Label lbl;
        private Label label1;
        private Label lblModel;
        private TextBox txtAd;
        private Label label2;
        private ComboBox cmbKasaTipi;
        private ComboBox cmbMarka;
    }
}