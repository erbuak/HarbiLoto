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
    public partial class FrmSonuc : Form
    {
        Kullanici kullanici;
        List<int> sansliSayilar = new List<int>();
        List<Kupon> kuponlar;
        List<Kupon> kuponlarim;
        Cekilis sonCekilis;

        public FrmSonuc(Kullanici kullanici)
        {
            
            InitializeComponent();
            this.kullanici = kullanici;
            SayfaOlustur();

        }

        public void SayfaOlustur()
        {
            kuponlar = DbContext.Kuponlar;
            sonCekilis = DbContext.Cekilisler[DbContext.Cekilisler.Count - 1];
            dgvKuponlarim.AutoGenerateColumns = false;
            sansliSayilar = sonCekilis.SansliSayilar;
            
            lblMesaj.Text = "Bu sayfada en son yapılan çekiliş sonuçlarını görebilirsin. Her yeni çekiliş yapıldığında sayfa kendisini otomatik olarak yenileyecektir. Çekilişe katılan kuponların kısmında arka planı yeşil olan sayılar ilgili kuponda doğru tahmin ettiğin sayıları gösterir.";
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            this.Text = sonCekilis.CekilisTarihi.ToString() + " Tarihli Çekiliş Sonuçları";
            lblCekilisTarihi.Text = "Çekiliş Tarihi: " + sonCekilis.CekilisTarihi.ToString();
            lblCekiliseKatilanKuponlarim.Text = sonCekilis.CekilisTarihi.ToString() + " Tarihli Çekilişe Katılan Kuponların";
            KuponlarimiYukle();
            if (DbContext.Cekilisler.Count >= 1)
            {
                lblSayi1.Text = sansliSayilar[0].ToString();
                lblSayi2.Text = sansliSayilar[1].ToString();
                lblSayi3.Text = sansliSayilar[2].ToString();
                lblSayi4.Text = sansliSayilar[3].ToString();
                lblSayi5.Text = sansliSayilar[4].ToString();
                lblSayi6.Text = sansliSayilar[5].ToString();
            }
        }

        public void SayfaYenile(object sender, EventArgs e)
        {
            SayfaOlustur();
        }

        public void KuponlarimiYukle()
        {
            if (DbContext.Cekilisler.Count < 2)
            {
                kuponlarim = kuponlar.Where(x => x.Kullanici.Id == kullanici.Id &&
                                   x.CekilisId == sonCekilis.CekilisId).ToList();
            }
            else
            {
                kuponlarim = kuponlar.Where(x => x.Kullanici.Id == kullanici.Id &&
                                   x.CekilisId == sonCekilis.CekilisId).ToList();
            }
            dgvKuponlarim.DataSource = null;
            dgvKuponlarim.DataSource = kuponlarim;
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
        }

        private void dgvKuponlarim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex > 1 && e.Value != null)
            {
                foreach(int sansliSayi in sansliSayilar)
                {
                    if(sansliSayi == Convert.ToInt32(e.Value))
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                }         
            }
        }
    }
}
