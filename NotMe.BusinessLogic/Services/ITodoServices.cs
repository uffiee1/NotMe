using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotMe.Models;

namespace NotMe.BusinessLogic.Services
{
    public interface ITodoServices
    {
        ToDo CreateTodo(ToDo todo);

        ToDo GetTodo(int id);

        List<ToDo> GetTodos();

        void DeleteTodo(int id);

        void EditTodo(ToDo todo);
    }
}
