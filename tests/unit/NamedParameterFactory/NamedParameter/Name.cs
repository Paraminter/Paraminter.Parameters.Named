namespace Paraminter.Parameters.NamedParameter;

using Xunit;

public sealed class Name
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsName()
    {
        var result = Target();

        Assert.Same(Fixture.Name, result);
    }

    private string Target() => Fixture.Sut.Name;
}
