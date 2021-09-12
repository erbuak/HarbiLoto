using Data.HarbiLoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.HarbiLoto
{
    public partial class FrmAnaSayfa : Form
    {
        readonly Kullanici kullanici;
        readonly FrmAcilis frmAcilis;
        FrmSonuc frmSonuc;
        List<Kupon> kuponlarim;
        List<Cekilis> cekilisler;

        private event EventHandler YeniCekilis; 

        public FrmAnaSayfa(Kullanici kullanici,FrmAcilis frmAcilis)
        {
            this.kullanici = kullanici;
            this.frmAcilis = frmAcilis;
            InitializeComponent();      
            if(DbContext.Cekilisler.Count >= 1)
            {
                btnSonuclar.Enabled = true;
            }
            KuponlarimiYukle();       
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";        
            lblMesaj1.Text = "Merhaba " + kullanici.KullaniciAdi + ", \n\nİlk çekiliş yapıldıktan sonra aktif olacak olan 'Son Çekiliş Sonucu' sayfasından son yapılan çekiliş sonucunu görebilirsin. Bir sonraki çekilişe kadar 'Kupon Yap' sayfası üzerinden istediğin kadar kupon yapabilirsin. Aşağıdaki tabloda program çalıştığı süre boyunca oynadığın kuponların tamamı yer alacak. Çekilişi yapılmış olan herhangi bir kupona tıklayarak ilgili çekileşe katılan tüm kuponlarının sonuçlarını geçmişe dönük görebilirsin.";
        }
        
        public void KuponlarimiYukle()
        {
            dgvKuponlarim.AutoGenerateColumns = false;
            kuponlarim = DbContext.Kuponlar.Where(x => x.Kullanici.Id == kullanici.Id).ToList();
            kuponlarim.Reverse();
            dgvKuponlarim.DataSource = null;
            dgvKuponlarim.DataSource = kuponlarim;
        }

        private void btnKuponOlustur_Click(object sender, EventArgs e)
        {
            FrmKuponYap frmKuponYap = new FrmKuponYap(kullanici,this);
            frmKuponYap.Show();
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            frmSonuc = new FrmSonuc(kullanici);
            YeniCekilis += frmSonuc.SayfaYenile;
            frmSonuc.Show();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            
            if (DateTime.Now.Second == 0)
            {
                btnSonuclar.Enabled = true;

                YeniCekilis?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FrmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAcilis.Visible = true;
            frmAcilis.tmrZaman.Start();
        }

        private void dgvKuponlarim_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow satir = dgvKuponlarim.SelectedRows[0];
            Kupon kupon = (Kupon)satir.DataBoundItem;

            cekilisler = DbContext.Cekilisler;

            if(cekilisler.Any(x => x.CekilisId == kupon.CekilisId))
            {
                FrmGeçmişSonuc frmGeçmişSonuc = new FrmGeçmişSonuc(kupon);
                frmGeçmişSonuc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu kuponun çekilişi henüz yapılmamış.");
            }
        }
    }
}
