namespace JonDJones.Net6.StarterKit.Startup;

public static partial class ServiceInitializer
{
    public static IServiceCollection RegisterApplicationServices(
                                        this IServiceCollection services)
    {
        services.AddControllersWithViews();

        RegisterCustomDependencies(services);
        return services;
    }

    private static void RegisterCustomDependencies(IServiceCollection services)
    {
    }

}