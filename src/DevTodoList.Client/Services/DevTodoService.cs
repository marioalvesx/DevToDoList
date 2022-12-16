using DevTodoList.Client.Models;

namespace DevTodoList.Client.Services
{
    public class DevTodoService
    {
        private readonly HttpClient _httpClient;

        public DevTodoService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<List<DevTodo>> GetAll() {
            
        }

    }
}