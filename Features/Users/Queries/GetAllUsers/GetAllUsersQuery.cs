using CursoMediatRCQRS.Application.Models;
using MediatR;

namespace CursoMediatRCQRS.Features.Users.Queries.GetAllUsers
{
    public record GetAllUsersQuery() : IRequest<List<User>>;
}
