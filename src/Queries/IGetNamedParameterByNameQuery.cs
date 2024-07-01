namespace Paraminter.Parameters;

/// <summary>Represents a query for a named parameter, given the name of the named parameter.</summary>
public interface IGetNamedParameterByNameQuery
    : IQuery
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}
