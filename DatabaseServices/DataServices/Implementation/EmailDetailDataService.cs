using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorProject.Models;
using BlazorProject.Services;
using DatabaseServices.DataServices.IServices;
namespace DatabaseServices.DataServices.Implementation
{
    public class EmailDetailDataService : IEmailDetailRepository
    {

        private readonly IDbContext _dbContext;

        public EmailDetailDataService(DbContextService dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Create(EmailDetail entity)
        {
            using var context = await _dbContext.DbContextCreate();
            try
            { 
            await context.EmailDetail.AddAsync(entity);
            }
            catch(Exception ex)
            {
                return $"{ex.Message}";
            }

            return "Ok";
        }
    }
}
