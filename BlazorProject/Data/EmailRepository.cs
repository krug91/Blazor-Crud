using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Data
{
    public class EmailRepository : GenericRepository<Email> ,IEmailRepository
    {
        public EmailRepository(TaskContext context) :base(context)
        {
            
        }

    }
}
