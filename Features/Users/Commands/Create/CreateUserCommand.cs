using MediatR;

namespace CursoMediatRCQRS.Features.Users.Commands.Create
{
    public record CreateUserCommand(string Nome, string Sobrenome, string Email, string CPF): IRequest<Guid>;
}
