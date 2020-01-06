using BlazorProject.Models;
using DatabaseServices.DataServices.IServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseServices.DataServices.Implementation
{
    public class EmailDataService : IEmailDataService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public EmailDataService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task<string> Create(Email entity)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                try
                {
                    dbContext.Email.Add(entity);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return $"{ex.Message}";
                }

                return "Ok";
            }
        }

        public async Task<string> Delete(Email entity)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                try
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var removeEmail = await dbContext.Email.FirstOrDefaultAsync(x => x.Id == entity.Id);
                    dbContext.Email.Remove(removeEmail);

                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

                return "Ok";
            }
        }

        public async Task<List<Email>> GetAllEmails()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var result = await dbContext.Email.AsNoTracking().ToListAsync();

                return result;
            }
        }

        public Task<string> Update(Email entity)
        {
            throw new NotImplementedException();
        }
    }
}
