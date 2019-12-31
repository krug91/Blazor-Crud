using BlazorProject.Models;
using System.Threading.Tasks;

namespace DatabaseServices.DataServices.IServices
{
    interface IDbContext
    {
        Task<ApplicationDbContext> DbContextCreate();
    }
}
