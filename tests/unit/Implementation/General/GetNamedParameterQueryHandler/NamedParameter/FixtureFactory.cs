namespace Paraminter.Parameters.NamedParameter;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        Mock<IGetNamedParameterQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Name).Returns(name);

        IQueryHandler<IGetNamedParameterQuery, INamedParameter> factory = new GetNamedParameterQueryHandler();

        var sut = factory.Handle(queryMock.Object);

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
