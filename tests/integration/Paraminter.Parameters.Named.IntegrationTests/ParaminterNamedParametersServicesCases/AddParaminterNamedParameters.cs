namespace Paraminter.Parameters.ParaminterParametersServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Xunit;

public sealed class AddParaminterNamedParameters
{
    [Fact]
    public void INamedParameterFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedParameterFactory>();

    private static void Target(IServiceCollection services) => ParaminterNamedParametersServices.AddParaminterNamedParameters(services);

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>()
        where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);
    }
}
