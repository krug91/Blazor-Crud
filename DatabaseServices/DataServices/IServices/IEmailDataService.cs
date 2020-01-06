using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorProject.Models;
namespace DatabaseServices.DataServices.IServices
{
    public interface IEmailDataService
    {
        Task<string> Create(Email entity);
        Task<string> Update(Email entity);
        Task<string> Delete(Email entity);
        Task<List<Email>> GetAllEmails();
    }
}
