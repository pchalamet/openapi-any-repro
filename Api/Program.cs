
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapGet("/get", () =>
    new Subscription {
        Advisor = null,
        Profile = new RefProfile { User = new RefUser { Name = "Toto " } },
    });

app.MapOpenApi("/");
app.Run();


public record Subscription {
    public required RefProfile Profile { get; init; }
    public required RefProfile? Advisor { get; init; } // <-- NRT is the problem here
}

public record RefProfile {
    public required RefUser User { get; init; }
}

public record RefUser {
    public required string Name { get; init; }
}
