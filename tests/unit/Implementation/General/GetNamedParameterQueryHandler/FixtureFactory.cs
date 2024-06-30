namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetNamedParameterQueryHandler sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetNamedParameterQuery, INamedParameter> Sut;

        public Fixture(
            IQueryHandler<IGetNamedParameterQuery, INamedParameter> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetNamedParameterQuery, INamedParameter> IFixture.Sut => Sut;
    }
}
