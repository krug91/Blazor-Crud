using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Data
{
    public class EmailRepository : IEmailRepository
    {
        private readonly TaskContext _context;


        public EmailRepository(TaskContext context)
        {
            _context = context;
        }

        public void AddEmail(Email email)
        {
            _context.Email.Add(email);
            _context.SaveChanges();
        }

        public void DeleteEmail(int id)
        {
            Email email = _context.Email.Find(id);
            _context.Email.Remove(email);
            _context.SaveChanges();
        }

        public Email GetEmail(int id)
        {
            Email email = _context.Email.Find(id);
            return email;
        }

        public IEnumerable<Email> GetEmails()
        {
            return _context.Email.ToList();
        }

        public void UpdateEmail(Email email)
        {
            _context.Email.Update(email).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
