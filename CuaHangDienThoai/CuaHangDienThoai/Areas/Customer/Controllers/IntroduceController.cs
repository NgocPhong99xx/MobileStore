using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CuaHangDienThoai.Areas.Customer.Identity;

namespace CuaHangDienThoai.Areas.Customer.Controllers
{
    public class IntroduceController : Controller
    {
        [Area("Customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}