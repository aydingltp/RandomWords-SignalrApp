using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class Hubclass : Hub
    {
        //public int Id { get; set; }
        //public int Saniye { get; set; }
        //public int Dakika { get; set; }
        //public int Saat { get; set; }
        //public int Gun { get; set; }
        //public int Sayac { get; set; }
        //public string GelenDeger { get; set; }

        public async Task SayacGelen(int sayac, string gelendeger)
        {
            await Clients.All.SendAsync("Tesaduf", sayac, gelendeger);
            //Sayac = sayac;
            //GelenDeger = gelendeger;
        }
        public async Task ZamanMetot(int gun, int saat, int dakika, int saniye)
        {
            await Clients.All.SendAsync("Zaman", gun, saat, dakika, saniye);
            //Gun = gun;
            //Saat = saat;
            //Dakika = dakika;
            //Saniye = saniye;
        }
        //public string InvokeHubMethod()
        //{
        //    return "ConnectionId";  //ConnectionID will the Id as string that you want outside the hub
        //}
    }
}
