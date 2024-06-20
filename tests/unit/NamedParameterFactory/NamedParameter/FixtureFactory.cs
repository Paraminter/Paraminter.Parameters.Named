namespace Paraminter.Parameters.NamedParameter;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        var name = string.Empty;

        INamedParameterFactory factory = new NamedParameterFactory();

        var sut = factory.Create(name);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedParameter Sut;

        private readonly string Name;

        public Fixture(
            INamedParameter sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        INamedParameter IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}
