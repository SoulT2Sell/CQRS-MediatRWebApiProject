using CQRS_MediatRWebApiProject.Data;
using CQRS_MediatRWebApiProject.Models;
using MediatR;

namespace CQRS_MediatRWebApiProject.Features.Games.GetGameById
{
    public class GetGameByIdQueryHandler(AppDbContext context) : IRequestHandler<GetGameByIdQuery, GameInfo?>
    {
        public async Task<GameInfo?> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
        {
            var Game = await context.GameInfos.FindAsync(request.id);

            return Game;
        }
    }
}
