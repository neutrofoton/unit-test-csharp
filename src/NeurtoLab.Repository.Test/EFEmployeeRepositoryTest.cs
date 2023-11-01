using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NeurtoLab.Repository.EF;
using NeurtoLab.Repository.Model;
using NeurtoLab.Repository.Test.ContextMock;
using Xunit;
using FluentAssertions;

namespace NeurtoLab.Repository.Test;
public class EFEmployeeRepositoryTest : IDisposable
{
    private IEmployeeRepository employeeRepository;
    // setup
    public EFEmployeeRepositoryTest()
    {
        var empEFContext = EFContextMock.DoMock<int, Employee, EFContext>(
            FakeDataGenerator.GetFakeEmployeeList(),
            x => x.Employees
        );

        employeeRepository = new Mock<EmployeeRepository>(empEFContext).Object;
    }
    
    // teardown
    public void Dispose()
    {
        // Dispose here
    }

    [Fact]
    public async Task GetEmployees_WhenCalled_ReturnsEmployeeListAsync()
    {
        var employees = await employeeRepository.GetEmployeesAsync();

        //Assert
        Assert.NotNull(employees);
        Assert.Equal(2, employees.Count());
    }

    [Fact]
    public void GetEmployeeById()
    {
        
        //Arrange
        int id = 1;

        //Act
        Employee data = employeeRepository.GetEmployeeById(id);            

        data.Should().NotBeNull();
        data.Id.Should().Be(id);
    }

    [Fact]
    public void AddEmployee()
    {
        //Arrange
        Employee actualData = new Employee()
        {
            Id = 100,
            Name = "New User",
            Age = 10
        };

        //Act
        bool isSuccess = employeeRepository.AddEmployee(actualData);
        Employee expectedData = employeeRepository.GetEmployeeById(actualData.Id);

        isSuccess.Should().BeTrue();
        expectedData.Should().NotBeNull().And.Match<Employee>(x => x.Id==actualData.Id);
    }

    [Fact]
    public void UpdateEmployee()
    {
        //Arrange
        int id = 2;
        Employee actualData = employeeRepository.GetEmployeeById(id);
        actualData.Name = "Update User";
        actualData.Age = 1500;

        //Act
        bool isSuccess = employeeRepository.UpdateEmployee(actualData);
        Employee expectedData = employeeRepository.GetEmployeeById(actualData.Id);

        isSuccess.Should().BeTrue();
        expectedData.Should().NotBeNull()
            .And.Match<Employee>(x => x.Id==actualData.Id)
            .And.Match<Employee>(x => x.Name==actualData.Name)
            .And.Match<Employee>(x => x.Age==actualData.Age)
            ;
            
    }

    [Fact]
    public void DeleteEmployee()
    {
        //Arrange
        int id = 2;
        Employee actualData = employeeRepository.GetEmployeeById(id);
        
        //Act
        bool isSuccess = employeeRepository.DeleteEmployee(actualData);
        Employee expectedData = employeeRepository.GetEmployeeById(actualData.Id);

        isSuccess.Should().BeTrue();
        expectedData.Should().BeNull();
    }

}
