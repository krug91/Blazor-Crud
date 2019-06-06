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
        public async Task<IEnumerable<EmailDetail>> GetTags(int id)
        {
            return await _repo.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public async Task<EmailDetail> GetEmailTag(int id)
        {
            return await _repo.GetById(id);
        }

        [HttpPost]
        public async Task AddTag([FromBody] EmailDetail emailDetail)
        {
            await _repo.Create(emailDetail);
        }

        [HttpDelete("{id}")]
        public async Task DeleteEmailTag(int id)
        {
            await _repo.Delete(id);
        }

        [HttpPut]
        public void UpdateTag([FromBody] EmailDetail emailDetail)
        {
            _repo.Update(emailDetail);
        }
    }
}