using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {

        [HttpGet]
        public IActionResult Index() => View();


    }
}