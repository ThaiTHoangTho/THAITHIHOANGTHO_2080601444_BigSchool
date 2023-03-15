using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using THAITHIHOANGTHO_2080601444.Models;
using THAITHIHOANGTHO_2080601444.ViewModels;

namespace THAITHIHOANGTHO_2080601444.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories=_context.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}