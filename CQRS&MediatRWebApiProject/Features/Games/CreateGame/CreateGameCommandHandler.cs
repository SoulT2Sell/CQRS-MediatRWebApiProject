using CQRS_MediatRWebApiProject.Data;
using CQRS_MediatRWebApiProject.Models;
using MediatR;

namespace CQRS_MediatRWebApiProject.Features.Games.CreateGame
{
    public class CreateGameCommandHandler(AppDbContext context) : IRequestHandler<CreateGameCommand, Guid?>
    {
        public async Task<Guid?> Handle(CreateGameCommand request, CancellationToken cancellationToken)
        {
            var newGame = new GameInfo
            {
                Title = request.Title,
                Genre = request.Genre
            };

            context.GameInfos.Add(newGame);
            await context.SaveChangesAsync();

            return newGame.Id;
        }
    }
}
