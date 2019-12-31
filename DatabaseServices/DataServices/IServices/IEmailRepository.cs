
using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Services
{
    public interface IEmailRepository
    {
        Task Delete(Email email); 
    }
}
