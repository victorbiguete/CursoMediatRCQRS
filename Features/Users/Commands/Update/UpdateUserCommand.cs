using MediatR;

namespace CursoMediatRCQRS.Features.Users.Commands.Update
{
    public record UpdateUserCommand(Guid id,string nome, string sobrenome, string email, string cpf) : IRequest<bool>;
}
