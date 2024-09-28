using RHA.CleanArchitecture.Application.Services;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RHA.CleanArchitecture.Infrastructure.Data.DBContext;

namespace RHA.CleanArchitecture.Infrastructure.Services
{
    public class UserService :  IUserServices
    {
        private readonly ApplicationContext _context;
        public UserService(ApplicationContext context) 
        {
            _context = context;
        }

    }
}
