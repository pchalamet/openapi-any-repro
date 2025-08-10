namespace Api.Models;

public record RefProfile {
    public required string Id { get; init; }
    public required RefUser User { get; init; }
}
