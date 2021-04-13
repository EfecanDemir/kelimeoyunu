namespace kelimeoyunu
{
    partial class giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.kAdiTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.baglantiBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderkadi = new System.Windows.Forms.ErrorProvider(this.components);
            this.bilgiBtn = new System.Windows.Forms.Button();
            this.bilgiPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.soruekleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderkadi)).BeginInit();
            this.bilgiPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kAdiTextbox
            // 
            this.kAdiTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiTextbox.Location = new System.Drawing.Point(181, 218);
            this.kAdiTextbox.MaxLength = 14;
            this.kAdiTextbox.Multiline = true;
            this.kAdiTextbox.Name = "kAdiTextbox";
            this.kAdiTextbox.Size = new System.Drawing.Size(315, 58);
            this.kAdiTextbox.TabIndex = 0;
            this.kAdiTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(165, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI  ADINIZI  GİRİNİZ \r\n";
            // 
            // girisBtn
            // 
            this.girisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisBtn.BackgroundImage")));
            this.girisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisBtn.Location = new System.Drawing.Point(181, 300);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(120, 120);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisBtn.BackgroundImage")));
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisBtn.Location = new System.Drawing.Point(376, 300);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(120, 120);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // baglantiBtn
            // 
            this.baglantiBtn.Location = new System.Drawing.Point(659, 476);
            this.baglantiBtn.Name = "baglantiBtn";
            this.baglantiBtn.Size = new System.Drawing.Size(21, 23);
            this.baglantiBtn.TabIndex = 6;
            this.baglantiBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(586, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bağlantı";
            // 
            // errorProviderkadi
            // 
            this.errorProviderkadi.ContainerControl = this;
            // 
            // bilgiBtn
            // 
            this.bilgiBtn.BackColor = System.Drawing.Color.Transparent;
            this.bilgiBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bilgiBtn.BackgroundImage")));
            this.bilgiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bilgiBtn.Location = new System.Drawing.Point(12, 462);
            this.bilgiBtn.Name = "bilgiBtn";
            this.bilgiBtn.Size = new System.Drawing.Size(54, 62);
            this.bilgiBtn.TabIndex = 8;
            this.bilgiBtn.UseVisualStyleBackColor = false;
            this.bilgiBtn.MouseLeave += new System.EventHandler(this.bilgiBtn_MouseLeave);
            this.bilgiBtn.MouseHover += new System.EventHandler(this.bilgiBtn_MouseHover);
            // 
            // bilgiPnl
            // 
            this.bilgiPnl.Controls.Add(this.label2);
            this.bilgiPnl.Location = new System.Drawing.Point(72, 58);
            this.bilgiPnl.Name = "bilgiPnl";
            this.bilgiPnl.Size = new System.Drawing.Size(400, 466);
            this.bilgiPnl.TabIndex = 9;
            this.bilgiPnl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 440);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // soruekleBtn
            // 
            this.soruekleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruekleBtn.BackgroundImage")));
            this.soruekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soruekleBtn.Location = new System.Drawing.Point(84, 433);
            this.soruekleBtn.Name = "soruekleBtn";
            this.soruekleBtn.Size = new System.Drawing.Size(100, 91);
            this.soruekleBtn.TabIndex = 10;
            this.soruekleBtn.UseVisualStyleBackColor = true;
            this.soruekleBtn.Click += new System.EventHandler(this.soruekleBtn_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 536);
            this.Controls.Add(this.soruekleBtn);
            this.Controls.Add(this.bilgiPnl);
            this.Controls.Add(this.bilgiBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baglantiBtn);
            this.Controls.Add(this.cikisBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kAdiTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME OYUNU ↬ by EFECAN DEMİR";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderkadi)).EndInit();
            this.bilgiPnl.ResumeLayout(false);
            this.bilgiPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kAdiTextbox;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Button baglantiBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderkadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bilgiPnl;
        private System.Windows.Forms.Button bilgiBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button soruekleBtn;
    }
}

