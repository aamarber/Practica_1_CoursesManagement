using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoursesManagement.Web.Models;
using CoursesManagement.Services;

namespace CoursesManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICourseService courseService;

        public HomeController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await this.courseService.GetCourses();

            return View(courses);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var course = await this.courseService.GetCourse(id);

            return View(course);
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
