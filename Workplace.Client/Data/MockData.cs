
using Workplace.Shared;

namespace Workplace.Client.Data
{
    public class MockData : IDataService
    {
        private readonly List<TaskItemDTO> tasks = [
            new TaskItemDTO() { Id = 1, Name = "Задача 1", Description = "Описание 1"},
            new TaskItemDTO() { Id = 2, Name = "Задача 2", Description = "Описание 2"},
            new TaskItemDTO() { Id = 3, Name = "Задача 3", Description = "Описание 3"},
        ];
        public async Task AddAsync(TaskItemDTO dto)
        {
            await Task.Run(() => tasks.Add(dto));
        }

        public async Task<IEnumerable<TaskItemDTO>> GetDataAsync()
        {
            //await Task.Delay(1000);
            return await Task.FromResult<IEnumerable<TaskItemDTO>>(tasks);
        }
    }
}
