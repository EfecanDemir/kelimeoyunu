namespace kelimeoyunu
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.sorusayisiLbl = new System.Windows.Forms.Label();
            this.baslaBtn = new System.Windows.Forms.Button();
            this.birinciBtn = new System.Windows.Forms.TextBox();
            this.ikinciBtn = new System.Windows.Forms.TextBox();
            this.ucuncuBtn = new System.Windows.Forms.TextBox();
            this.dorduncuBtn = new System.Windows.Forms.TextBox();
            this.besinciBtn = new System.Windows.Forms.TextBox();
            this.altinciBtn = new System.Windows.Forms.TextBox();
            this.yedinciBtn = new System.Windows.Forms.TextBox();
            this.sekizinciBtn = new System.Windows.Forms.TextBox();
            this.dokuzuncuBtn = new System.Windows.Forms.TextBox();
            this.onuncuBtn = new System.Windows.Forms.TextBox();
            this.kirmiziBtn = new System.Windows.Forms.Button();
            this.harfalBtn = new System.Windows.Forms.Button();
            this.tahminetBtn = new System.Windows.Forms.Button();
            this.soruLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.puanLbl = new System.Windows.Forms.Label();
            this.birinciPnl = new System.Windows.Forms.Panel();
            this.ikinciPnl = new System.Windows.Forms.Panel();
            this.dorduncuPnl = new System.Windows.Forms.Panel();
            this.ucuncuPnl = new System.Windows.Forms.Panel();
            this.sekizinciPnl = new System.Windows.Forms.Panel();
            this.yedinciPnl = new System.Windows.Forms.Panel();
            this.altinciPnl = new System.Windows.Forms.Panel();
            this.besinciPnl = new System.Windows.Forms.Panel();
            this.onuncuPnl = new System.Windows.Forms.Panel();
            this.dokuzuncuPnl = new System.Windows.Forms.Panel();
            this.sorupuanLbl = new System.Windows.Forms.Label();
            this.tekraroynaBtn = new System.Windows.Forms.Button();
            this.kullaniciAdiLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.puantablosuBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.oyuncuLbl = new System.Windows.Forms.Label();
            this.snLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.kalansureeLbl = new System.Windows.Forms.Label();
            this.randsorusayisiLbl = new System.Windows.Forms.Label();
            this.birinciPnl.SuspendLayout();
            this.ikinciPnl.SuspendLayout();
            this.dorduncuPnl.SuspendLayout();
            this.ucuncuPnl.SuspendLayout();
            this.sekizinciPnl.SuspendLayout();
            this.yedinciPnl.SuspendLayout();
            this.altinciPnl.SuspendLayout();
            this.besinciPnl.SuspendLayout();
            this.onuncuPnl.SuspendLayout();
            this.dokuzuncuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sorusayisiLbl
            // 
            this.sorusayisiLbl.AutoSize = true;
            this.sorusayisiLbl.Location = new System.Drawing.Point(94, 535);
            this.sorusayisiLbl.Name = "sorusayisiLbl";
            this.sorusayisiLbl.Size = new System.Drawing.Size(47, 20);
            this.sorusayisiLbl.TabIndex = 1;
            this.sorusayisiLbl.Text = "Soru:";
            this.sorusayisiLbl.Visible = false;
            // 
            // baslaBtn
            // 
            this.baslaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baslaBtn.BackgroundImage")));
            this.baslaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baslaBtn.Location = new System.Drawing.Point(50, 27);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(120, 120);
            this.baslaBtn.TabIndex = 2;
            this.baslaBtn.UseVisualStyleBackColor = true;
            this.baslaBtn.Click += new System.EventHandler(this.baslaBtn_Click);
            // 
            // birinciBtn
            // 
            this.birinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.birinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birinciBtn.Enabled = false;
            this.birinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birinciBtn.Location = new System.Drawing.Point(24, 24);
            this.birinciBtn.Multiline = true;
            this.birinciBtn.Name = "birinciBtn";
            this.birinciBtn.Size = new System.Drawing.Size(45, 54);
            this.birinciBtn.TabIndex = 3;
            this.birinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birinciBtn.Visible = false;
            this.birinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // ikinciBtn
            // 
            this.ikinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ikinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ikinciBtn.Enabled = false;
            this.ikinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinciBtn.Location = new System.Drawing.Point(25, 24);
            this.ikinciBtn.Multiline = true;
            this.ikinciBtn.Name = "ikinciBtn";
            this.ikinciBtn.Size = new System.Drawing.Size(45, 54);
            this.ikinciBtn.TabIndex = 4;
            this.ikinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ikinciBtn.Visible = false;
            this.ikinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // ucuncuBtn
            // 
            this.ucuncuBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ucuncuBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ucuncuBtn.Enabled = false;
            this.ucuncuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucuncuBtn.Location = new System.Drawing.Point(24, 24);
            this.ucuncuBtn.Multiline = true;
            this.ucuncuBtn.Name = "ucuncuBtn";
            this.ucuncuBtn.Size = new System.Drawing.Size(45, 54);
            this.ucuncuBtn.TabIndex = 5;
            this.ucuncuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ucuncuBtn.Visible = false;
            this.ucuncuBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // dorduncuBtn
            // 
            this.dorduncuBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dorduncuBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dorduncuBtn.Enabled = false;
            this.dorduncuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dorduncuBtn.Location = new System.Drawing.Point(25, 24);
            this.dorduncuBtn.Multiline = true;
            this.dorduncuBtn.Name = "dorduncuBtn";
            this.dorduncuBtn.Size = new System.Drawing.Size(45, 54);
            this.dorduncuBtn.TabIndex = 6;
            this.dorduncuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dorduncuBtn.Visible = false;
            this.dorduncuBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // besinciBtn
            // 
            this.besinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.besinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.besinciBtn.Enabled = false;
            this.besinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.besinciBtn.Location = new System.Drawing.Point(25, 24);
            this.besinciBtn.Multiline = true;
            this.besinciBtn.Name = "besinciBtn";
            this.besinciBtn.Size = new System.Drawing.Size(45, 54);
            this.besinciBtn.TabIndex = 7;
            this.besinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.besinciBtn.Visible = false;
            this.besinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // altinciBtn
            // 
            this.altinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.altinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.altinciBtn.Enabled = false;
            this.altinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altinciBtn.Location = new System.Drawing.Point(26, 24);
            this.altinciBtn.Multiline = true;
            this.altinciBtn.Name = "altinciBtn";
            this.altinciBtn.Size = new System.Drawing.Size(45, 54);
            this.altinciBtn.TabIndex = 8;
            this.altinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altinciBtn.Visible = false;
            this.altinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // yedinciBtn
            // 
            this.yedinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yedinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yedinciBtn.Enabled = false;
            this.yedinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yedinciBtn.Location = new System.Drawing.Point(25, 24);
            this.yedinciBtn.Multiline = true;
            this.yedinciBtn.Name = "yedinciBtn";
            this.yedinciBtn.Size = new System.Drawing.Size(45, 54);
            this.yedinciBtn.TabIndex = 9;
            this.yedinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yedinciBtn.Visible = false;
            this.yedinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // sekizinciBtn
            // 
            this.sekizinciBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sekizinciBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sekizinciBtn.Enabled = false;
            this.sekizinciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekizinciBtn.Location = new System.Drawing.Point(26, 24);
            this.sekizinciBtn.Multiline = true;
            this.sekizinciBtn.Name = "sekizinciBtn";
            this.sekizinciBtn.Size = new System.Drawing.Size(45, 54);
            this.sekizinciBtn.TabIndex = 10;
            this.sekizinciBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sekizinciBtn.Visible = false;
            this.sekizinciBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // dokuzuncuBtn
            // 
            this.dokuzuncuBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dokuzuncuBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dokuzuncuBtn.Enabled = false;
            this.dokuzuncuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dokuzuncuBtn.Location = new System.Drawing.Point(25, 24);
            this.dokuzuncuBtn.Multiline = true;
            this.dokuzuncuBtn.Name = "dokuzuncuBtn";
            this.dokuzuncuBtn.Size = new System.Drawing.Size(45, 54);
            this.dokuzuncuBtn.TabIndex = 11;
            this.dokuzuncuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dokuzuncuBtn.Visible = false;
            this.dokuzuncuBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // onuncuBtn
            // 
            this.onuncuBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.onuncuBtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onuncuBtn.Enabled = false;
            this.onuncuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onuncuBtn.Location = new System.Drawing.Point(26, 24);
            this.onuncuBtn.Multiline = true;
            this.onuncuBtn.Name = "onuncuBtn";
            this.onuncuBtn.Size = new System.Drawing.Size(45, 54);
            this.onuncuBtn.TabIndex = 12;
            this.onuncuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.onuncuBtn.Visible = false;
            this.onuncuBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncuBtn_KeyPress);
            // 
            // kirmiziBtn
            // 
            this.kirmiziBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kirmiziBtn.BackgroundImage")));
            this.kirmiziBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kirmiziBtn.Enabled = false;
            this.kirmiziBtn.Location = new System.Drawing.Point(1224, 494);
            this.kirmiziBtn.Name = "kirmiziBtn";
            this.kirmiziBtn.Size = new System.Drawing.Size(120, 120);
            this.kirmiziBtn.TabIndex = 13;
            this.kirmiziBtn.UseVisualStyleBackColor = true;
            this.kirmiziBtn.Click += new System.EventHandler(this.kirmiziBtn_Click);
            // 
            // harfalBtn
            // 
            this.harfalBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("harfalBtn.BackgroundImage")));
            this.harfalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.harfalBtn.Enabled = false;
            this.harfalBtn.Location = new System.Drawing.Point(1380, 494);
            this.harfalBtn.Name = "harfalBtn";
            this.harfalBtn.Size = new System.Drawing.Size(120, 120);
            this.harfalBtn.TabIndex = 14;
            this.harfalBtn.UseVisualStyleBackColor = true;
            this.harfalBtn.Click += new System.EventHandler(this.harfalBtn_Click);
            // 
            // tahminetBtn
            // 
            this.tahminetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tahminetBtn.BackgroundImage")));
            this.tahminetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tahminetBtn.Enabled = false;
            this.tahminetBtn.Location = new System.Drawing.Point(1539, 494);
            this.tahminetBtn.Name = "tahminetBtn";
            this.tahminetBtn.Size = new System.Drawing.Size(120, 120);
            this.tahminetBtn.TabIndex = 15;
            this.tahminetBtn.UseVisualStyleBackColor = true;
            this.tahminetBtn.Click += new System.EventHandler(this.tahminetBtn_Click);
            // 
            // soruLbl
            // 
            this.soruLbl.AutoSize = true;
            this.soruLbl.BackColor = System.Drawing.Color.Transparent;
            this.soruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.soruLbl.Location = new System.Drawing.Point(179, 518);
            this.soruLbl.MaximumSize = new System.Drawing.Size(850, 518);
            this.soruLbl.Name = "soruLbl";
            this.soruLbl.Size = new System.Drawing.Size(0, 37);
            this.soruLbl.TabIndex = 16;
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.BackColor = System.Drawing.Color.Transparent;
            this.dakikaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakikaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dakikaLbl.Location = new System.Drawing.Point(181, 457);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(36, 37);
            this.dakikaLbl.TabIndex = 17;
            this.dakikaLbl.Text = "4";
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.BackColor = System.Drawing.Color.Transparent;
            this.saniyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saniyeLbl.Location = new System.Drawing.Point(256, 457);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(55, 37);
            this.saniyeLbl.TabIndex = 18;
            this.saniyeLbl.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(223, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "kelime veritabınndan yazdırıldı";
            this.label3.Visible = false;
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.BackColor = System.Drawing.Color.Transparent;
            this.puanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLbl.Location = new System.Drawing.Point(179, 184);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(36, 37);
            this.puanLbl.TabIndex = 21;
            this.puanLbl.Text = "0";
            // 
            // birinciPnl
            // 
            this.birinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("birinciPnl.BackgroundImage")));
            this.birinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birinciPnl.Controls.Add(this.birinciBtn);
            this.birinciPnl.Location = new System.Drawing.Point(230, 327);
            this.birinciPnl.Name = "birinciPnl";
            this.birinciPnl.Size = new System.Drawing.Size(95, 101);
            this.birinciPnl.TabIndex = 32;
            this.birinciPnl.Visible = false;
            // 
            // ikinciPnl
            // 
            this.ikinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ikinciPnl.BackgroundImage")));
            this.ikinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ikinciPnl.Controls.Add(this.ikinciBtn);
            this.ikinciPnl.Location = new System.Drawing.Point(331, 327);
            this.ikinciPnl.Name = "ikinciPnl";
            this.ikinciPnl.Size = new System.Drawing.Size(95, 101);
            this.ikinciPnl.TabIndex = 33;
            this.ikinciPnl.Visible = false;
            // 
            // dorduncuPnl
            // 
            this.dorduncuPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dorduncuPnl.BackgroundImage")));
            this.dorduncuPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dorduncuPnl.Controls.Add(this.dorduncuBtn);
            this.dorduncuPnl.Location = new System.Drawing.Point(533, 327);
            this.dorduncuPnl.Name = "dorduncuPnl";
            this.dorduncuPnl.Size = new System.Drawing.Size(95, 101);
            this.dorduncuPnl.TabIndex = 35;
            this.dorduncuPnl.Visible = false;
            // 
            // ucuncuPnl
            // 
            this.ucuncuPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucuncuPnl.BackgroundImage")));
            this.ucuncuPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucuncuPnl.Controls.Add(this.ucuncuBtn);
            this.ucuncuPnl.Location = new System.Drawing.Point(432, 327);
            this.ucuncuPnl.Name = "ucuncuPnl";
            this.ucuncuPnl.Size = new System.Drawing.Size(95, 101);
            this.ucuncuPnl.TabIndex = 34;
            this.ucuncuPnl.Visible = false;
            // 
            // sekizinciPnl
            // 
            this.sekizinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekizinciPnl.BackgroundImage")));
            this.sekizinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sekizinciPnl.Controls.Add(this.sekizinciBtn);
            this.sekizinciPnl.Location = new System.Drawing.Point(937, 327);
            this.sekizinciPnl.Name = "sekizinciPnl";
            this.sekizinciPnl.Size = new System.Drawing.Size(95, 101);
            this.sekizinciPnl.TabIndex = 39;
            this.sekizinciPnl.Visible = false;
            // 
            // yedinciPnl
            // 
            this.yedinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yedinciPnl.BackgroundImage")));
            this.yedinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yedinciPnl.Controls.Add(this.yedinciBtn);
            this.yedinciPnl.Location = new System.Drawing.Point(836, 327);
            this.yedinciPnl.Name = "yedinciPnl";
            this.yedinciPnl.Size = new System.Drawing.Size(95, 101);
            this.yedinciPnl.TabIndex = 38;
            this.yedinciPnl.Visible = false;
            // 
            // altinciPnl
            // 
            this.altinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("altinciPnl.BackgroundImage")));
            this.altinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.altinciPnl.Controls.Add(this.altinciBtn);
            this.altinciPnl.Location = new System.Drawing.Point(735, 327);
            this.altinciPnl.Name = "altinciPnl";
            this.altinciPnl.Size = new System.Drawing.Size(95, 101);
            this.altinciPnl.TabIndex = 37;
            this.altinciPnl.Visible = false;
            // 
            // besinciPnl
            // 
            this.besinciPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("besinciPnl.BackgroundImage")));
            this.besinciPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.besinciPnl.Controls.Add(this.besinciBtn);
            this.besinciPnl.Location = new System.Drawing.Point(634, 327);
            this.besinciPnl.Name = "besinciPnl";
            this.besinciPnl.Size = new System.Drawing.Size(95, 101);
            this.besinciPnl.TabIndex = 36;
            this.besinciPnl.Visible = false;
            // 
            // onuncuPnl
            // 
            this.onuncuPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onuncuPnl.BackgroundImage")));
            this.onuncuPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onuncuPnl.Controls.Add(this.onuncuBtn);
            this.onuncuPnl.Location = new System.Drawing.Point(1139, 327);
            this.onuncuPnl.Name = "onuncuPnl";
            this.onuncuPnl.Size = new System.Drawing.Size(95, 101);
            this.onuncuPnl.TabIndex = 41;
            this.onuncuPnl.Visible = false;
            // 
            // dokuzuncuPnl
            // 
            this.dokuzuncuPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dokuzuncuPnl.BackgroundImage")));
            this.dokuzuncuPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dokuzuncuPnl.Controls.Add(this.dokuzuncuBtn);
            this.dokuzuncuPnl.Location = new System.Drawing.Point(1038, 327);
            this.dokuzuncuPnl.Name = "dokuzuncuPnl";
            this.dokuzuncuPnl.Size = new System.Drawing.Size(95, 101);
            this.dokuzuncuPnl.TabIndex = 40;
            this.dokuzuncuPnl.Visible = false;
            // 
            // sorupuanLbl
            // 
            this.sorupuanLbl.AutoSize = true;
            this.sorupuanLbl.BackColor = System.Drawing.Color.Transparent;
            this.sorupuanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorupuanLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sorupuanLbl.Location = new System.Drawing.Point(165, 233);
            this.sorupuanLbl.Name = "sorupuanLbl";
            this.sorupuanLbl.Size = new System.Drawing.Size(27, 29);
            this.sorupuanLbl.TabIndex = 42;
            this.sorupuanLbl.Text = "0";
            // 
            // tekraroynaBtn
            // 
            this.tekraroynaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tekraroynaBtn.BackgroundImage")));
            this.tekraroynaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tekraroynaBtn.Location = new System.Drawing.Point(50, 27);
            this.tekraroynaBtn.Name = "tekraroynaBtn";
            this.tekraroynaBtn.Size = new System.Drawing.Size(120, 120);
            this.tekraroynaBtn.TabIndex = 43;
            this.tekraroynaBtn.UseVisualStyleBackColor = true;
            this.tekraroynaBtn.Visible = false;
            this.tekraroynaBtn.Click += new System.EventHandler(this.tekraroynaBtn_Click);
            // 
            // kullaniciAdiLbl
            // 
            this.kullaniciAdiLbl.AutoSize = true;
            this.kullaniciAdiLbl.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciAdiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kullaniciAdiLbl.Location = new System.Drawing.Point(371, 30);
            this.kullaniciAdiLbl.Name = "kullaniciAdiLbl";
            this.kullaniciAdiLbl.Size = new System.Drawing.Size(0, 32);
            this.kullaniciAdiLbl.TabIndex = 44;
            this.kullaniciAdiLbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(627, 232);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.Visible = false;
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.puantablosuBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1014, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 249);
            this.panel1.TabIndex = 46;
            // 
            // puantablosuBtn
            // 
            this.puantablosuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("puantablosuBtn.BackgroundImage")));
            this.puantablosuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.puantablosuBtn.Location = new System.Drawing.Point(389, 14);
            this.puantablosuBtn.Name = "puantablosuBtn";
            this.puantablosuBtn.Size = new System.Drawing.Size(256, 182);
            this.puantablosuBtn.TabIndex = 53;
            this.puantablosuBtn.UseVisualStyleBackColor = true;
            this.puantablosuBtn.MouseHover += new System.EventHandler(this.puantablosuBtn_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1491, 295);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 164);
            this.listBox1.TabIndex = 47;
            this.listBox1.Visible = false;
            // 
            // oyuncuLbl
            // 
            this.oyuncuLbl.AutoSize = true;
            this.oyuncuLbl.BackColor = System.Drawing.Color.Transparent;
            this.oyuncuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oyuncuLbl.Location = new System.Drawing.Point(181, 27);
            this.oyuncuLbl.Name = "oyuncuLbl";
            this.oyuncuLbl.Size = new System.Drawing.Size(173, 37);
            this.oyuncuLbl.TabIndex = 48;
            this.oyuncuLbl.Text = "OYUNCU:";
            this.oyuncuLbl.Visible = false;
            // 
            // snLbl
            // 
            this.snLbl.AutoSize = true;
            this.snLbl.BackColor = System.Drawing.Color.Transparent;
            this.snLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.snLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.snLbl.Location = new System.Drawing.Point(565, 468);
            this.snLbl.Name = "snLbl";
            this.snLbl.Size = new System.Drawing.Size(49, 32);
            this.snLbl.TabIndex = 51;
            this.snLbl.Text = "20";
            this.snLbl.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // kalansureeLbl
            // 
            this.kalansureeLbl.AutoSize = true;
            this.kalansureeLbl.BackColor = System.Drawing.Color.Transparent;
            this.kalansureeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalansureeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kalansureeLbl.Location = new System.Drawing.Point(327, 478);
            this.kalansureeLbl.Name = "kalansureeLbl";
            this.kalansureeLbl.Size = new System.Drawing.Size(229, 20);
            this.kalansureeLbl.TabIndex = 52;
            this.kalansureeLbl.Text = "Cevaplama İçin Kalan Süre:";
            this.kalansureeLbl.Visible = false;
            // 
            // randsorusayisiLbl
            // 
            this.randsorusayisiLbl.AutoSize = true;
            this.randsorusayisiLbl.Location = new System.Drawing.Point(762, 182);
            this.randsorusayisiLbl.Name = "randsorusayisiLbl";
            this.randsorusayisiLbl.Size = new System.Drawing.Size(51, 20);
            this.randsorusayisiLbl.TabIndex = 53;
            this.randsorusayisiLbl.Text = "label1";
            this.randsorusayisiLbl.Visible = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1778, 644);
            this.Controls.Add(this.randsorusayisiLbl);
            this.Controls.Add(this.kalansureeLbl);
            this.Controls.Add(this.snLbl);
            this.Controls.Add(this.oyuncuLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullaniciAdiLbl);
            this.Controls.Add(this.tekraroynaBtn);
            this.Controls.Add(this.sorupuanLbl);
            this.Controls.Add(this.onuncuPnl);
            this.Controls.Add(this.dokuzuncuPnl);
            this.Controls.Add(this.sekizinciPnl);
            this.Controls.Add(this.yedinciPnl);
            this.Controls.Add(this.altinciPnl);
            this.Controls.Add(this.besinciPnl);
            this.Controls.Add(this.dorduncuPnl);
            this.Controls.Add(this.ucuncuPnl);
            this.Controls.Add(this.ikinciPnl);
            this.Controls.Add(this.birinciPnl);
            this.Controls.Add(this.puanLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.dakikaLbl);
            this.Controls.Add(this.soruLbl);
            this.Controls.Add(this.tahminetBtn);
            this.Controls.Add(this.harfalBtn);
            this.Controls.Add(this.kirmiziBtn);
            this.Controls.Add(this.baslaBtn);
            this.Controls.Add(this.sorusayisiLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME OYUNU ↬ by EFECAN DEMİR";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.birinciPnl.ResumeLayout(false);
            this.birinciPnl.PerformLayout();
            this.ikinciPnl.ResumeLayout(false);
            this.ikinciPnl.PerformLayout();
            this.dorduncuPnl.ResumeLayout(false);
            this.dorduncuPnl.PerformLayout();
            this.ucuncuPnl.ResumeLayout(false);
            this.ucuncuPnl.PerformLayout();
            this.sekizinciPnl.ResumeLayout(false);
            this.sekizinciPnl.PerformLayout();
            this.yedinciPnl.ResumeLayout(false);
            this.yedinciPnl.PerformLayout();
            this.altinciPnl.ResumeLayout(false);
            this.altinciPnl.PerformLayout();
            this.besinciPnl.ResumeLayout(false);
            this.besinciPnl.PerformLayout();
            this.onuncuPnl.ResumeLayout(false);
            this.onuncuPnl.PerformLayout();
            this.dokuzuncuPnl.ResumeLayout(false);
            this.dokuzuncuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sorusayisiLbl;
        private System.Windows.Forms.Button baslaBtn;
        private System.Windows.Forms.TextBox birinciBtn;
        private System.Windows.Forms.TextBox ikinciBtn;
        private System.Windows.Forms.TextBox ucuncuBtn;
        private System.Windows.Forms.TextBox dorduncuBtn;
        private System.Windows.Forms.TextBox besinciBtn;
        private System.Windows.Forms.TextBox altinciBtn;
        private System.Windows.Forms.TextBox yedinciBtn;
        private System.Windows.Forms.TextBox sekizinciBtn;
        private System.Windows.Forms.TextBox dokuzuncuBtn;
        private System.Windows.Forms.TextBox onuncuBtn;
        private System.Windows.Forms.Button kirmiziBtn;
        private System.Windows.Forms.Button harfalBtn;
        private System.Windows.Forms.Button tahminetBtn;
        private System.Windows.Forms.Label soruLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Panel birinciPnl;
        private System.Windows.Forms.Panel ikinciPnl;
        private System.Windows.Forms.Panel dorduncuPnl;
        private System.Windows.Forms.Panel ucuncuPnl;
        private System.Windows.Forms.Panel sekizinciPnl;
        private System.Windows.Forms.Panel yedinciPnl;
        private System.Windows.Forms.Panel altinciPnl;
        private System.Windows.Forms.Panel besinciPnl;
        private System.Windows.Forms.Panel onuncuPnl;
        private System.Windows.Forms.Panel dokuzuncuPnl;
        private System.Windows.Forms.Label sorupuanLbl;
        private System.Windows.Forms.Button tekraroynaBtn;
        private System.Windows.Forms.Label kullaniciAdiLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label oyuncuLbl;
        private System.Windows.Forms.Label snLbl;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label kalansureeLbl;
        private System.Windows.Forms.Button puantablosuBtn;
        private System.Windows.Forms.Label randsorusayisiLbl;
    }
}