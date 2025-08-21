using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class CoordinatorController : Controller
    {
        // GET: /Coordinator/ViewClaims
        public IActionResult ViewClaims()
        {
            return View();
        }
    }
}