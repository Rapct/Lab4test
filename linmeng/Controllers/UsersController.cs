using Microsoft.AspNetCore.Mvc;
using linmeng.Models;
namespace linmeng.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult linView()
        {
            return View(uc.LinmengTables.ToList());
        }
    }
}
