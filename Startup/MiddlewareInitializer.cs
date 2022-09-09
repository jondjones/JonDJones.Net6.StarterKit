namespace JonDJones.Net6.StarterKit.Startup;

public static class MiddlewareInitializer
{
    public static WebApplication ConfigureMiddleware(this WebApplication app)
    {
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        // MVC
        app.MapControllerRoute(
            "default",
            "{controller}/{action}/{id}",
            new { controller = "Homepage", action = "Index", id = "" });

        return app;
    }
}