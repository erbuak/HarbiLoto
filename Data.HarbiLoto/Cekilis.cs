using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.HarbiLoto
{
    public class Cekilis
    {
        private readonly Random rnd = new Random();

        public Cekilis(string cekilisId)
        {
            SansliSayilar.Clear();       
            CekilisYap();
            SansliSayilar.Sort();
            Sayi1 = SansliSayilar[0];
            Sayi2 = SansliSayilar[1];
            Sayi3 = SansliSayilar[2];
            Sayi4 = SansliSayilar[3];
            Sayi5 = SansliSayilar[4];
            Sayi6 = SansliSayilar[5];
            CekilisId = cekilisId;
        }

        public string CekilisId { get; }
        public DateTime CekilisTarihi { get; } = DateTime.Now;
        public List<int> SansliSayilar { get; } = new List<int>();
        public int Sayi1 { get; }
        public int Sayi2 { get; }
        public int Sayi3 { get; }
        public int Sayi4 { get; }
        public int Sayi5 { get; }
        public int Sayi6 { get; }

        public void CekilisYap()
        {
            int temp;

            for (int i = 0; i < 6;)
            {
                temp = rnd.Next(1, 51);
                if (!SansliSayilar.Contains(temp))
                {
                    SansliSayilar.Add(temp);
                    i++;
                }
            }
        }
    }
}
