namespace faktoriyel
{
    partial class FaktoriyelUygulama
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaktoriyelUygulama));
            this.textAcilim = new System.Windows.Forms.TextBox();
            this.fktrylTemizle = new System.Windows.Forms.Button();
            this.textSayi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.textAsal = new System.Windows.Forms.TextBox();
            this.textSonuc = new System.Windows.Forms.TextBox();
            this.fktrylKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAcilim
            // 
            this.textAcilim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textAcilim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAcilim.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textAcilim.Enabled = false;
            this.textAcilim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAcilim.Location = new System.Drawing.Point(395, 385);
            this.textAcilim.Multiline = true;
            this.textAcilim.Name = "textAcilim";
            this.textAcilim.Size = new System.Drawing.Size(286, 23);
            this.textAcilim.TabIndex = 10;
            this.textAcilim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fktrylTemizle
            // 
            this.fktrylTemizle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fktrylTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fktrylTemizle.BackgroundImage")));
            this.fktrylTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fktrylTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fktrylTemizle.FlatAppearance.BorderSize = 0;
            this.fktrylTemizle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fktrylTemizle.Location = new System.Drawing.Point(422, 200);
            this.fktrylTemizle.Name = "fktrylTemizle";
            this.fktrylTemizle.Size = new System.Drawing.Size(96, 43);
            this.fktrylTemizle.TabIndex = 9;
            this.fktrylTemizle.UseVisualStyleBackColor = false;
            this.fktrylTemizle.Click += new System.EventHandler(this.fktrylTemizle_Click);
            // 
            // textSayi
            // 
            this.textSayi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSayi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSayi.Location = new System.Drawing.Point(395, 158);
            this.textSayi.Multiline = true;
            this.textSayi.Name = "textSayi";
            this.textSayi.Size = new System.Drawing.Size(286, 24);
            this.textSayi.TabIndex = 8;
            this.textSayi.TextChanged += new System.EventHandler(this.fktrylSayi_TextChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHesapla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHesapla.BackgroundImage")));
            this.btnHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(568, 200);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(96, 43);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // textAsal
            // 
            this.textAsal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textAsal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAsal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textAsal.Enabled = false;
            this.textAsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAsal.Location = new System.Drawing.Point(395, 328);
            this.textAsal.Multiline = true;
            this.textAsal.Name = "textAsal";
            this.textAsal.Size = new System.Drawing.Size(286, 23);
            this.textAsal.TabIndex = 5;
            this.textAsal.TextChanged += new System.EventHandler(this.textAsal_TextChanged);
            // 
            // textSonuc
            // 
            this.textSonuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSonuc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textSonuc.Enabled = false;
            this.textSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSonuc.Location = new System.Drawing.Point(395, 274);
            this.textSonuc.Multiline = true;
            this.textSonuc.Name = "textSonuc";
            this.textSonuc.Size = new System.Drawing.Size(286, 24);
            this.textSonuc.TabIndex = 4;
            this.textSonuc.TextChanged += new System.EventHandler(this.textSonuc_TextChanged);
            // 
            // fktrylKapat
            // 
            this.fktrylKapat.BackColor = System.Drawing.Color.Transparent;
            this.fktrylKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fktrylKapat.BackgroundImage")));
            this.fktrylKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fktrylKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fktrylKapat.FlatAppearance.BorderSize = 0;
            this.fktrylKapat.Location = new System.Drawing.Point(866, 3);
            this.fktrylKapat.Name = "fktrylKapat";
            this.fktrylKapat.Size = new System.Drawing.Size(32, 31);
            this.fktrylKapat.TabIndex = 2;
            this.fktrylKapat.UseVisualStyleBackColor = false;
            this.fktrylKapat.Click += new System.EventHandler(this.fktrylKapat_Click);
            this.fktrylKapat.MouseEnter += new System.EventHandler(this.fktrylKapat_MouseEnter);
            this.fktrylKapat.MouseLeave += new System.EventHandler(this.fktrylKapat_MouseLeave);
            // 
            // FaktoriyelUygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.fktrylTemizle);
            this.Controls.Add(this.textAcilim);
            this.Controls.Add(this.fktrylKapat);
            this.Controls.Add(this.textSayi);
            this.Controls.Add(this.textAsal);
            this.Controls.Add(this.textSonuc);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FaktoriyelUygulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faktoriyel Hesaplama";
            this.Load += new System.EventHandler(this.FaktoriyelUygulama_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaktoriyelUygulama_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FaktoriyelUygulama_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FaktoriyelUygulama_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSayi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox textAsal;
        private System.Windows.Forms.TextBox textSonuc;
        private System.Windows.Forms.Button fktrylTemizle;
        private System.Windows.Forms.Button fktrylKapat;
        private System.Windows.Forms.TextBox textAcilim;
    }
}

