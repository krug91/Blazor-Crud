using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseServices.DataServices.IServices;
using System.Threading.Tasks;

namespace DatabaseServices.DataServices.Implementation
{
    public class DbContextService : IDbContext
    {
        private readonly ApplicationDbContext _context;

        public async Task<ApplicationDbContext> DbContextCreate()
        {
            return new ApplicationDbContext(); 
        }
    }
}
