namespace Api.Models;

public record Ref {
    // BUG: Remove this line and openapi is ok.
    //      Keep the line and openapi contains any (see RefProfile and RefProfile2).
    public required string Id { get; init; }
}
