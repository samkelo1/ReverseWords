using System;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void ReverseWordOrder_Way_ShouldReverseWordOrder()
    {
        // Arrange
        string inputString = "this is a test";
        string inputString2 = "foobar";
        string inputString3 = "all your base";

        // Act
        string result1 = Program.ReverseWordOrder_Way(inputString);
        string result2 = Program.ReverseWordOrder_Way(inputString2);
        string result3 = Program.ReverseWordOrder_Way(inputString3);

        // Assert
        Assert.Equal("test a is this", result1);
        Assert.Equal("foobar", result2);
        Assert.Equal("base your all", result3);
    }
}
