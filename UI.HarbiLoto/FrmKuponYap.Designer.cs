
namespace UI.HarbiLoto
{
    partial class FrmKuponYap
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.pnlKupon = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.lblCekilisTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(298, 353);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(495, 57);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Visible = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // pnlKupon
            // 
            this.pnlKupon.Location = new System.Drawing.Point(12, 130);
            this.pnlKupon.Name = "pnlKupon";
            this.pnlKupon.Size = new System.Drawing.Size(280, 280);
            this.pnlKupon.TabIndex = 2;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(9, 60);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(784, 58);
            this.lblMesaj.TabIndex = 3;
            this.lblMesaj.Text = "Mesaj";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(271, 22);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(226, 16);
            this.lblZaman.TabIndex = 5;
            this.lblZaman.Text = "Bir sonraki çekilişe kalan süre: xxx sn";
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // lblCekilisTarihi
            // 
            this.lblCekilisTarihi.AutoSize = true;
            this.lblCekilisTarihi.Location = new System.Drawing.Point(298, 130);
            this.lblCekilisTarihi.Name = "lblCekilisTarihi";
            this.lblCekilisTarihi.Size = new System.Drawing.Size(128, 13);
            this.lblCekilisTarihi.TabIndex = 6;
            this.lblCekilisTarihi.Text = "Bu kuponun çekiliş tarihi: ";
            // 
            // FrmKuponYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.lblCekilisTarihi);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.pnlKupon);
            this.Controls.Add(this.btnOyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKuponYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupon Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Panel pnlKupon;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Label lblCekilisTarihi;
    }
}