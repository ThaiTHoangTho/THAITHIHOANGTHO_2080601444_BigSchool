using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories=_context.Categories.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( CourseViewModel viewmodel)
        {
            if(!ModelState.IsValid)
            {
                viewmodel.Categories = _context.Categories.ToList();
                return View("Create", viewmodel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewmodel.GetDateTime(),
                CategoryId = viewmodel.Category,
                Place = viewmodel.Place,
            };
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");

        }
    }
}