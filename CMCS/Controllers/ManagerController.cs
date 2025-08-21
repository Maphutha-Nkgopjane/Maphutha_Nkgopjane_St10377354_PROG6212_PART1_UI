using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ManagerController : Controller
    {
        // GET: /Manager/ViewClaims
        public IActionResult ViewClaims()
        {
            return View();
        }
    }
}