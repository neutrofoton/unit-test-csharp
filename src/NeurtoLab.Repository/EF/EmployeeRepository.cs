
using Microsoft.EntityFrameworkCore;
using NeurtoLab.Repository.Model;

namespace NeurtoLab.Repository.EF;
public class EmployeeRepository : EFRepository, IEmployeeRepository
{
    public EmployeeRepository(EFContext efContext):base(efContext){

    }

    public async Task<IList<Employee>> GetEmployeesAsync()
    {
        return await this.EFContext.Employees.ToListAsync();
    }
}
