
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
        public async Task AddAsync(TaskItemDTO taskItem)
        {
            await Task.Run(() => tasks.Add(taskItem));
        }

        public async Task SaveAsync(TaskItemDTO taskItem)
        {
            await Task.Run(() =>
            {
                var task = tasks.First(x => x.Id == taskItem.Id);
                tasks.Remove(task);
                tasks.Add(taskItem);
            });
        }

        public async Task<IEnumerable<TaskItemDTO>> GetDataAsync()
        {
            //await Task.Delay(1000);
            return await Task.FromResult<IEnumerable<TaskItemDTO>>(tasks);
        }

        public async Task<TaskItemDTO> GetTaskAsync(int Id)
        {
            return await Task.FromResult<TaskItemDTO>(tasks.First(x => x.Id == Id));
        }

        public async Task RemoveAsync(int Id)
        {
            await Task.Run(() => tasks.Remove(tasks.First(x => x.Id == Id)));
        }
    }
}
