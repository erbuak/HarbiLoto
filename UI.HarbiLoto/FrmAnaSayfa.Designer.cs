
namespace UI.HarbiLoto
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.btnKuponOlustur = new System.Windows.Forms.Button();
            this.btnSonuclar = new System.Windows.Forms.Button();
            this.dgvKuponlarim = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMesaj1 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponlarim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKuponOlustur
            // 
            resources.ApplyResources(this.btnKuponOlustur, "btnKuponOlustur");
            this.btnKuponOlustur.Name = "btnKuponOlustur";
            this.btnKuponOlustur.UseVisualStyleBackColor = true;
            this.btnKuponOlustur.Click += new System.EventHandler(this.btnKuponOlustur_Click);
            // 
            // btnSonuclar
            // 
            resources.ApplyResources(this.btnSonuclar, "btnSonuclar");
            this.btnSonuclar.Name = "btnSonuclar";
            this.btnSonuclar.UseVisualStyleBackColor = true;
            this.btnSonuclar.Click += new System.EventHandler(this.btnSonuclar_Click);
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
            resources.ApplyResources(this.dgvKuponlarim, "dgvKuponlarim");
            this.dgvKuponlarim.MultiSelect = false;
            this.dgvKuponlarim.Name = "dgvKuponlarim";
            this.dgvKuponlarim.ReadOnly = true;
            this.dgvKuponlarim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKuponlarim.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKuponlarim_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "KuponTarihi";
            this.Column1.FillWeight = 200F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CekilisTarihi";
            this.Column8.FillWeight = 200F;
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sayi1";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sayi2";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Sayi3";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sayi4";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Sayi5";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sayi6";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblMesaj1
            // 
            resources.ApplyResources(this.lblMesaj1, "lblMesaj1");
            this.lblMesaj1.Name = "lblMesaj1";
            // 
            // lblZaman
            // 
            resources.ApplyResources(this.lblZaman, "lblZaman");
            this.lblZaman.Name = "lblZaman";
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // lblMesaj2
            // 
            resources.ApplyResources(this.lblMesaj2, "lblMesaj2");
            this.lblMesaj2.Name = "lblMesaj2";
            // 
            // FrmAnaSayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMesaj2);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblMesaj1);
            this.Controls.Add(this.dgvKuponlarim);
            this.Controls.Add(this.btnSonuclar);
            this.Controls.Add(this.btnKuponOlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaSayfa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuponlarim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKuponOlustur;
        private System.Windows.Forms.Button btnSonuclar;
        private System.Windows.Forms.DataGridView dgvKuponlarim;
        private System.Windows.Forms.Label lblMesaj1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblMesaj2;
    }
}