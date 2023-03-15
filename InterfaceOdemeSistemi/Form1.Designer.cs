namespace InterfaceOdemeSistemi
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
            groupBox1 = new GroupBox();
            checkBoxCuzdan = new CheckBox();
            checkBoxKK = new CheckBox();
            checkBoxKapidaOdeme = new CheckBox();
            groupBox2 = new GroupBox();
            lblTutar = new Label();
            label1 = new Label();
            groupBoxKrediKarti = new GroupBox();
            button2 = new Button();
            btnKrediKartiOde = new Button();
            txtCvc = new TextBox();
            label6 = new Label();
            kartSonYil = new TextBox();
            kartSonAy = new NumericUpDown();
            maskedtxtKartNo = new MaskedTextBox();
            txtKartSahibi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxKrediKarti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kartSonAy).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(checkBoxCuzdan);
            groupBox1.Controls.Add(checkBoxKK);
            groupBox1.Controls.Add(checkBoxKapidaOdeme);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(66, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödeme şekli seçiniz :";
            // 
            // checkBoxCuzdan
            // 
            checkBoxCuzdan.AutoSize = true;
            checkBoxCuzdan.Location = new Point(15, 112);
            checkBoxCuzdan.Name = "checkBoxCuzdan";
            checkBoxCuzdan.Size = new Size(142, 21);
            checkBoxCuzdan.TabIndex = 2;
            checkBoxCuzdan.Text = "Cüzdandan Ödeme:";
            checkBoxCuzdan.UseVisualStyleBackColor = true;
            // 
            // checkBoxKK
            // 
            checkBoxKK.AutoSize = true;
            checkBoxKK.Location = new Point(15, 79);
            checkBoxKK.Name = "checkBoxKK";
            checkBoxKK.Size = new Size(89, 21);
            checkBoxKK.TabIndex = 1;
            checkBoxKK.Text = "Kredi Kartı";
            checkBoxKK.UseVisualStyleBackColor = true;
            checkBoxKK.CheckedChanged += checkBoxKK_CheckedChanged;
            // 
            // checkBoxKapidaOdeme
            // 
            checkBoxKapidaOdeme.AutoSize = true;
            checkBoxKapidaOdeme.Location = new Point(15, 46);
            checkBoxKapidaOdeme.Name = "checkBoxKapidaOdeme";
            checkBoxKapidaOdeme.Size = new Size(115, 21);
            checkBoxKapidaOdeme.TabIndex = 0;
            checkBoxKapidaOdeme.Text = "Kapıda Ödeme";
            checkBoxKapidaOdeme.UseVisualStyleBackColor = true;
            checkBoxKapidaOdeme.CheckedChanged += checkBoxKapidaOdeme_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblTutar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(66, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutar.Location = new Point(153, 39);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(44, 20);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "0 lira";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(15, 39);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Ödenecek tutar :";
            // 
            // groupBoxKrediKarti
            // 
            groupBoxKrediKarti.BackColor = Color.FromArgb(192, 192, 255);
            groupBoxKrediKarti.Controls.Add(button2);
            groupBoxKrediKarti.Controls.Add(btnKrediKartiOde);
            groupBoxKrediKarti.Controls.Add(txtCvc);
            groupBoxKrediKarti.Controls.Add(label6);
            groupBoxKrediKarti.Controls.Add(kartSonYil);
            groupBoxKrediKarti.Controls.Add(kartSonAy);
            groupBoxKrediKarti.Controls.Add(maskedtxtKartNo);
            groupBoxKrediKarti.Controls.Add(txtKartSahibi);
            groupBoxKrediKarti.Controls.Add(label5);
            groupBoxKrediKarti.Controls.Add(label4);
            groupBoxKrediKarti.Controls.Add(label3);
            groupBoxKrediKarti.Controls.Add(label2);
            groupBoxKrediKarti.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxKrediKarti.Location = new Point(353, 39);
            groupBoxKrediKarti.Name = "groupBoxKrediKarti";
            groupBoxKrediKarti.Size = new Size(475, 310);
            groupBoxKrediKarti.TabIndex = 2;
            groupBoxKrediKarti.TabStop = false;
            groupBoxKrediKarti.Text = "Kartınıza ait bilgileri giriniz :";
            // 
            // button2
            // 
            button2.Location = new Point(279, 200);
            button2.Name = "button2";
            button2.Size = new Size(20, 23);
            button2.TabIndex = 11;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnKrediKartiOde
            // 
            btnKrediKartiOde.Location = new Point(216, 254);
            btnKrediKartiOde.Name = "btnKrediKartiOde";
            btnKrediKartiOde.Size = new Size(139, 35);
            btnKrediKartiOde.TabIndex = 10;
            btnKrediKartiOde.Text = "Ödeme Yap";
            btnKrediKartiOde.UseVisualStyleBackColor = true;
            btnKrediKartiOde.Click += btnKrediKartiOde_Click;
            // 
            // txtCvc
            // 
            txtCvc.Location = new Point(165, 200);
            txtCvc.Name = "txtCvc";
            txtCvc.Size = new Size(100, 25);
            txtCvc.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 203);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 8;
            label6.Text = "CVC :";
            // 
            // kartSonYil
            // 
            kartSonYil.Location = new Point(291, 147);
            kartSonYil.Name = "kartSonYil";
            kartSonYil.Size = new Size(64, 25);
            kartSonYil.TabIndex = 7;
            // 
            // kartSonAy
            // 
            kartSonAy.Location = new Point(165, 148);
            kartSonAy.Name = "kartSonAy";
            kartSonAy.Size = new Size(44, 25);
            kartSonAy.TabIndex = 6;
            // 
            // maskedtxtKartNo
            // 
            maskedtxtKartNo.Location = new Point(165, 96);
            maskedtxtKartNo.Mask = "0000 0000 0000 0000";
            maskedtxtKartNo.Name = "maskedtxtKartNo";
            maskedtxtKartNo.Size = new Size(224, 25);
            maskedtxtKartNo.TabIndex = 5;
            // 
            // txtKartSahibi
            // 
            txtKartSahibi.Location = new Point(165, 50);
            txtKartSahibi.Name = "txtKartSahibi";
            txtKartSahibi.Size = new Size(224, 25);
            txtKartSahibi.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 150);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 3;
            label5.Text = "Yıl :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 150);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 2;
            label4.Text = "Son Kullanım Ay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 100);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 1;
            label3.Text = "Kart Numarası :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 53);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 0;
            label2.Text = "Kart Sahibi :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(groupBoxKrediKarti);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxKrediKarti.ResumeLayout(false);
            groupBoxKrediKarti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kartSonAy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxCuzdan;
        private CheckBox checkBoxKK;
        private CheckBox checkBoxKapidaOdeme;
        private GroupBox groupBox2;
        private Label lblTutar;
        private Label label1;
        private GroupBox groupBoxKrediKarti;
        private MaskedTextBox maskedtxtKartNo;
        private TextBox txtKartSahibi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button btnKrediKartiOde;
        private TextBox txtCvc;
        private Label label6;
        private TextBox kartSonYil;
        private NumericUpDown kartSonAy;
    }
}