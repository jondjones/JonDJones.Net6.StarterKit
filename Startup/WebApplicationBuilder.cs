namespace JonDJones.Net6.StarterKit.Startup;

public static class ConfigurationInitializer
{
    public static IHostBuilder ConfigureAppSettings(this IHostBuilder host)
    {
        var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var machineName = Environment.MachineName;

        host.ConfigureAppConfiguration((ctx, builder) =>
        {
            builder.AddJsonFile("appsettings.json", false, true);
            builder.AddJsonFile($"appsettings.{enviroment}.json", true, true);
            builder.AddJsonFile($"appsettings.{machineName}.json", true, true);
            builder.AddEnvironmentVariables();
        });

        return host;
    }
}






















//namespace JonDJones.Net6.StarterKit.Startup;

//public static class ConfigurationInitializer
//{
//    private readonly static bool enableSetting = false;

//    public static IHostBuilder ConfigureAppSettings(this IHostBuilder host)
//    {
//        var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

//        host.ConfigureAppConfiguration((ctx, builder) =>
//        {
//            builder.AddJsonFile("appsettings.json", enableSetting, true);
//            builder.AddJsonFile($"appsettings.{enviroment}.json", true, true);
//            builder.AddJsonFile($"appsettings.{Environment.MachineName}.json", true, true);

//            builder.AddEnvironmentVariables();
//        });

//        return host;
//    }
//}

