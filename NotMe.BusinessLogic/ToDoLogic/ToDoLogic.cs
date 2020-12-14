﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotMe.BusinessLogic.ToDoLogic.Interfaces;
using NotMe.DataAccess;
using NotMe.Models;

namespace NotMe.BusinessLogic.ToDoLogic
{
    public class ToDoLogic : IToDoLogic
    {
        private readonly AppDbContext _context;
        private IEnumerable<ToDo> _result;

        public ToDoLogic(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ToDo> CreateToDo(ToDo model)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<IEnumerable<ToDo>> GetAllToDoList(ToDo model)
        {
            _result = await _context.ToDo.ToListAsync();
            return _result;
        }

        public async Task<IEnumerable<ToDo>> GetAllToDoListAsUser(ToDo model)
        {
            _result = await _context.ToDo.Where(todo => todo.UserId == model.UserId).ToListAsync();
            return _result;
        }

        public async Task<ToDo> DeleteToDo(ToDo model)
        {
            _context.ToDo.Remove(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<ToDo> EditToDo(ToDo model)
        {
            _context.Update(model);
            await _context.SaveChangesAsync();

            return model;
        }
    }
}
