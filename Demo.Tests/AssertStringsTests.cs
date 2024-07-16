using Xunit;

namespace Demo.Tests;

public class AssertStringsTests
{
    [Fact]
    public void StringTools_ConcatenateNames_ReturnFullName()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";
        const string fullNameExpected = "John Doe";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.Equal(fullNameExpected, fullName);
    }
    
    [Fact]
    public void StringTools_ConcatenateNames_MustIgnoreCase()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";
        const string fullNameExpected = "JOHN DOE";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.Equal(fullNameExpected, fullName, true);
    }
    
    [Fact]
    public void StringTools_ConcatenateNames_ShouldContainsSubstringFromConcatenateString()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.Contains("ohn".ToLower(), fullName.ToLower());
    }
    
    [Fact]
    public void StringTools_ConcatenateNames_ShouldStartsWith()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.StartsWith("John".ToLower(), fullName.ToLower());
    }
    
    [Fact]
    public void StringTools_ConcatenateNames_ShouldEndsWith()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.EndsWith("Doe".ToLower(), fullName.ToLower());
    }
    
    [Fact]
    public void StringTools_ConcatenateNames_ShouldValidateRegex()
    {
        // Arrange
        var stringTools = new StringTools();
        const string firstName = "John";
        const string lastName = "Doe";

        // Act
        var fullName = stringTools.Concatenate(firstName, lastName);

        // Assert
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
    }
}