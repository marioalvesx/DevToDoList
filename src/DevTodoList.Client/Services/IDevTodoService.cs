using DevTodoList.Client.Models;

namespace DevTodoList.Client.Services
{
    public class IDevTodoService
    {
        Task<List<DevTodo>> GetAll();
    }
}