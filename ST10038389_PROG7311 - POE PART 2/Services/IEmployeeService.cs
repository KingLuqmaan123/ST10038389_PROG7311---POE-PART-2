using System.Collections.Generic;
using System.Threading.Tasks;
using ST10038389_PROG7311_PART_2_OF_POE.Models;

namespace ST10038389_PROG7311_PART_2_OF_POE.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
    }
}
//----------------------------------- END OF FILE -------------------------------------------------------------------------------------------
