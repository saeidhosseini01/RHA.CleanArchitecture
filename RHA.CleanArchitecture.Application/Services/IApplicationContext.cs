using Microsoft.EntityFrameworkCore;
using RHA.CleanArchitecture.Domain.Entities.User;

namespace RHA.CleanArchitecture.Application.Services
{
    public interface IApplicationContext
    {
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync();
    }
}
