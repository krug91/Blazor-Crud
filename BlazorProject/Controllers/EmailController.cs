using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorProject.Models;
using BlazorProject.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorProject.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        
        private readonly IEmailRepository _repo;

        public EmailController(IEmailRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Email>> Get()
        {
             return await _repo.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<Email> Get(int id)
        {
            return await _repo.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody] Email email)
        {
            await _repo.Create(email);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task Put([FromBody]Email email)
        {
            await _repo.Update(email);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}
