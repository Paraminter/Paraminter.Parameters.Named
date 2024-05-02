namespace Paraminter.Parameters.NamedParameterFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NamedParameterFactory Target() => new();
}
