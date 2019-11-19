using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private int executionCount = 0;
        private readonly ILogger<TimedHostedService> _logger;
        private Hubclass hubsentity = new Hubclass();
        private Timer _timer;
        //private Timer _timer2;
        private int sayac;

        Zaman time = new Zaman();

        public TimedHostedService(ILogger<TimedHostedService> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            //_logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(1));
            //_timer2 = new Timer(DoWork2, null, TimeSpan.Zero,
            //    TimeSpan.FromMilliseconds(1));

            return Task.CompletedTask;
        }
        //private void DoWork2(object state)
        //{
        //    var harfler = " .AaBbCcÇçDdEeFfGgĞğHhİiIıJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZz";
        //    var stringChars = new char[27];
        //    var random = new Random();

        //    for (int i = 0; i < stringChars.Length; i++)
        //    {
        //        stringChars[i] = harfler[random.Next(harfler.Length)];
        //    }
        //    var finalString = new String(stringChars);
        //    sayac = sayac + 1;
        //    hubsentity.SayacGelen(sayac, finalString);
        //    //return finalString;
        //}

        private void DoWork(object state)
        {
            executionCount++;
            if ((time.Saniye == 59))
            {
                time.Saniye = 0;
                time.Dakika = time.Dakika + 1;
                if (time.Dakika == 60)
                {
                    time.Saniye = 0;
                    time.Dakika = 0;
                    time.Saat = time.Saat + 1;
                    if (time.Saat == 24)
                    {
                        time.Saniye = 0;
                        time.Dakika = 0;
                        time.Saat = 0;
                        time.Gun = time.Gun + 1;
                    }
                }
            }
            time.Saniye = time.Saniye + 1;
            //string dd = "688976ed-214e-4201-8d45-9b576f221890";
            hubsentity.ZamanMetot(time.Gun, time.Saat, time.Dakika, time.Saniye);
            //_logger.LogInformation(
            //    "Timed Hosted Service is working. Count: {Count}", executionCount);
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            //_logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
