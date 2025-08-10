namespace Api;


public static class Program {

    public static int Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddOpenApi().AddControllers();

        var app = builder.Build();
        app.MapControllers();
        app.Run();

        return 0;
    }

}
