using Xunit;

namespace Demo.Tests;

public class AssertNullBoolTests
{
    [Fact]
    public void Employee_Name_ShouldNotBeNullOrEmpty()
    {
        //Arrange & Act
        var employee = new Employee("Felipe", 1000);

        //Assert
        Assert.False(string.IsNullOrEmpty(employee.Name));
    }
    
    [Fact]
    public void Employee_Name_ShouldNotHaveNickname()
    {
        //Arrange & Act
        var employee = new Employee("Felipe", 1000);

        //Assert
        Assert.True(string.IsNullOrEmpty(employee.Nickname));
        Assert.False(!string.IsNullOrEmpty(employee.Nickname));
    }
}