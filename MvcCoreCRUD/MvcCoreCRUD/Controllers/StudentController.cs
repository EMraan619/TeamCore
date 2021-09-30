using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCRUD.Controllers
{
    public class StudentController : Controller
    {
        const string Username = "";
        IStudentRepo repo;
        public StudentController(IStudentRepo _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(Mapper.Map(repo.GetStudents()));
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                repo.Add(Mapper.Map(student),Mapper.MapUser(student));
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            if (id > 0)
            {
                var data = repo.GetStudentById(id);
                if (data != null)
                {
                    return View(Mapper.Map(data));
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");

            }
        }
        [HttpPost]
        public IActionResult Update(StudentModel student)
        {
            var  uname= HttpContext.Session.GetString(Username);
            if (uname != null)
            {
                if (ModelState.IsValid)
                {
                    repo.Edit(Mapper.Map(student));
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(student);

                }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult Delete(int id)
        {
            repo.DeleteStudentById(id);
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(StudentModel student)
        {
            var data=repo.ValidateUser(Mapper.MapUser(student));
            if (data!=null)
            {
                
                HttpContext.Session.SetString(Username,data.Username);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Username & Password is not Correct";
                return View();
            }
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
