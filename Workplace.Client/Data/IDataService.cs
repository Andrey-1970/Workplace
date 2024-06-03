using Workplace.Shared;

namespace Workplace.Client.Data
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItemDTO>> GetDataAsync();
        Task AddAsync(TaskItemDTO dto);
    }
}
