using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static List<Employees> _employees = new List<Employees>
            {
                new Employees {Id = 1, FirstName = "Иван", SurName = "Иванов", Patronymic = "Иванович", Age = 39},
                new Employees {Id = 2, FirstName = "Петр", SurName = "Петров", Patronymic = "Петрович", Age = 20},
                new Employees {Id = 3, FirstName = "Сидор", SurName = "Сидоров", Patronymic = "Сидорович", Age = 45},
            };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SomeAction()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(_employees);
        }
    }
}
