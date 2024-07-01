namespace Paraminter.Parameters;

using System;

/// <summary>Handles <see cref="IGetNamedParameterByNameQuery"/>, and responds with <see cref="INamedParameter"/>.</summary>
public sealed class GetNamedParameterByNameQueryHandler
    : IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter>
{
    /// <summary>Instantiates a <see cref="GetNamedParameterByNameQueryHandler"/>, handling <see cref="IGetNamedParameterByNameQuery"/>.</summary>
    public GetNamedParameterByNameQueryHandler() { }

    INamedParameter IQueryHandler<IGetNamedParameterByNameQuery, INamedParameter>.Handle(
        IGetNamedParameterByNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new NamedParameter(query.Name);
    }

    private sealed class NamedParameter
        : INamedParameter
    {
        private readonly string Name;

        public NamedParameter(
            string name)
        {
            Name = name;
        }

        string INamedParameter.Name => Name;
    }
}
