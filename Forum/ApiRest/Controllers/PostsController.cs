using ApiRest.Models;
using Microsoft.AspNetCore.Mvc;
using TodoManagement.Data;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRest.Controllers
{

    
    [Route("api/post")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PostsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<PostsController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _context.Posts.ToArray<Post>();
        }



        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            try
            {
                return _context.Posts.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return new Post();
            }
        }

        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] Post value)
        {
            _context.Posts.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody][Bind("Id,Title,Body,Category")] Post value)
        { 
            value.Id = id; 
            _context.Update(value);

            _context.SaveChanges();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Posts.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}
