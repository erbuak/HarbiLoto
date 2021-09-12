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
    public partial class FrmKuponYap : Form
    {
        Button btn;
        readonly FrmAnaSayfa frmAnaSayfa;
        readonly Kullanici kullanici;
        readonly List<int> oynanSayilar = new List<int>();
        readonly List<Button> tumButonlar = new List<Button>();
        readonly List<Button> oynananButonlar = new List<Button>();
        string cekilisId;

        public FrmKuponYap(Kullanici kullanici,FrmAnaSayfa frmAnaSayfa)
        {
            this.kullanici = kullanici;
            this.frmAnaSayfa = frmAnaSayfa;
            
            InitializeComponent();
            KuponOlustur();
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            lblMesaj.Text = "Bi sonraki çekiliş yapılmadan 5 saniye öncesine kadar 6 sayıdan oluşan dilediğin kadar kupon yapabilirsin. Kuponu oluşturduktan sonra 'Oyna' butonu görünür olacak, bu buton ile kuponunu kaydetmeyi unutma. Çeklişe 5 saniye kala kupon oluşturma bölümü ve oyna butonu, bir sonraki çekiliş geri sayımına kadar aktifliğini yitirecektir.";
            lblCekilisTarihi.Text = "Bu kuponun çekiliş tarihi: " + DateTime.Now.AddMinutes(1).ToString("MM/dd/yyyy HH:mm");
        }

        private void KuponOlustur()
        {
            oynanSayilar.Clear();
            tumButonlar.Clear();
            oynananButonlar.Clear();
          
            int sayac = 1;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    btn = new Button();
                    btn.Text = sayac.ToString();
                    btn.Size = new Size(40, 40);
                    btn.Left = (j -1) * 40;
                    btn.Top = (i - 1) * 40;
                    btn.Tag = sayac;
                    btn.BackColor = Color.DeepSkyBlue;
                    pnlKupon.Controls.Add(btn);
                    sayac++;
                    btn.Click += Btn_Click;
                    tumButonlar.Add(btn);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.DeepSkyBlue;
                foreach (var btnTum in tumButonlar)
                {
                    oynananButonlar.Remove(btn);
                    oynanSayilar.Remove((int)btn.Tag);
                    btnTum.Enabled = true;
                    btnOyna.Hide();
                }
            }
            else
            {
                oynananButonlar.Add(btn);
                oynanSayilar.Add((int)btn.Tag);
                btn.BackColor = Color.Red;
                AdetKontrolEt();
            }
        }

        private void AdetKontrolEt()
        {
            if (oynanSayilar.Count == 6)
            {
                btnOyna.Show();
                foreach (Button btnTum in tumButonlar)
                {
                    foreach (Button btnOynanan in oynananButonlar)
                    {
                        if ((int)btnTum.Tag != (int)btnOynanan.Tag)
                        {
                            btnTum.Enabled = false;
                            btnOynanan.Enabled = true;
                        }
                    }
                }
            }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Kupon kupon = new Kupon(kullanici, oynanSayilar, cekilisId);
            DbContext.Kuponlar.Add(kupon);
            frmAnaSayfa.KuponlarimiYukle();
            btnOyna.Hide();
            pnlKupon.Controls.Clear();
            KuponOlustur();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = "Bir sonraki çekilişe kalan süre: " + (59 - DateTime.Now.Second).ToString() + " sn";
            lblCekilisTarihi.Text = "Bu kuponun çekiliş tarihi: " + DateTime.Now.AddMinutes(1).ToString("MM/dd/yyyy HH:mm");
            cekilisId = DbContext.CekilisId;
            if (DateTime.Now.Second >= 54)
            {
                pnlKupon.Enabled = false;
                btnOyna.Enabled = false;
            }
            else
            {
                pnlKupon.Enabled = true;
                btnOyna.Enabled = true;
            }
        }
    }
}
