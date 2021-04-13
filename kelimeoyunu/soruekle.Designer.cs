namespace kelimeoyunu
{
    partial class soruekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soruekle));
            this.soruekleTxt = new System.Windows.Forms.TextBox();
            this.cevapekleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soruekleBtn = new System.Windows.Forms.Button();
            this.errorProvidersoru = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvidercevap = new System.Windows.Forms.ErrorProvider(this.components);
            this.idLbl = new System.Windows.Forms.Label();
            this.ciksBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercevap)).BeginInit();
            this.SuspendLayout();
            // 
            // soruekleTxt
            // 
            this.soruekleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruekleTxt.Location = new System.Drawing.Point(243, 261);
            this.soruekleTxt.Multiline = true;
            this.soruekleTxt.Name = "soruekleTxt";
            this.soruekleTxt.Size = new System.Drawing.Size(435, 118);
            this.soruekleTxt.TabIndex = 0;
            this.soruekleTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soruekleTxt_KeyPress);
            // 
            // cevapekleTxt
            // 
            this.cevapekleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapekleTxt.Location = new System.Drawing.Point(243, 406);
            this.cevapekleTxt.MaxLength = 10;
            this.cevapekleTxt.Multiline = true;
            this.cevapekleTxt.Name = "cevapekleTxt";
            this.cevapekleTxt.Size = new System.Drawing.Size(252, 50);
            this.cevapekleTxt.TabIndex = 1;
            this.cevapekleTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soruekleTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(70, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "SORU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(51, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEVAP:";
            // 
            // soruekleBtn
            // 
            this.soruekleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruekleBtn.BackgroundImage")));
            this.soruekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soruekleBtn.Location = new System.Drawing.Point(375, 484);
            this.soruekleBtn.Name = "soruekleBtn";
            this.soruekleBtn.Size = new System.Drawing.Size(120, 120);
            this.soruekleBtn.TabIndex = 4;
            this.soruekleBtn.UseVisualStyleBackColor = true;
            this.soruekleBtn.Click += new System.EventHandler(this.soruekleBtn_Click);
            // 
            // errorProvidersoru
            // 
            this.errorProvidersoru.ContainerControl = this;
            // 
            // errorProvidercevap
            // 
            this.errorProvidercevap.ContainerControl = this;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(606, 632);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(51, 20);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "label3";
            this.idLbl.Visible = false;
            // 
            // ciksBtn
            // 
            this.ciksBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ciksBtn.BackgroundImage")));
            this.ciksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ciksBtn.Location = new System.Drawing.Point(558, 484);
            this.ciksBtn.Name = "ciksBtn";
            this.ciksBtn.Size = new System.Drawing.Size(120, 120);
            this.ciksBtn.TabIndex = 6;
            this.ciksBtn.UseVisualStyleBackColor = true;
            this.ciksBtn.Click += new System.EventHandler(this.ciksBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Reem Kufi", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(225, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "SORUNUZU  EKLEYİNİZ.";
            // 
            // soruekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciksBtn);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.soruekleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cevapekleTxt);
            this.Controls.Add(this.soruekleTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "soruekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KELİME OYUNU ↬ by EFECAN DEMİR";
            this.Load += new System.EventHandler(this.soruekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidersoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidercevap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soruekleTxt;
        private System.Windows.Forms.TextBox cevapekleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button soruekleBtn;
        private System.Windows.Forms.ErrorProvider errorProvidersoru;
        private System.Windows.Forms.ErrorProvider errorProvidercevap;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button ciksBtn;
        private System.Windows.Forms.Label label3;
    }
}