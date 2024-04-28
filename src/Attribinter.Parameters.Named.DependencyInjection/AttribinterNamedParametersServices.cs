namespace Attribinter.Parameters;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Attribinter.Parameters.Named</i> to be registered with <see cref="IServiceCollection"/>.</summary>
public static class AttribinterNamedParametersServices
{
    /// <summary>Registers the services provided by <i>Attribinter.Parameters.Named</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddAttribinterNamedParameters(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<INamedParameterFactory, NamedParameterFactory>();

        return services;
    }
}
