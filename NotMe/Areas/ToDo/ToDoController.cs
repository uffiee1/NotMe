using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NotMe.BusinessLogic.Services;
using NotMe.DataAccess;
using NotMe.Models;

namespace NotMe.Areas.User.Controllers
{
    [Area("Todo")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private ITodoServices _todosServices;

        public TodoController(ILogger<TodoController> logger, ITodoServices todosServices)
        {
            _logger = logger;
            _todosServices = todosServices;
        }

        [HttpGet]
        public IActionResult GetToDos()
        {
            return Ok(_todosServices.GetTodos());
        }

        [HttpGet("{id}", Name = "GetToDo")]
        public IActionResult GetToDo(int id)
        {
            return Ok(_todosServices.GetTodo(id));
        }

        [HttpPost]
        public IActionResult CreateToDo(ToDo todo)
        {
            var newToDo = _todosServices.CreateTodo(todo);
            return CreatedAtRoute("GetToDo", new { newToDo.ToDoId }, newToDo);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteToDo(int id)
        {
            _todosServices.DeleteTodo(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditToDo([FromBody] ToDo todo)
        {
            _todosServices.EditTodo(todo);
            return Ok();
        }
    }
}
