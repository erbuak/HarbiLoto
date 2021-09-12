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
    public partial class FrmGeçmişSonuc : Form
    {
        readonly Kullanici kullanici;
        readonly Cekilis cekilis;
        readonly string cekilisId;
        readonly List<Cekilis> cekilisler = DbContext.Cekilisler;
        readonly List<Kupon> kuponlar = DbContext.Kuponlar;
        List<Kupon> kuponlarim;

        public FrmGeçmişSonuc(Kupon kupon)
        {
            InitializeComponent();
            kullanici = kupon.Kullanici;
            cekilisId = kupon.CekilisId;
            cekilis = cekilisler.SingleOrDefault(x => x.CekilisId == cekilisId);
            dgvKuponlarim.AutoGenerateColumns = false;
            lblSayi1.Text = cekilis.Sayi1.ToString();
            lblSayi2.Text = cekilis.Sayi2.ToString();
            lblSayi3.Text = cekilis.Sayi3.ToString();
            lblSayi4.Text = cekilis.Sayi4.ToString();
            lblSayi5.Text = cekilis.Sayi5.ToString();
            lblSayi6.Text = cekilis.Sayi6.ToString();
            lblMesaj.Text = "Bu sayfada geçmişte belirli bi tarihte yapılan çekiliş sonucu ve senin bu çekilişde oynadığın kuponlar yer alır.";
            lblCekiliseKatilanKuponlarim.Text = cekilis.CekilisTarihi.ToString() + " Tarihli Çekilişe Katılan Kuponların";
            lblCekilisTarihi.Text = "Çekiliş Tarihi: " + cekilis.CekilisTarihi.ToString();
            this.Text = this.Text = cekilis.CekilisTarihi.ToString() + " Tarihli Çekiliş Sonuçları";
            KuponlarimiYukle();
        }

        private void KuponlarimiYukle()
        {
            kuponlarim = kuponlar.Where(x => x.Kullanici.Id == kullanici.Id && x.CekilisId == cekilisId).ToList();
            dgvKuponlarim.DataSource = null;
            dgvKuponlarim.DataSource = kuponlarim;
        }

        private void dgvKuponlarim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > 1 && e.Value != null)
            {
                foreach (int sansliSayi in cekilis.SansliSayilar)
                {
                    if (sansliSayi == Convert.ToInt32(e.Value))
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                }
            }
        }
    }
}
