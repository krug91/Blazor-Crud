
using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Services
{
    public interface IEmailRepository
    {
        IEnumerable<Email> GetEmails();
        void AddEmail(Email email);
        Email GetEmail(int id);
        void DeleteEmail(int id);
        void UpdateEmail(Email email);
    }
}
