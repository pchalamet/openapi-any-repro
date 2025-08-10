namespace Api.Models;

public record Subscription {
    public required RefProfile Profile { get; init; }
    public required RefProfile? Advisor { get; init; }
}
