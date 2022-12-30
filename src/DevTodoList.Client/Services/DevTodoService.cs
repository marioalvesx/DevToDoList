using System.Net.Http.Json;
using DevTodoList.Client.Models;

namespace DevTodoList.Client.Services
{
    public class DevTodoService : IDevTodoService
    {
        private readonly HttpClient _http;
        private readonly string apiConnection = "http://localhost:5097";
        public List<DevTodo> DevTodo { get; set; } = new List<DevTodo>();

        public DevTodoService(HttpClient http) {
            _http = http;
        }

        public async Task GetAll() {
            var response = await _http.GetFromJsonAsync<List<DevTodo>>(apiConnection + "/api/dev-todo");
            if(response != null)
                DevTodo = response;
        }

        public async Task AddTodo(DevTodo todo) {
            // var addItem = new DevTodo { Title = title, Description = description, Done = done };
            var response = await _http.PostAsJsonAsync(apiConnection + "/api/dev-todo", todo);
            if(response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("Added todo!");
            }
        }

        public Task<DevTodo> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}