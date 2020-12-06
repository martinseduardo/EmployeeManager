using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}