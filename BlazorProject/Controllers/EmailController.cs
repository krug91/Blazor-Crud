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
        public IEnumerable<Email> Get()
        {
            return _repo.GetEmails();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Email Get(int id)
        {
            return _repo.GetEmail(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Email email)
        {
            _repo.AddEmail(email);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put([FromBody]Email email)
        {
            _repo.UpdateEmail(email);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.DeleteEmail(id);
        }
    }
}
