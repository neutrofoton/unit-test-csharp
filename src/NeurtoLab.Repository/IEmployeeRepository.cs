using NeurtoLab.Repository.Model;

namespace NeurtoLab.Repository;
public interface IEmployeeRepository
{
    Task<IList<Employee>> GetEmployeesAsync();
}
