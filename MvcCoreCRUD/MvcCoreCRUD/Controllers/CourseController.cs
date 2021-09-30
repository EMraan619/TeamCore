using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using MvcCoreCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCRUD.Controllers
{
    public class CourseController : Controller
    {
        IStudentRepo repo;
        public CourseController(IStudentRepo _repo)
        {
            repo = _repo;
        }
        public IActionResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(CourseModel course,int id)
        {
            repo.AddCourse(Mapper.MapCourse(course, id));
            return RedirectToAction("Index", "Student");
        }
    }
}
