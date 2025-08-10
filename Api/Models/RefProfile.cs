namespace Api.Models;

public record RefProfile : Ref {
    public required RefUser User { get; init; }
}
