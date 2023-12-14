using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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


        /// <summary>
        /// Метод отображения всех сотрудников
        /// </summary>
        public IActionResult Employees()
        {
            return View(_employees);
        }

        /// <summary>
        /// Метод отображения данных одного сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Employee(int id)
        {
            var employee = _employees.FirstOrDefault(emp => emp.Id == id);
            
            if (employee is null) 
                return NotFound();

            return View(employee);
        }
    }
}
