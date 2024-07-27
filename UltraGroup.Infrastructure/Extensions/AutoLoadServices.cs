using Microsoft.Extensions.DependencyInjection;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Common;
using UltraGroup.Infrastructure.Adapters;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Extensions;

public static class AutoLoadServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));

        services.AddTransient<IUnitOfWork, UnitOfWork>();

        var _services = AppDomain.CurrentDomain.GetAssemblies()
              .Where(assembly =>
              {
                  return (assembly.FullName is null) || assembly.FullName.Contains("Domain", StringComparison.OrdinalIgnoreCase);
              })
              .SelectMany(assembly => assembly.GetTypes())
              .Where(type => type.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(DomainServiceAttribute)));

        var _repositories = AppDomain.CurrentDomain.GetAssemblies()
            .Where(assembly =>
            {
                return (assembly.FullName is null) || assembly.FullName.Contains("Infrastructure", StringComparison.OrdinalIgnoreCase);
            })
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => type.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(RepositoryAttribute)));

        foreach (var service in _services)
        {
            services.AddTransient(service);
        }

        foreach (var repository in _repositories)
        {
            Type typeInterface = repository.GetInterfaces().Single();
            services.AddTransient(typeInterface, repository);
        }

        return services;
    }
}
