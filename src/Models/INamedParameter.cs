namespace Paraminter.Parameters.Named.Models;

using Paraminter.Parameters.Models;

/// <summary>Represents a named parameter.</summary>
public interface INamedParameter
    : IParameter
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}
