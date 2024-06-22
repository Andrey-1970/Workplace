using System.Net.Http.Json;
using Workplace.Shared;

namespace Workplace.Client.Data
{
    public class HttpMockData(HttpClient httpClient) : IDataService
    {
        public async Task DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItemDTO>> GetAllAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<TaskItemDTO>>("https://localhost:7294/Task") ?? [];
        }

        public async Task<TaskItemDTO> GetTaskItemAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(TaskItemDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
