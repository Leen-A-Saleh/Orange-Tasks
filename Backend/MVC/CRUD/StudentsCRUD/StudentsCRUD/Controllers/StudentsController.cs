using Microsoft.AspNetCore.Mvc;
using StudentsCRUD.Data;
using StudentsCRUD.Models;

namespace StudentsCRUD.Controllers
{
    public class StudentsController : Controller
    {
        ApplicationDbContext Context = new ApplicationDbContext();
        //--------------------------------CRUD operations----------------//

        //---------------------------------read-------------------------//
        //read---------------------------
        public ViewResult Index()
        {
            var students = Context.Students.ToList();
            return View("Index", students);
        }

        //details action----------------
        public IActionResult Details(int id)
        {
            var student = Context.Students.Find(id);
            if (student is null) return View("NotFound");
            return View("Details", student);
        }

        //---------------------------------create-----------------------//
        //create action-------------------------
        [HttpGet]
        public ViewResult Create()
        {
             return View(new Student());
        }
        //Add action----------------------
        [HttpPost]
        public IActionResult Create(Student request)
        {
            //validation-----------------------
            if (ModelState.IsValid)
            {
                Context.Students.Add(request);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create",request);
            }

        }

        //---------------------------------delet-----------------------//
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var std = Context.Students.Find(id);

            if(std is null) return View("NotFound");
            
            Context.Students.Remove(std);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        //---------------------------------update-----------------------//
        [HttpGet]
        public IActionResult Update(int id)
        {
            var std = Context.Students.Find(id);
            if(std is null) return View("NotFound");
            return View(std);
        }

        [HttpPost]
        public IActionResult Update(Student request)
        {
            var existing = Context.Students.Any(s => s.Email == request.Email && s.Id != request.Id);

            if(!ModelState.IsValid)
            {
               return View("Update",request);
            }
            if (existing)
            {
                ModelState.AddModelError("Email","Email already exists");
                return View("Update", request);
            }
            Context.Students.Update(request);
            Context.SaveChanges();
            return RedirectToAction("Index");
           
        }
    }
}