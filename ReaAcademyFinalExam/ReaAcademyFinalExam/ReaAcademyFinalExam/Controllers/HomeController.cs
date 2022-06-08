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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoteContext _noteContext;

        public HomeController(ILogger<HomeController> logger, NoteContext context)
        {
            _logger = logger;
            _noteContext = context;
        }
        //  ## Adding and Deleting Categories ##
        public async Task<IActionResult> AddCategory(Categories category)
        {
            await _noteContext.AddAsync(category);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        public IActionResult Category()
        {
            List<Categories> categories = _noteContext.Categories.ToList();
            return View(categories);
        }
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            Categories category = await _noteContext.Categories.FindAsync(id);
            _noteContext.Remove(category);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Category));
        }
        //  ## Adding and Deleting Tags ##
        public async Task<IActionResult> AddTags(Tags tag) 
        {
            await _noteContext.AddAsync(tag);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Tag));
        }
        public IActionResult Tag()
        {
            List<Tags> tags = _noteContext.Tags.ToList();
            return View(tags);
        }
        public async Task<IActionResult> DeleteTags(int? id)
        {
            Tags tag = await _noteContext.Tags.FindAsync(id);
            _noteContext.Remove(tag);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Tag));
        }
        public async Task<IActionResult> AddNotes(Notes note)
        {
            await _noteContext.AddAsync(note);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Note));
        }
        public IActionResult Note()
        {
            List<Notes> note = _noteContext.Notes.ToList();
            return View(note);
        }
        public async Task<IActionResult> DeleteNotes(int? id)
        {
            Notes note = await _noteContext.Notes.FindAsync(id);
            _noteContext.Notes.Remove(note);
            await _noteContext.SaveChangesAsync();
            return RedirectToAction(nameof(Note));
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
