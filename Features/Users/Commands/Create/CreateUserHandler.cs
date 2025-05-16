using CursoMediatRCQRS.Application.Models;
using CursoMediatRCQRS.Infrastructure.Data;
using MediatR;

namespace CursoMediatRCQRS.Features.Users.Commands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly AppDBContext _context;
        public CreateUserHandler(AppDBContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Nome = request.Nome,
                CPF = request.CPF,
                Email = request.Email,
                Sobrenome = request.Sobrenome,
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
