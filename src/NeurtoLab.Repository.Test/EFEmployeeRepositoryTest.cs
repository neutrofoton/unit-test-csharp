using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NeurtoLab.Repository.EF;
using NeurtoLab.Repository.Model;
using Xunit;

namespace NeurtoLab.Repository.Test;
public class EFEmployeeRepositoryTest
{
    [Fact]
    public async Task GetEmployees_WhenCalled_ReturnsEmployeeListAsync()
    {
        // Arrange
        var efContext =  new Mock<EFContext>();
        efContext.Setup<DbSet<Employee>>(x => x.Employees)
                 .ReturnsDbSet(FakeDataGenerator.GetFakeEmployeeList());
                 
        //Act
        IEmployeeRepository employeeRepository = new Mock<EmployeeRepository>(efContext.Object).Object;
        var employees = await employeeRepository.GetEmployeesAsync();

        //Assert
        Assert.NotNull(employees);
        Assert.Equal(2, employees.Count());
    }

}
