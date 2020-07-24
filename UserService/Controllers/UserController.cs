using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly TasketContext db = new TasketContext();

        // GET: api/<UserController>
       [Route("GetUser")]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.User.Where(x => x.IsActive == true).ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("Get/{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [Route("AddUser")]
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                db.User.Add(user);
                db.SaveChangesAsync();

                return StatusCode(StatusCodes.Status201Created, user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [Route("Delete/{id:int}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                User _user = db.User.Find(1);
                _user.IsActive = false;
                db.Entry(_user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK,"Deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }

        }
    }
}
