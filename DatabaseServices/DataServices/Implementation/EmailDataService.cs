using BlazorProject.Models;
using DatabaseServices.DataServices.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseServices.DataServices.Implementation
{
    public class EmailDataService : IEmailDataService
    {
        private readonly ApplicationDbContext dbContext;
        public EmailDataService(ApplicationDbContext applicationDb)
        {
            dbContext = applicationDb;
        }

        public async Task<string> Create(Email entity)
        {
            try
            {
                dbContext.Email.Add(entity);
                await dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return $"{ex.Message}";
            }

            return "Ok";
        }

        public Task<string> Delete(Email entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Email>> LoadAllData()
        {

            var result = await dbContext.Email.ToListAsync();

            return result;
        }

        public Task<string> Update(Email entity)
        {
            throw new NotImplementedException();
        }
    }
}
