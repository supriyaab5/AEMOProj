using Xunit;
using System.Collections.Generic;

public class MatchServiceTests
{
    [Fact]
    public void Should_Return_Correct_Positions_For_Simple_Match()
    {
        var service = new MatchService();
        var result = service.FindMatches("Hello World", "lo");

        Assert.Equal(new List<int> { 4 }, result);
    }

    [Fact]
    public void Should_Return_Multiple_Positions_For_Repeated_Match()
    {
        var service = new MatchService();
        var result = service.FindMatches("testTestTEST", "test");

        Assert.Equal(new List<int> { 1, 5, 9 }, result);
    }

    [Fact]
    public void Should_Return_Empty_For_No_Match()
    {
        var service = new MatchService();
        var result = service.FindMatches("example", "xyz");

        Assert.Empty(result);
    }

    [Fact]
    public void Should_Handle_Empty_Input()
    {
        var service = new MatchService();
        var result = service.FindMatches("", "test");

        Assert.Empty(result);
    }
}