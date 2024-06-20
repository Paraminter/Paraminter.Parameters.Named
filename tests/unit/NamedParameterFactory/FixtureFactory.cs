namespace Paraminter.Parameters;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        NamedParameterFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameterFactory Sut;

        public Fixture(
            INamedParameterFactory sut)
        {
            Sut = sut;
        }

        INamedParameterFactory IFixture.Sut => Sut;
    }
}
