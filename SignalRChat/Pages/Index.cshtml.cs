using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SignalRChat.Hubs;

namespace SignalRChat.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //var HubContext = GlobalHost.ConnectionManager.GetHubContext <Hubclass>("/hubclass");
            //Hubclass HubObj = new Hubclass();
            //var RequiredId = HubObj.InvokeHubMethod();
        }
    }
}
