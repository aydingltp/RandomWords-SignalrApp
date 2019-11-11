using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class Zaman
    {
        public int Id { get; set; }
        public int Saniye { get; set; }
        public int Dakika { get; set; }
        public int Saat { get; set; }
        public int Gun { get; set; }
        public int Sayac { get; set; }
        public string GelenDeger { get; set; }
    }
}
