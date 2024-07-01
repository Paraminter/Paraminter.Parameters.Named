namespace Paraminter.Parameters;

internal interface IFixture
{
    public abstract IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter> Sut { get; }
}
