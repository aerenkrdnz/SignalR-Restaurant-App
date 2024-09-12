using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
