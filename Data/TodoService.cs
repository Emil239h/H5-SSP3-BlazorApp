using H5_SSP3_BlazorApp.Pages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace H5_SSP3_BlazorApp.Data
{
    public class TodoService
    {
        private readonly DataDbContext _context;

        public TodoService(DataDbContext context)
        {
            _context = context;
        }

        public List<Todo> Todos { get; set; } = new List<Todo>();

        public List<Todo>  GetTodos(string Username)
        {
            return _context.Todos.Where(x => x.Owner == Username).ToList();
        }
         
        public void AddTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();

        }

        public void RemoveTodo(Todo todo)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges();

        }
    }
}
