namespace Attribinter.Parameters.NamedParameterFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NamedParameterFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INamedParameterFactory Sut;

        public FactoryFixture(INamedParameterFactory sut)
        {
            Sut = sut;
        }

        INamedParameterFactory IFactoryFixture.Sut => Sut;
    }
}
