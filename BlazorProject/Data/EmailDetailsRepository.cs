using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Data
{
    public class EmailDetailRepository : GenericRepository<EmailDetail>, IEmailDetailRepository
    {
        private readonly TaskContext _context;

        public EmailDetailRepository(TaskContext taskContext) : base(taskContext)
        {
            _context = taskContext;
        }

     
    }
}
