namespace Paraminter.Parameters.NamedParameterFactoryCases.NamedParameterCases;

internal static class ParameterFixtureFactory
{
    public static IParameterFixture Create()
    {
        var name = string.Empty;

        INamedParameterFactory factory = new NamedParameterFactory();

        var sut = factory.Create(name);

        return new ParameterFixture(sut, name);
    }

    private sealed class ParameterFixture
        : IParameterFixture
    {
        private readonly INamedParameter Sut;

        private readonly string Name;

        public ParameterFixture(
            INamedParameter sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        INamedParameter IParameterFixture.Sut => Sut;

        string IParameterFixture.Name => Name;
    }
}
