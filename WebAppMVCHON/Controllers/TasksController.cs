using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMVCHON.Models;
using WebAppMVCHON.Repos;

namespace WebAppMVCHON.Controllers
{
    public class TasksController : Controller
    {
        public readonly DatabaseContext _dbContext;
        public TasksController(DatabaseContext context)
        {

            _dbContext = context;
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.res = new SelectList(_dbContext.Users, "UserId", "UserId");
            return View();
        }

        [HttpPost]

        public IActionResult AddTask(UsersTask obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.UsersTask.Add(obj);
                var res = _dbContext.SaveChanges();
                if (res > 0)
                {
                    return RedirectToAction("TaskList");
                }
                else
                {
                    TempData["res"] = "some thing went wrong";
                    return View();
                }
            }
            return View();

        }

        [HttpGet]
        public IActionResult TaskList()
        {
            var res = _dbContext.UsersTask.Include(x => x.AssignedUser).ToList();
            return View(res);
        }

    }
}
