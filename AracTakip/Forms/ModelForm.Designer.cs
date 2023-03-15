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
            txtGuncelle = new Button();
            btnKaydet = new Button();
            lstList = new ListBox();
            lbl = new Label();
            label1 = new Label();
            lblModel = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            cmbKasaTipi = new ComboBox();
            cmbMarka = new ComboBox();
            SuspendLayout();
            // 
            // txtGuncelle
            // 
            txtGuncelle.BackColor = Color.RosyBrown;
            txtGuncelle.BackgroundImageLayout = ImageLayout.Center;
            txtGuncelle.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGuncelle.Location = new Point(304, 343);
            txtGuncelle.Name = "txtGuncelle";
            txtGuncelle.Size = new Size(86, 32);
            txtGuncelle.TabIndex = 7;
            txtGuncelle.Text = "Güncelle";
            txtGuncelle.UseVisualStyleBackColor = false;
            txtGuncelle.Click += txtGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.RosyBrown;
            btnKaydet.BackgroundImageLayout = ImageLayout.Center;
            btnKaydet.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(185, 343);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(86, 32);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 15;
            lstList.Location = new Point(456, 36);
            lstList.Name = "lstList";
            lstList.Size = new Size(242, 379);
            lstList.TabIndex = 9;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(99, 40);
            lbl.Name = "lbl";
            lbl.Size = new Size(61, 17);
            lbl.TabIndex = 5;
            lbl.Text = "Marka :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 10;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.Location = new Point(74, 97);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(86, 17);
            lblModel.TabIndex = 11;
            lblModel.Text = "Model Adı :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(185, 88);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(205, 23);
            txtAd.TabIndex = 13;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 144);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 14;
            label2.Text = "Kasa Tipi :";
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(185, 140);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(205, 23);
            cmbKasaTipi.TabIndex = 15;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(185, 39);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(205, 23);
            cmbMarka.TabIndex = 16;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMarka);
            Controls.Add(cmbKasaTipi);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(lblModel);
            Controls.Add(label1);
            Controls.Add(txtGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstList);
            Controls.Add(lbl);
            Name = "ModelForm";
            Text = "ModelForm";
            Load += ModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
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