using MediatR;

namespace CQRS_MediatRWebApiProject.Features.Games.CreateGame
{
    public record CreateGameCommand(string Title, string Genre) : IRequest<Guid?>;
}
