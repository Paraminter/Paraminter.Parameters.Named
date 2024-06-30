namespace Paraminter.Parameters;

internal interface IFixture
{
    public abstract IQueryHandler<IGetNamedParameterQuery, INamedParameter> Sut { get; }
}
