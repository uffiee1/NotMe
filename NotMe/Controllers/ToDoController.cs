using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotMe.Models;
using NotMe.Models.Interface;

namespace NotMe.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoLogic _toDoLogic;

        public ToDoController(IToDoLogic toDoLogic)
        {
            _toDoLogic = toDoLogic;
        }

        public async Task<IActionResult> Index(ToDo model)
        {
            return View();
        }
    }
}
