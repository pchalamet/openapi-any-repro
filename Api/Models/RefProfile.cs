namespace Api.Models;

public record RefProfile {
    public required RefUser User { get; init; }
}
