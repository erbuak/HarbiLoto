
namespace UI.HarbiLoto
{
    partial class FrmSonuc
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.lblCekiliseKatilanKuponlarim = new System.Windows.Forms.Label();
            this.dgvKuponlarim = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSonuclar = new System.Windows.Forms.Panel();
            this.lblCekilisTarihi = new System.Windows.Forms.Label();
            this.lblSayi6 = new System.Windows.Forms.Label();
            this.lblSayi5 = new System.Windows.Forms.Label();
            this.lblSayi4 = new System.Windows.Forms.Label();
            this.lblSayi3 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponlarim)).BeginInit();
            this.pnlSonuclar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(9, 62);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(784, 54);
            this.lblMesaj.TabIndex = 9;
            this.lblMesaj.Text = "Mesaj";
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // lblCekiliseKatilanKuponlarim
            // 
            this.lblCekiliseKatilanKuponlarim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekiliseKatilanKuponlarim.Location = new System.Drawing.Point(12, 259);
            this.lblCekiliseKatilanKuponlarim.Name = "lblCekiliseKatilanKuponlarim";
            this.lblCekiliseKatilanKuponlarim.Size = new System.Drawing.Size(520, 25);
            this.lblCekiliseKatilanKuponlarim.TabIndex = 14;
            this.lblCekiliseKatilanKuponlarim.Text = "xxx Tarihli Çekilişe Katılan Kuponların";
            // 
            // dgvKuponlarim
            // 
            this.dgvKuponlarim.AllowUserToAddRows = false;
            this.dgvKuponlarim.AllowUserToDeleteRows = false;
            this.dgvKuponlarim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKuponlarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuponlarim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvKuponlarim.Location = new System.Drawing.Point(12, 287);
            this.dgvKuponlarim.MultiSelect = false;
            this.dgvKuponlarim.Name = "dgvKuponlarim";
            this.dgvKuponlarim.ReadOnly = true;
            this.dgvKuponlarim.Size = new System.Drawing.Size(781, 150);
            this.dgvKuponlarim.TabIndex = 12;
            this.dgvKuponlarim.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKuponlarim_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KuponTarihi";
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Kupon Oluşturulma Tarihi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CekilisTarihi";
            this.Column8.FillWeight = 200F;
            this.Column8.HeaderText = "Çekilis Tarihi";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sayi1";
            this.Column2.HeaderText = "Sayı 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sayi2";
            this.Column3.HeaderText = "Sayı 2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sayi3";
            this.Column4.HeaderText = "Sayı 3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sayi4";
            this.Column5.HeaderText = "Sayı 4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sayi5";
            this.Column6.HeaderText = "Sayı 5";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sayi6";
            this.Column7.HeaderText = "Sayı 6";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // pnlSonuclar
            // 
            this.pnlSonuclar.BackColor = System.Drawing.Color.LightGray;
            this.pnlSonuclar.Controls.Add(this.lblCekilisTarihi);
            this.pnlSonuclar.Controls.Add(this.lblSayi6);
            this.pnlSonuclar.Controls.Add(this.lblSayi5);
            this.pnlSonuclar.Controls.Add(this.lblSayi4);
            this.pnlSonuclar.Controls.Add(this.lblSayi3);
            this.pnlSonuclar.Controls.Add(this.lblSayi2);
            this.pnlSonuclar.Controls.Add(this.lblSayi1);
            this.pnlSonuclar.Location = new System.Drawing.Point(147, 121);
            this.pnlSonuclar.Name = "pnlSonuclar";
            this.pnlSonuclar.Size = new System.Drawing.Size(518, 105);
            this.pnlSonuclar.TabIndex = 11;
            // 
            // lblCekilisTarihi
            // 
            this.lblCekilisTarihi.AutoSize = true;
            this.lblCekilisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilisTarihi.Location = new System.Drawing.Point(159, 11);
            this.lblCekilisTarihi.Name = "lblCekilisTarihi";
            this.lblCekilisTarihi.Size = new System.Drawing.Size(85, 16);
            this.lblCekilisTarihi.TabIndex = 17;
            this.lblCekilisTarihi.Text = "Cekilis Tarihi";
            // 
            // lblSayi6
            // 
            this.lblSayi6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi6.ForeColor = System.Drawing.Color.White;
            this.lblSayi6.Location = new System.Drawing.Point(394, 34);
            this.lblSayi6.Name = "lblSayi6";
            this.lblSayi6.Size = new System.Drawing.Size(60, 60);
            this.lblSayi6.TabIndex = 16;
            this.lblSayi6.Text = "23";
            this.lblSayi6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi5
            // 
            this.lblSayi5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi5.ForeColor = System.Drawing.Color.White;
            this.lblSayi5.Location = new System.Drawing.Point(328, 34);
            this.lblSayi5.Name = "lblSayi5";
            this.lblSayi5.Size = new System.Drawing.Size(60, 60);
            this.lblSayi5.TabIndex = 15;
            this.lblSayi5.Text = "23";
            this.lblSayi5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi4
            // 
            this.lblSayi4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi4.ForeColor = System.Drawing.Color.White;
            this.lblSayi4.Location = new System.Drawing.Point(262, 34);
            this.lblSayi4.Name = "lblSayi4";
            this.lblSayi4.Size = new System.Drawing.Size(60, 60);
            this.lblSayi4.TabIndex = 14;
            this.lblSayi4.Text = "23";
            this.lblSayi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi3
            // 
            this.lblSayi3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi3.ForeColor = System.Drawing.Color.White;
            this.lblSayi3.Location = new System.Drawing.Point(196, 34);
            this.lblSayi3.Name = "lblSayi3";
            this.lblSayi3.Size = new System.Drawing.Size(60, 60);
            this.lblSayi3.TabIndex = 13;
            this.lblSayi3.Text = "23";
            this.lblSayi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.ForeColor = System.Drawing.Color.White;
            this.lblSayi2.Location = new System.Drawing.Point(130, 34);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(60, 60);
            this.lblSayi2.TabIndex = 12;
            this.lblSayi2.Text = "23";
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi1
            // 
            this.lblSayi1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.ForeColor = System.Drawing.Color.White;
            this.lblSayi1.Location = new System.Drawing.Point(64, 34);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(60, 60);
            this.lblSayi1.TabIndex = 11;
            this.lblSayi1.Text = "23";
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(306, 24);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(226, 16);
            this.lblZaman.TabIndex = 15;
            this.lblZaman.Text = "Bir sonraki çekilişe kalan süre: xxx sn";
            // 
            // FrmSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.lblCekiliseKatilanKuponlarim);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.dgvKuponlarim);
            this.Controls.Add(this.pnlSonuclar);
            this.Controls.Add(this.lblMesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonuç";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponlarim)).EndInit();
            this.pnlSonuclar.ResumeLayout(false);
            this.pnlSonuclar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Label lblCekiliseKatilanKuponlarim;
        private System.Windows.Forms.DataGridView dgvKuponlarim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel pnlSonuclar;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblCekilisTarihi;
        private System.Windows.Forms.Label lblSayi6;
        private System.Windows.Forms.Label lblSayi5;
        private System.Windows.Forms.Label lblSayi4;
        private System.Windows.Forms.Label lblSayi3;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
    }
}