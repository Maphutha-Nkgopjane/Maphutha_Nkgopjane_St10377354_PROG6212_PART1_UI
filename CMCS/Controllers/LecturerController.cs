using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class LecturerController : Controller
    {
        // GET: /Lecturer/Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: /Lecturer/SubmitClaim
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // GET: /Lecturer/UploadDocument
        public IActionResult UploadDocument()
        {
            return View();
        }
    }
}