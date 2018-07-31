using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizAppBackend.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuizAppBackend.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        readonly QuizContext _context;

        public QuestionsController(QuizContext context)
        {
            this._context = context;

        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return new Question[] { };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]Question question)
        {

            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
