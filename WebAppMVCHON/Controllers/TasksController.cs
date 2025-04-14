using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
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
            ViewBag.res = new SelectList(_dbContext.Users, "UserId","Username");
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

        [HttpGet]
        public IActionResult Edittask(int TaskId)
        {
            if (TaskId==null)
            {
                return NotFound();
            }
            var res = _dbContext.UsersTask.Find(TaskId);
            if (res==null)
            {
                return NotFound();
            }

            ViewBag.res = new SelectList(_dbContext.Users, "UserId", "UserId");
            return View(res);
        }

        [HttpPost]
        public IActionResult Edittask(UsersTask obj)
        {
            if (obj==null)
            {
                return BadRequest();
            }

            try
            {
                _dbContext.Update(obj);
                _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {

                throw ex;
            }
          
            return RedirectToAction("TaskList");
        }
    }
}
