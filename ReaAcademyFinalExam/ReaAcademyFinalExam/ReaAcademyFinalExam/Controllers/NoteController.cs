using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReaAcademyFinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ReaAcademyFinalExam.Controllers
{
    public class NoteController : Controller
    {
        private readonly ILogger<NoteController> _logger;
        private readonly NoteContext _noteContext;

        public NoteController(ILogger<NoteController> logger, NoteContext context)
        {
            _logger = logger;
            _noteContext = context;
        }
        public IActionResult Index()
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
