using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotMe.Models.Interface
{
    public interface IToDoLogic
    {
        Task<ToDo> CreateToDo(ToDo model);

        Task<IEnumerable<ToDo>> GetAllToDoList(ToDo model);

        Task<IEnumerable<ToDo>> GetAllToDoListAsUser(ToDo model);

        Task<ToDo> DeleteToDo(ToDo model);

        Task<ToDo> EditToDo(ToDo model);
    }
}
