using BlazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Services
{
    public interface IEmailDetailRepository
    {
        IEnumerable<EmailDetail>GetEmailTags(int id);
        EmailDetail GetEmailTag(int id);
        void AddEmailTag(EmailDetail emailDetail);
        void DeleteEmailTag(int id);
        void UdpateEmailTag(EmailDetail emailDetail);
    }
}
