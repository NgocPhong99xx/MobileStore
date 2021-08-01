using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CuaHangDienThoai.Areas.Customer.Controllers
{
    public class ContactController : Controller
    {
        [Area("Customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}