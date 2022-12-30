using DevTodoList.Client.Models;

namespace DevTodoList.Client.Services
{
    public interface IDevTodoService
    {
        List<DevTodo> DevTodo { get; set; }
        Task GetAll();
        Task AddTodo(DevTodo devTodo);
        Task<DevTodo> GetById(int id);
    }
}