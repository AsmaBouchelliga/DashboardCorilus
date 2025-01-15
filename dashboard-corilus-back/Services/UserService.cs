using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoard1.Data;
using DashBoard1.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Services
{
    
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

      
    }

    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
