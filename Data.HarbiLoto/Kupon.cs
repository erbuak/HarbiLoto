using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.HarbiLoto
{
    public class Kupon
    {
        public Kupon(Kullanici kullanici, List<int> oynananSayilar, string cekiliId)
        {
            OynananSayilar = oynananSayilar;
            Kullanici = kullanici;
            CekilisId = cekiliId;

            oynananSayilar.Sort();
            Sayi1 = oynananSayilar[0];
            Sayi2 = oynananSayilar[1];
            Sayi3 = oynananSayilar[2];
            Sayi4 = oynananSayilar[3];
            Sayi5 = oynananSayilar[4];
            Sayi6 = oynananSayilar[5];
        }

        public string CekilisId { get; set; }
        public DateTime KuponTarihi { get; } = DateTime.Now;
        public DateTime CekilisTarihi { get; } = DateTime.Now.AddMinutes(1);
        public List<int> OynananSayilar { get; }
        public Kullanici Kullanici { get; }
        public int Sayi1 { get; }
        public int Sayi2 { get; }
        public int Sayi3 { get; }
        public int Sayi4 { get; }
        public int Sayi5 { get; }
        public int Sayi6 { get; }
    }
}
