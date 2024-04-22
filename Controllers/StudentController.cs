using Microsoft.AspNetCore.Mvc;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var studentInfo = _context.Students.ToList();
            return View(studentInfo);
        }
        [HttpGet]
        public IActionResult Add()
        {
            Student student = new Student();
            
            return View(student);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
                _context.Add(student);
                _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var studentinfo=_context.Students.FirstOrDefault(x => x.Id == id);
            return View(studentinfo);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == student.Id);

            studentinfo.FullName = student.FullName;
            studentinfo.RollNo = student.RollNo;
            studentinfo.PhoneNumber = student.PhoneNumber;
            studentinfo.Class = student.Class;

            _context.Update(studentinfo);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == id);
            _context.Remove(studentinfo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var studentinfo = _context.Students.FirstOrDefault(x => x.Id == id);
            return View(studentinfo);
        }
    }
}
