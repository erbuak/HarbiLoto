
namespace UI.HarbiLoto
{
    partial class FrmAcilis
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
            this.gbGirisYap = new System.Windows.Forms.GroupBox();
            this.kullaniciAdiGiris_ = new System.Windows.Forms.Label();
            this.txtKullaniciAdiGiris = new System.Windows.Forms.TextBox();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.gbKayitOl = new System.Windows.Forms.GroupBox();
            this.kullaniciAdiKayit_ = new System.Windows.Forms.Label();
            this.txtKullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.karsilama1_ = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.gbGirisYap.SuspendLayout();
            this.gbKayitOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGirisYap
            // 
            this.gbGirisYap.Controls.Add(this.kullaniciAdiGiris_);
            this.gbGirisYap.Controls.Add(this.txtKullaniciAdiGiris);
            this.gbGirisYap.Controls.Add(this.btnGirişYap);
            this.gbGirisYap.Location = new System.Drawing.Point(12, 209);
            this.gbGirisYap.Name = "gbGirisYap";
            this.gbGirisYap.Size = new System.Drawing.Size(377, 202);
            this.gbGirisYap.TabIndex = 7;
            this.gbGirisYap.TabStop = false;
            this.gbGirisYap.Text = "Giriş Yap";
            // 
            // kullaniciAdiGiris_
            // 
            this.kullaniciAdiGiris_.AutoSize = true;
            this.kullaniciAdiGiris_.Location = new System.Drawing.Point(24, 62);
            this.kullaniciAdiGiris_.Name = "kullaniciAdiGiris_";
            this.kullaniciAdiGiris_.Size = new System.Drawing.Size(64, 13);
            this.kullaniciAdiGiris_.TabIndex = 11;
            this.kullaniciAdiGiris_.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdiGiris
            // 
            this.txtKullaniciAdiGiris.Location = new System.Drawing.Point(104, 59);
            this.txtKullaniciAdiGiris.Name = "txtKullaniciAdiGiris";
            this.txtKullaniciAdiGiris.Size = new System.Drawing.Size(171, 20);
            this.txtKullaniciAdiGiris.TabIndex = 8;
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Location = new System.Drawing.Point(104, 98);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(171, 23);
            this.btnGirişYap.TabIndex = 10;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // gbKayitOl
            // 
            this.gbKayitOl.Controls.Add(this.kullaniciAdiKayit_);
            this.gbKayitOl.Controls.Add(this.txtKullaniciAdiKayit);
            this.gbKayitOl.Controls.Add(this.btnKaydet);
            this.gbKayitOl.Location = new System.Drawing.Point(411, 209);
            this.gbKayitOl.Name = "gbKayitOl";
            this.gbKayitOl.Size = new System.Drawing.Size(377, 202);
            this.gbKayitOl.TabIndex = 13;
            this.gbKayitOl.TabStop = false;
            this.gbKayitOl.Text = "Kayıt Ol";
            // 
            // kullaniciAdiKayit_
            // 
            this.kullaniciAdiKayit_.AutoSize = true;
            this.kullaniciAdiKayit_.Location = new System.Drawing.Point(24, 62);
            this.kullaniciAdiKayit_.Name = "kullaniciAdiKayit_";
            this.kullaniciAdiKayit_.Size = new System.Drawing.Size(64, 13);
            this.kullaniciAdiKayit_.TabIndex = 11;
            this.kullaniciAdiKayit_.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdiKayit
            // 
            this.txtKullaniciAdiKayit.Location = new System.Drawing.Point(104, 59);
            this.txtKullaniciAdiKayit.Name = "txtKullaniciAdiKayit";
            this.txtKullaniciAdiKayit.Size = new System.Drawing.Size(171, 20);
            this.txtKullaniciAdiKayit.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(104, 98);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(171, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kayıt Ol";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // karsilama1_
            // 
            this.karsilama1_.AutoSize = true;
            this.karsilama1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karsilama1_.Location = new System.Drawing.Point(275, 24);
            this.karsilama1_.Name = "karsilama1_";
            this.karsilama1_.Size = new System.Drawing.Size(274, 25);
            this.karsilama1_.TabIndex = 14;
            this.karsilama1_.Text = "Harbi Loto\'ya Hoş Geldin";
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(132, 65);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(543, 95);
            this.lblMesaj.TabIndex = 15;
            this.lblMesaj.Text = "Mesaj";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(295, 170);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(222, 16);
            this.lblZaman.TabIndex = 16;
            this.lblZaman.Text = "Bir sonraki çekilişe kalan süre: 15 sn";
            // 
            // FrmAcilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.karsilama1_);
            this.Controls.Add(this.gbKayitOl);
            this.Controls.Add(this.gbGirisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harbi Loto";
            this.gbGirisYap.ResumeLayout(false);
            this.gbGirisYap.PerformLayout();
            this.gbKayitOl.ResumeLayout(false);
            this.gbKayitOl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGirisYap;
        private System.Windows.Forms.Label kullaniciAdiGiris_;
        private System.Windows.Forms.TextBox txtKullaniciAdiGiris;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.GroupBox gbKayitOl;
        private System.Windows.Forms.Label kullaniciAdiKayit_;
        private System.Windows.Forms.TextBox txtKullaniciAdiKayit;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label karsilama1_;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblZaman;
        public System.Windows.Forms.Timer tmrZaman;
    }
}

