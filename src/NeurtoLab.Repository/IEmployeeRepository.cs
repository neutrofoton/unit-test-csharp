using NeurtoLab.Repository.Model;

namespace NeurtoLab.Repository;
public interface IEmployeeRepository
{
    Task<IList<Employee>> GetEmployeesAsync();

    Employee GetEmployeeById(int id);
    bool AddEmployee(Employee employee);
    bool DeleteEmployee(Employee employee);
    bool UpdateEmployee(Employee employee);
}
