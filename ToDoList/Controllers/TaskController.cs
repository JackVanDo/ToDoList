using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Domain.ViewModels.Task;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
            public async Task<IActionResult> Create(CreateTaskViewModel model)
        {
            return Ok();
        }


    }
}