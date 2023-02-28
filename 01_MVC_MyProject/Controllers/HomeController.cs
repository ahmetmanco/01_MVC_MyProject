using _01_MVC_MyProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_MVC_MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id= 1,Name="Ahmet",LastName="Gündüz"},
                new Employee() {Id= 2,Name="Ahmet",LastName="İşler"},
                new Employee() {Id= 3,Name="Tunahan",LastName="Kılıç"},
                new Employee() {Id= 4,Name="Baturhan",LastName="Aykut"},
                new Employee() {Id= 5,Name="Halil Can",LastName="Korkmaz"},
                new Employee() {Id= 6,Name="Oguzhan",LastName="Gündüz"}
            };
            return View("employee",employees);
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        { return View(); }

        public IActionResult Edit()
        { return View(); }
    }
}