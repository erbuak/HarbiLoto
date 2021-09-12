using Data.HarbiLoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.HarbiLoto
{
    public partial class FrmAcilis : Form
    {
    
        Kullanici kullanici;
        FrmAnaSayfa frmAnaSayfa;
        bool boslukVar;

        public FrmAcilis()
        {
            InitializeComponent();
            txtKullaniciAdiKayit.Select();
            DbContext.CekilisId = Guid.NewGuid().ToString();
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            lblMesaj.Text = "Sen bu programı açar açmaz ilk çekiliş için geri sayım başladı. Her dakika yeni bir çekiliş yapılacak. Sen de şansını denemek istiyorsan giriş yap ve bir kupon oluştur. Bol şanslar :)\n\nNot: Bu sayfayı kapatmadığın sürece istediğin kadar kullanıcı oluşturabilir ve oluşturduğun bu kullanıcı hesaplarına giriş/çıkış yapabilirsin.";
        }

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            Kullanici kullaniciGirişYapan = new Kullanici();
            if (DbContext.Kullanicilar.Any(x => x.KullaniciAdi == txtKullaniciAdiGiris.Text))
            {
                kullanici = DbContext.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdiGiris.Text);
                frmAnaSayfa = new FrmAnaSayfa(kullanici,this);
                this.Hide();
                frmAnaSayfa.ShowDialog();          
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            foreach (char c in txtKullaniciAdiKayit.Text)
            {
                if (Char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Kullanıcı adı boşluk içeremez.");
                    boslukVar = true;
                    break;
                }
                else
                {
                    boslukVar = false;
                }
            }

            if(!boslukVar)
            {
                if (DbContext.Kullanicilar.Any(x => x.KullaniciAdi == txtKullaniciAdiKayit.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı ile kayıt yapılmış. Kendine başka bir kullanıcı adı seç.");
                }
                else
                {
                    kullanici = new Kullanici()
                    {
                        KullaniciAdi = txtKullaniciAdiKayit.Text,
                    };
                    DbContext.Kullanicilar.Add(kullanici);
                    txtKullaniciAdiKayit.Clear();
                    MessageBox.Show("Süper! Kayıt işlemin gerçekleti. Şimdi giriş yap ve şansını dene ;)");
                }
            }
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            if (DateTime.Now.Second == 0 && DbContext.Dakika != DateTime.Now.Minute)
            {
                DbContext.Dakika = DateTime.Now.Minute;     
                DbContext.Cekilisler.Add(new Cekilis(DbContext.CekilisId));
                DbContext.CekilisId = Guid.NewGuid().ToString();
            }
        }
    }
}
