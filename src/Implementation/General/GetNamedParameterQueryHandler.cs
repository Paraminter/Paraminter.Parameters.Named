namespace Paraminter.Parameters;

using System;

/// <summary>Handles <see cref="IGetNamedParameterQuery"/>, and responds with <see cref="INamedParameter"/>.</summary>
public sealed class GetNamedParameterQueryHandler
    : IQueryHandler<IGetNamedParameterQuery, INamedParameter>
{
    /// <summary>Instantiates a <see cref="GetNamedParameterQueryHandler"/>, handling <see cref="IGetNamedParameterQuery"/>.</summary>
    public GetNamedParameterQueryHandler() { }

    INamedParameter IQueryHandler<IGetNamedParameterQuery, INamedParameter>.Handle(
        IGetNamedParameterQuery query)
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
