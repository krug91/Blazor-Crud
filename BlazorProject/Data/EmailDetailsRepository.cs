using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Data
{
    public class EmailDetailRepository : IEmailDetailRepository
    {
        private readonly TaskContext _context;

        public EmailDetailRepository(TaskContext taskContext)
        {
            _context = taskContext;
        }

        public void AddEmailTag(EmailDetail emailDetail)
        {
            _context.EmailDetail.Add(emailDetail);
            _context.SaveChanges();
        }

        public void DeleteEmailTag(int id)
        {
            EmailDetail emailDetail = _context.EmailDetail.Find(id);
            _context.EmailDetail.Remove(emailDetail);
            _context.SaveChanges();
        }

        public EmailDetail GetEmailTag(int id)
        {
            EmailDetail emailTag = _context.EmailDetail.Find(id);
            return emailTag;
        }

        public IEnumerable<EmailDetail> GetEmailTags(int id)
        {
            return _context.EmailDetail.Where(s => s.Emailid == id).ToList();
        }

        public void UdpateEmailTag(EmailDetail emailDetail)
        {
            _context.EmailDetail.Update(emailDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
