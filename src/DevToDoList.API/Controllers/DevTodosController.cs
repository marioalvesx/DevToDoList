using DevToDoList.API.Entities;
using DevToDoList.API.Models;
using DevToDoList.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DevToDoList.API.Controllers
{
    [ApiController]
    [Route("api/dev-todo")]
    public class DevTodosController : ControllerBase
    {
        private readonly DevTodoDbContext _context;

        public DevTodosController(DevTodoDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var devTodos = _context.DevTodos.ToList();

            return Ok(devTodos);
        }

        // api/dev-todo/1 HTTP GET
        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            // Talvez retornar NoteFound
            var devTodo = _context.DevTodos
                .Include(s => s.Reactions)
                .SingleOrDefault(s => s.Id == id);

            if (devTodo == null)
                return NotFound();
            return Ok(devTodo);
        }

        // api/dev-todo HTTP POST
        [HttpPost]
        public IActionResult Post(DevTodoInputModel model) {
            // Talvez retornar BadRequest
            var devTodo = new DevTodo(model.Title, model.Description, model.Done);

            _context.DevTodos.Add(devTodo);
            _context.SaveChanges();

            return CreatedAtAction("GetById", new { id = devTodo.Id }, model);
        }

        // api/dev-todo/1/reactions HTTP POST
        [HttpPost("{id}/reactions")]
        public IActionResult PostReaction(int id, ReactionDevTodoInputModel model) {
            // Talvez NotFound / Bad Request
            var devTodo = _context.DevTodos.SingleOrDefault(s => s.Id == id);

            if (devTodo == null)
                return BadRequest();

            devTodo.AddReaction(model.IsPositive);

            _context.SaveChanges();
            return NoContent();
        }

    }
}