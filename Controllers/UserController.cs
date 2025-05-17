using CursoMediatRCQRS.Features.Users.Commands.Create;
using CursoMediatRCQRS.Features.Users.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoMediatRCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/Create")]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            if (id == null)
                return BadRequest("Falha na criação do usuario");

            return Created();
        }

        [HttpGet("/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());

            if(result == null)
                return NotFound("Não Existe Usuarios Cadastrados");

            return Ok(result);
        }
    }
}
