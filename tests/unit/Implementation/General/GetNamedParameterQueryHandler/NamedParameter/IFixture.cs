namespace Paraminter.Parameters.NamedParameter;

internal interface IFixture
{
    public abstract INamedParameter Sut { get; }

    public abstract string Name { get; }
}
