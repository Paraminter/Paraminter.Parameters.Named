namespace Paraminter.Parameters.NamedParameter;

using Xunit;

public sealed class Name
{
    [Fact]
    public void ReturnsName()
    {
        var name = "Name";

        var fixture = FixtureFactory.Create(name);

        var result = Target(fixture);

        Assert.Same(fixture.Name, result);
    }

    private static string Target(
        IFixture fixture)
    {
        return fixture.Sut.Name;
    }
}
