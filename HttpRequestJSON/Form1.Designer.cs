namespace HttpRequestJSON
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrVeri = new System.Windows.Forms.Timer(this.components);
            this.lstSymbol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(343, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            // 
            // tmrVeri
            // 
            this.tmrVeri.Tick += new System.EventHandler(this.tmrVeri_Tick);
            // 
            // lstSymbol
            // 
            this.lstSymbol.FormattingEnabled = true;
            this.lstSymbol.ItemHeight = 15;
            this.lstSymbol.Location = new System.Drawing.Point(25, 23);
            this.lstSymbol.Name = "lstSymbol";
            this.lstSymbol.Size = new System.Drawing.Size(218, 319);
            this.lstSymbol.TabIndex = 1;
            this.lstSymbol.SelectedIndexChanged += new System.EventHandler(this.lstSymbol_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 363);
            this.Controls.Add(this.lstSymbol);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInfo;
        private System.Windows.Forms.Timer tmrVeri;
        private ListBox lstSymbol;
    }
}