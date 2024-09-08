using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.ViewModel;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        public static List<ToDo> todolist = new List<ToDo>();

        [HttpGet]
        public IEnumerable<ToDo> GetToDo()
        {
            return todolist;
        }

        [HttpPost]
        public IActionResult PostToDo(ToDo todo)
        {
            todolist.Add(todo);
            return Ok("Record added successfully");
        }

        [HttpDelete]
        public IActionResult DeleteToDo(int id) 
        {
            var todoData = todolist.Where(x=> x.id == id).FirstOrDefault();
            todolist.Remove(todoData);
            return Ok("Record deleted successfully");
        }
    }
}
