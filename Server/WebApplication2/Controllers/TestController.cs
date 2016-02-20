using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api")]
    public class TestController : ApiController
    {
        /// <summary>
        /// This is a test message
        /// </summary>
        /// <returns>Hello world</returns>
        /// <remarks>Well, screw you chubaka!</remarks>
        [Route("Test")]
        [HttpPost]
        public async Task<IHttpActionResult> Test(Request request)
        {
            if (ModelState.IsValid == false)
            {
                
                return BadRequest(ModelState);
            }

            return Ok(new TestClass(request.Name));
        } 
    }

    public class Request
    {
        [Required]
        public string Name { get; set; }
    }

    public class TestClass
    {
        public string Message { get; private set; }
        public List<string> Properties { get; private set; }

        public Advanced Advanced { get; set; }

        public TestClass(string name)
        {
            Message = "Hello " + name;
            Properties = new List<string>() {"abc", "def", "ghj"};
            Advanced = new Advanced
            {
                A = "What is the ultimate answer?",
                B = 42
            };

        }
    }

    public class Advanced
    {
        public string A { get; set; }

        public int B { get; set; }
    }
}
