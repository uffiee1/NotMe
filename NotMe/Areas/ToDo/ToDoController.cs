using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotMe.BusinessLogic.ToDoLogic.Interfaces;
using NotMe.DataAccess;

namespace NotMe.Controllers.ToDo
{
    [Area("ToDo")]
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IToDoLogic _toDoLogic;

        public ToDoController(IToDoLogic toDoLogic)
        {
            _toDoLogic = toDoLogic;
        }
    }
}
