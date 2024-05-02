namespace Paraminter.Parameters.NamedParameterFactoryCases.NamedParameterCases;

internal interface IParameterFixture
{
    public abstract INamedParameter Sut { get; }

    public abstract string Name { get; }
}
