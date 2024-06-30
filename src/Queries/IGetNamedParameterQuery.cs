namespace Paraminter.Parameters;

/// <summary>Represents a query for a named parameter.</summary>
public interface IGetNamedParameterQuery
    : IQuery
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}
