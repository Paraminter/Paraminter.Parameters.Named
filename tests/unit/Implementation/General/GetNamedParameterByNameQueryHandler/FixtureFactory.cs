namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetNamedParameterByNameQueryHandler sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter> Sut;

        public Fixture(
            IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter> IFixture.Sut => Sut;
    }
}
