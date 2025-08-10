namespace Api.Models;

public record RefProfile {
    public required string Name { get; init; }
    public required RefUser User { get; init; }
}
