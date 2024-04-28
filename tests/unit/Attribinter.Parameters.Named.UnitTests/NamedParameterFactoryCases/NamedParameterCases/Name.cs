namespace Attribinter.Parameters.NamedParameterFactoryCases.NamedParameterCases;

using Xunit;

public sealed class Name
{
    private string Target() => Fixture.Sut.Name;

    private readonly IParameterFixture Fixture = ParameterFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.Name, result);
    }
}
