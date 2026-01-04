using CQRS_MediatRWebApiProject.Models;
using MediatR;

namespace CQRS_MediatRWebApiProject.Features.Games.GetGameById
{
    public record GetGameByIdQuery(Guid id) : IRequest<GameInfo?>;
}
