namespace Api.Models;

public record RefUser {
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
}
