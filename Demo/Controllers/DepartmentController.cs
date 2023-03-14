using Demo.Bl.Models;
using Demo.Bl.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRap department =new DepartmentRap();
        public IActionResult Index()
        {


            var data = department.Get();

            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return View(model);
                }
                department.Create(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex )
            {
                return View(model);
            }
        }
    }
}
