using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.HarbiLoto
{
    public class Kullanici
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string KullaniciAdi { get; set; }
    }
}
