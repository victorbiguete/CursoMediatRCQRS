using CursoMediatRCQRS.Application.Models;
using CursoMediatRCQRS.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CursoMediatRCQRS.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly AppDBContext _context;

        public GetAllUsersHandler(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync();
        }
    }
}
