using Microsoft.AspNetCore.Mvc;
using WebAppMVCHON.Models;
using WebAppMVCHON.Repos;

namespace WebAppMVCHON.Controllers
{
    public class UsersOpsController : Controller
    {
        public readonly IUserInterface _iuser;
        public UsersOpsController(IUserInterface iuser)
        {
            _iuser = iuser;
        }

        [HttpGet]
        public async Task<IActionResult> UsersList()
        {

            // we dont write get logic , ibsted will call a method from Iuserclass repo
            var res = await _iuser.GetAllUsers();
            return View(res);
        }


        [HttpGet]
        public IActionResult CreateUsers()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsers(Users data)
        {
            if (ModelState.IsValid) // verifies that it is passing all my validation , bool
            {
                await _iuser.InsertUser(data);
                await _iuser.SaveAsync();
                return RedirectToAction("UsersList");
            }
            return View(data);
        }
    }
}
