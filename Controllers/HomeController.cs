using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FatihTuna.Models;
using Microsoft.AspNetCore.Authorization;

namespace FatihTuna.Controllers
{
    public class HomeController : Controller
    {
        readonly FatihTunaContext _context;
        

        public HomeController(FatihTunaContext context)
        {
            _context = context;
        }
        
        
        public ActionResult Index()
        {
            
            List<object> myModel = new List<object>();
            myModel.Add(_context.Post.ToList());

            return View(myModel);
        }

        public IActionResult About()
        {
            

            return View();
        }

        public IActionResult Contact()
        {
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
