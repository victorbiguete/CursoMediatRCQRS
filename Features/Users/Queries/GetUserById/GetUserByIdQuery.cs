using CursoMediatRCQRS.Application.Models;
using MediatR;

namespace CursoMediatRCQRS.Features.Users.Queries.GetUserById
{
    public record GetUserByIdQuery(Guid id) : IRequest<User>;
    
}
