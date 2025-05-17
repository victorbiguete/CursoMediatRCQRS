using CursoMediatRCQRS.Application.Models;
using CursoMediatRCQRS.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CursoMediatRCQRS.Features.Users.Queries.GetUserById
{
    public class GetUserByIdHandler :IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly AppDBContext _context;

        public GetUserByIdHandler(AppDBContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.Where(u => u.Id == request.id).FirstOrDefaultAsync();

            return user;
        }
    }
}
