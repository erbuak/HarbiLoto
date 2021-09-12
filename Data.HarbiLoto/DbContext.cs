using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.HarbiLoto
{
    public class DbContext
    {
        static public List<Kullanici> Kullanicilar { get; set; } = new List<Kullanici>();
        static public List<Kupon> Kuponlar { get; set; } = new List<Kupon>();
        static public List<Cekilis> Cekilisler { get; set; } = new List<Cekilis>();
        static public int Dakika { get; set; } = 60;
        static public string CekilisId { get; set; }
    }
}
