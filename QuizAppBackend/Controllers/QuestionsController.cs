using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // GET: api/Questions
        [HttpGet]
        public IEnumerable<Question> Get()
        {

            return _context.Questions;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {


            var question = await _context.Questions.SingleOrDefaultAsync(x => x.ID == id);

            if (question == null)
            {

                NotFound();
            }

            return Ok(question);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Question question)
        {

            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
            return Ok(question);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Question question)
        {

            if (id != question.ID) return BadRequest();

            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok(question);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
