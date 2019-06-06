using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorProject.Data;
using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailDetailsController : ControllerBase
    {
        IEmailDetailRepository _repo;

        public EmailDetailsController(IEmailDetailRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public IEnumerable<EmailDetail> GetTags(int id)
        {
            return _repo.GetEmailTags(id);
        }

        [HttpGet("[action]/{id}")]
        public EmailDetail GetEmailTag(int id)
        {
            return _repo.GetEmailTag(id);
        }

        [HttpPost]
        public void AddTag([FromBody] EmailDetail emailDetail)
        {
            _repo.AddEmailTag(emailDetail);
        }

        [HttpDelete("{id}")]
        public void DeleteEmailTag(int id)
        {
            _repo.DeleteEmailTag(id);
        }

        [HttpPut]
        public void UpdateTag([FromBody] EmailDetail emailDetail)
        {
            _repo.UdpateEmailTag(emailDetail);
        }
    }
}