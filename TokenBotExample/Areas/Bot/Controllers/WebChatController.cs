using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TokenBotExample.Areas.Bot.Models;

namespace TokenBotExample.Areas.Bot.Controllers
{
    public class WebChatController : Controller
    {
        public ActionResult Index()
        {
            var vm = new WebChatModel();
            return View(vm);
        }
    }
}