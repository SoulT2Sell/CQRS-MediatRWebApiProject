using CQRS_MediatRWebApiProject.Features.Games.CreateGame;
using CQRS_MediatRWebApiProject.Features.Games.GetGameById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MediatRWebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameInfoController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateGame(CreateGameCommand command)
        {
            var response = await sender.Send(command);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameById(Guid id)
        {
            var response = await sender.Send(new GetGameByIdQuery(id));
            return response == null ? NotFound("Your game is not found") : Ok(response);
        }
    }
}
