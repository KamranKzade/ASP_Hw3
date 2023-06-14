using ASP_Hw3.Entities;
using ASP_Hw3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ASP_Hw3.Controllers
{
    public class StudentController : Controller
    {
        public readonly IStudentServices _studentService;

        public StudentController(IStudentServices studentService)
        {
            _studentService = studentService;
        }

        // GET: StudentController
        public async Task<IActionResult> Index(string key = "")
        {
            return View(await _studentService.GetAllByKey(key));
        }

        // GET: StudentController/Details/5
        public  ActionResult Details(int id)
        {
            var data = _studentService.GetByIdAsync(id);
            return View(data);
        }


        [HttpPost]
        public IActionResult Add(Student model)
        {
            if (ModelState.IsValid)
            {
                _studentService.Add(model);
                return RedirectToAction("index");
            }
            else
            {
                return View(model);
            }
        }


        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_studentService.Update(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_studentService.GetByIdAsync(id));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
