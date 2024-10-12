using Microsoft.EntityFrameworkCore;
using ToDoServerApp.Data.Interfaces;

namespace ToDoServerApp.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
