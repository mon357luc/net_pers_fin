using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using net_pers_fin.Data;
using net_pers_fin.Models;

namespace net_pers_fin.Controllers
{
    public class LoginController : Controller
    {
        private readonly net_pers_fin_context _context;

        public LoginController(net_pers_fin_context context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Index() => View();
    }
}
