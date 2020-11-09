using System.Collections.Generic;
using System.Threading.Tasks;
using NotMe.Models.Interface;

namespace NotMe.Models.Logic
{
    public class ToDoLogic : IToDoLogic
    {
        
        private IEnumerable<ToDo> _result;

        public ToDoLogic()
        {
            //TODO: Hier komt de data van uit database
        } 

        public async Task<ToDo> CreateToDo(ToDo model)
        {
            
            return model;
        }

        public async Task<IEnumerable<ToDo>> GetAllToDoList(ToDo model)
        {
           
            return _result;
        }

        public async Task<IEnumerable<ToDo>> GetAllToDoListAsUser(ToDo model)
        { 
            return _result;
        }

        public async Task<ToDo> DeleteToDo(ToDo model)
        {
            return model;
        }

        public async Task<ToDo> EditToDo(ToDo model)
        {
            return model;
        }
    }
}
