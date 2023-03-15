namespace InterfaceOrnek
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
            radioBtnKare = new RadioButton();
            radioBtnDikdortgen = new RadioButton();
            grpBoxIslemler = new GroupBox();
            btnCevreHesapla = new Button();
            btnAlanHesapla = new Button();
            txtKenar2 = new TextBox();
            txtKenar1 = new TextBox();
            txtSekilAdi = new TextBox();
            lblKenar2 = new Label();
            lblKenar1 = new Label();
            lblSekilAdi = new Label();
            grpBoxIslemler.SuspendLayout();
            SuspendLayout();
            // 
            // radioBtnKare
            // 
            radioBtnKare.AutoSize = true;
            radioBtnKare.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnKare.Location = new Point(83, 44);
            radioBtnKare.Name = "radioBtnKare";
            radioBtnKare.Size = new Size(59, 24);
            radioBtnKare.TabIndex = 0;
            radioBtnKare.TabStop = true;
            radioBtnKare.Text = "Kare";
            radioBtnKare.UseVisualStyleBackColor = true;
            radioBtnKare.CheckedChanged += radioBtnKare_CheckedChanged;
            // 
            // radioBtnDikdortgen
            // 
            radioBtnDikdortgen.AutoSize = true;
            radioBtnDikdortgen.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioBtnDikdortgen.Location = new Point(218, 44);
            radioBtnDikdortgen.Name = "radioBtnDikdortgen";
            radioBtnDikdortgen.Size = new Size(106, 24);
            radioBtnDikdortgen.TabIndex = 1;
            radioBtnDikdortgen.TabStop = true;
            radioBtnDikdortgen.Text = "Dikdörtgen";
            radioBtnDikdortgen.UseVisualStyleBackColor = true;
            radioBtnDikdortgen.CheckedChanged += radioBtnDikdortgen_CheckedChanged;
            // 
            // grpBoxIslemler
            // 
            grpBoxIslemler.Controls.Add(btnCevreHesapla);
            grpBoxIslemler.Controls.Add(btnAlanHesapla);
            grpBoxIslemler.Controls.Add(txtKenar2);
            grpBoxIslemler.Controls.Add(txtKenar1);
            grpBoxIslemler.Controls.Add(txtSekilAdi);
            grpBoxIslemler.Controls.Add(lblKenar2);
            grpBoxIslemler.Controls.Add(lblKenar1);
            grpBoxIslemler.Controls.Add(lblSekilAdi);
            grpBoxIslemler.Location = new Point(35, 87);
            grpBoxIslemler.Name = "grpBoxIslemler";
            grpBoxIslemler.Size = new Size(320, 285);
            grpBoxIslemler.TabIndex = 2;
            grpBoxIslemler.TabStop = false;
            grpBoxIslemler.Text = "İşlem Bilgileri";
            // 
            // btnCevreHesapla
            // 
            btnCevreHesapla.BackColor = Color.FromArgb(192, 255, 192);
            btnCevreHesapla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCevreHesapla.Location = new Point(122, 223);
            btnCevreHesapla.Name = "btnCevreHesapla";
            btnCevreHesapla.Size = new Size(147, 36);
            btnCevreHesapla.TabIndex = 7;
            btnCevreHesapla.Text = "Çevre Hesapla";
            btnCevreHesapla.UseVisualStyleBackColor = false;
            btnCevreHesapla.Click += button2_Click;
            // 
            // btnAlanHesapla
            // 
            btnAlanHesapla.BackColor = Color.FromArgb(255, 192, 192);
            btnAlanHesapla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlanHesapla.Location = new Point(122, 174);
            btnAlanHesapla.Name = "btnAlanHesapla";
            btnAlanHesapla.Size = new Size(147, 38);
            btnAlanHesapla.TabIndex = 6;
            btnAlanHesapla.Text = "Alan Hesapla";
            btnAlanHesapla.UseVisualStyleBackColor = false;
            // 
            // txtKenar2
            // 
            txtKenar2.Location = new Point(122, 130);
            txtKenar2.Name = "txtKenar2";
            txtKenar2.Size = new Size(147, 23);
            txtKenar2.TabIndex = 5;
            // 
            // txtKenar1
            // 
            txtKenar1.Location = new Point(122, 85);
            txtKenar1.Name = "txtKenar1";
            txtKenar1.Size = new Size(147, 23);
            txtKenar1.TabIndex = 4;
            // 
            // txtSekilAdi
            // 
            txtSekilAdi.Location = new Point(122, 40);
            txtSekilAdi.Name = "txtSekilAdi";
            txtSekilAdi.Size = new Size(147, 23);
            txtSekilAdi.TabIndex = 3;
            // 
            // lblKenar2
            // 
            lblKenar2.AutoSize = true;
            lblKenar2.Location = new Point(54, 138);
            lblKenar2.Name = "lblKenar2";
            lblKenar2.Size = new Size(43, 15);
            lblKenar2.TabIndex = 2;
            lblKenar2.Text = "Kenar :";
            // 
            // lblKenar1
            // 
            lblKenar1.AutoSize = true;
            lblKenar1.Location = new Point(54, 93);
            lblKenar1.Name = "lblKenar1";
            lblKenar1.Size = new Size(43, 15);
            lblKenar1.TabIndex = 1;
            lblKenar1.Text = "Kenar :";
            lblKenar1.Click += label2_Click;
            // 
            // lblSekilAdi
            // 
            lblSekilAdi.AutoSize = true;
            lblSekilAdi.Location = new Point(39, 48);
            lblSekilAdi.Name = "lblSekilAdi";
            lblSekilAdi.Size = new Size(58, 15);
            lblSekilAdi.TabIndex = 0;
            lblSekilAdi.Text = "Şekil Adı :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(grpBoxIslemler);
            Controls.Add(radioBtnDikdortgen);
            Controls.Add(radioBtnKare);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpBoxIslemler.ResumeLayout(false);
            grpBoxIslemler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnKare;
        private RadioButton radioBtnDikdortgen;
        private GroupBox grpBoxIslemler;
        private TextBox txtKenar2;
        private TextBox txtKenar1;
        private TextBox txtSekilAdi;
        private Label lblKenar2;
        private Label lblKenar1;
        private Label lblSekilAdi;
        private Button btnCevreHesapla;
        private Button btnAlanHesapla;
    }
}